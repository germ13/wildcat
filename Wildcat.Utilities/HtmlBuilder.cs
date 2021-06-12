
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
//using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.AspNetCore.Mvc.ViewFeatures;
//using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
//using System.Web.Mvc;
using TagBuilder = Microsoft.AspNetCore.Mvc.Rendering.TagBuilder;
using SelectListItem = Microsoft.AspNetCore.Mvc.Rendering.SelectListItem;
using ActionDescriptor = Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor;
//using ITempDataProvider = System.Web.Mvc.ITempDataProvider;
//using TempDataDictionary = Microsoft.AspNetCore.Mvc.ViewFeatures.TempDataDictionary;
//using ViewDataDictionary = Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary;

namespace Wildcat.Utilities
{
    public static class HtmlBuilder
    {
        public static string GetPortionBarHTML(string controlID, int FilledPortion, int UnfilledPortion, bool? IsPercent = false)
        {
            double filled = FilledPortion;
            double unfilled = UnfilledPortion;

            //IF it's a percent, leave the number as is.  If it's a value, divide by 40 to get a xmall, reasonable number of pixels
            if (!Conversion.SafeBoolean(IsPercent))
            {
                filled = Conversion.SafeDouble(Math.Round(filled / 40d, 0));
                unfilled = Conversion.SafeDouble(Math.Round(unfilled / 40d, 0));
            }

            StringBuilder rtv = new StringBuilder();

            //rtv.Append("<div class='demo-vertical-spacing-sm'>");
            rtv.Append("<div class='btn-group btn-group-toggle' data-toggle='buttons' style='width: 100%; height: 25px;'>");

            rtv.Append("<label id='");
            rtv.Append(controlID);
            rtv.Append("F' ");
            rtv.Append("class='btn btn-sm btn-primary' style='width: ");
            rtv.Append(Conversion.SafeInteger(filled));

            if (Conversion.SafeBoolean(IsPercent))
                rtv.Append("%; ");
            else
                rtv.Append("px; ");

            rtv.Append("height: 25px'>");
            rtv.Append("<input type='checkbox'>");
            rtv.Append("</label>");

            rtv.Append("<label id='");
            rtv.Append(controlID);
            rtv.Append("U' ");
            rtv.Append("class='btn btn-sm btn-outline-secondary' style='width: ");
            rtv.Append(Conversion.SafeInteger(unfilled));

            if (Conversion.SafeBoolean(IsPercent))
                rtv.Append("%; ");
            else
                rtv.Append("px; ");

            rtv.Append("height: 25px'>");
            rtv.Append("<input type='checkbox'>");
            rtv.Append("</label>");
            rtv.Append("</div>");
            //rtv.Append("</div>");

            string buffer = rtv.ToString();

            ZeroLengthProgressBar(ref buffer);

            return buffer;
        }

        //This function is necessary because a 0% progress bar still shows some portion as if 10%
        private static void ZeroLengthProgressBar(ref string style)
        {
            style = style.Replace("style='width: 0%;", "style='display: none;");
        }

        public static HtmlString Dropdown(string id, List<SelectListItem> selectListItems, string label, string selectedValue = null, int? width = null)
        {
            TagBuilder button = null;

            string styleOverrideString = string.Empty;

            if (width != null)
            {
                styleOverrideString = string.Format("width: {0}px; text-align: left !important;", width);

                button = new TagBuilder("button")
                {
                    Attributes =
            {
                    {"style", styleOverrideString },

                {"id", id},
                {"type", "button"},
                {"data-toggle", "dropdown"}
            }
                };
            }
            else
            {
                styleOverrideString = string.Format("width: 100%; text-align: left !important;", width);

                button = new TagBuilder("button")
                {
                    Attributes =
            {
                        {"style", styleOverrideString },

                {"id", id},
                {"type", "button"},
                {"data-toggle", "dropdown"}
            }
                };
            }

            button.AddCssClass("btn");
            button.AddCssClass("btn-default");
            button.AddCssClass("dropdown-toggle");

            if (selectedValue == null)
                button.InnerHtml.AppendHtml(label);
            else
            {
                SelectListItem sli = selectListItems.Where(x => x.Value.Equals(selectedValue)).FirstOrDefault();

                if (sli == null)
                    sli = selectListItems.Where(x => x.Text.Equals(selectedValue)).FirstOrDefault();

                if (sli == null)
                {
                    sli = new SelectListItem(selectedValue, selectedValue);
                    selectListItems.Add(sli);
                }

                button.InnerHtml.AppendHtml(sli.Text);
            }

            button.InnerHtml.AppendHtml(" ");
            button.InnerHtml.AppendHtml(BuildCaret());

            var wrapper = new TagBuilder("div");
            wrapper.AddCssClass("dropdown");

            wrapper.InnerHtml.AppendHtml(ConvertTagToString(button));
            wrapper.InnerHtml.AppendHtml(BuildDropdown(id, selectListItems));

            return new HtmlString(ConvertTagToString(wrapper));
        }

        public static HtmlString DropdownTextBox(string id, List<SelectListItem> selectListItems, string label, string selectedValue = null, int? width = null)
        {
            TagBuilder input = null;

            string styleOverrideString = string.Empty;

            if (width != null)
            {
                styleOverrideString = string.Format("width: {0}px; text-align: left !important;", width);

                input = new TagBuilder("input")
                {
                    Attributes =
            {
                    {"style", styleOverrideString },

                {"id", id},
                {"name", id.Replace('.', '_')},
                {"type", "text"},
                {"data-toggle", "dropdown"},
                {"value", selectedValue}
            }
                };
            }
            else
            {
                styleOverrideString = string.Format("width: 100%; text-align: left !important;", width);

                input = new TagBuilder("input")
                {
                    Attributes =
            {
                        {"style", styleOverrideString },

                {"id", id},
                {"name", id.Replace('.', '_')},
                {"type", "text"},
                {"data-toggle", "dropdown"},
                {"value", selectedValue}
            }
                };
            }

            input.AddCssClass("btn");
            input.AddCssClass("btn-default");
            input.AddCssClass("dropdown-toggle");

            input.InnerHtml.AppendHtml(" ");
            input.InnerHtml.AppendHtml(BuildCaret());

            var wrapper = new TagBuilder("div");
            wrapper.AddCssClass("dropdown");

            wrapper.InnerHtml.AppendHtml(ConvertTagToString(input));
            wrapper.InnerHtml.AppendHtml(BuildDropdown(id, selectListItems));

            return new HtmlString(ConvertTagToString(wrapper));
        }

        public static HtmlString ListBox(string id, List<SelectListItem> selectListItems, string label, string selectedValue = null, int? width = null)
        {
            TagBuilder input = null;

            string styleOverrideString = string.Empty;

            if (width != null)
            {
                styleOverrideString = string.Format("width: {0}px; text-align: left !important;", width);

                input = new TagBuilder("div")
                {
                    Attributes =
            {
                    {"style", styleOverrideString },

                {"id", id},
                {"name", id.Replace('.', '_')},
                {"data-toggle", "buttons"}
            }
                };
            }
            else
            {
                styleOverrideString = string.Format("width: 100%; text-align: left !important;", width);

                input = new TagBuilder("div")
                {
                    Attributes =
            {
                        {"style", styleOverrideString },

                {"id", id},
                {"name", id.Replace('.', '_')},
                {"data-toggle", "buttons"}
            }
                };
            }

            input.InnerHtml.AppendHtml(BuildListBox(id, selectListItems));

            input.AddCssClass("btn-group-vertical");
            input.AddCssClass("btn-group-toggle");

            return new HtmlString(ConvertTagToString(input));
        }

        private static string BuildListBox(string id, IEnumerable<SelectListItem> items)
        {
            HtmlContentBuilder hcb = new HtmlContentBuilder();

            //No 'Active' so by default, none are checked..if you wanted this, add 'active' after btn-primary

            foreach (var x in items)
            {
                var list = new TagBuilder("label")
                {
                    Attributes =
            {
                {"class", "btn-group-toggle btn btn-primary"}
            }
                };
                list.InnerHtml.AppendHtml(BuildListBoxRow(x));

                hcb.AppendHtml(list);
            }

            return ConvertTagToString(hcb);
        }

        private static string BuildListBoxRow(SelectListItem item)
        {
            var anchor = new TagBuilder("input")
            {
                Attributes =
                {
                    {"type", "checkbox"},
                    {"id", item.Value},
                    {"class", item.Text }
                }
            };

            anchor.InnerHtml.AppendHtml(item.Text);

            return ConvertTagToString(anchor);
        }

        private static string BuildCaret()
        {
            var caret = new TagBuilder("span");
            caret.AddCssClass("caret");

            return ConvertTagToString(caret);
        }

        private static string BuildDropdown(string id, IEnumerable<SelectListItem> items)
        {
            var list = new TagBuilder("ul")
            {
                Attributes =
                {
                    {"class", "dropdown-menu scrollable-menu"},
                    {"role", "menu"},
                    {"aria-labelledby", id}
                }
            };

            //var listItem = new TagBuilder("li");
            //listItem.Attributes.Add("role", "presentation");

            if (items != null)
            {
                foreach (var x in items)
                {
                    list.InnerHtml.AppendHtml("<li>");
                    list.InnerHtml.AppendHtml(BuildListRow(x));
                    list.InnerHtml.AppendHtml("</li>");
                }
            }

            return ConvertTagToString(list);
        }

        private static string BuildListRow(SelectListItem item)
        {
            var anchor = new TagBuilder("a")
            {
                Attributes =
            {
                {"class", "dropdown-item"},
                {"id", item.Value},
                {"href", "javascript:void(0);"}
            }
            };

            anchor.InnerHtml.AppendHtml(item.Text);

            return ConvertTagToString(anchor);
        }

        private static string ConvertTagToString(IHtmlContent tag)
        {
            StringWriter writer = new StringWriter();
            tag.WriteTo(writer, HtmlEncoder.Default);

            return writer.ToString();
        }
    }


    #region - viewRenderer

    public interface IViewRenderService
    {
        Task<string> RenderToStringAsync(string viewName, object model);
    }

    public class ViewRenderService : IViewRenderService
    {
        private readonly IRazorViewEngine _razorViewEngine;
        private readonly ITempDataProvider _tempDataProvider;
        private readonly IServiceProvider _serviceProvider;

        public ViewRenderService(IRazorViewEngine razorViewEngine,
            ITempDataProvider tempDataProvider,
            IServiceProvider serviceProvider)
        {
            _razorViewEngine = razorViewEngine;
            _tempDataProvider = tempDataProvider;
            _serviceProvider = serviceProvider;
        }

        public async Task<string> RenderToStringAsync(string viewName, object model)
        {
            var httpContext = new DefaultHttpContext { RequestServices = _serviceProvider };
            var actionContext = new ActionContext(httpContext, new RouteData(), new ActionDescriptor());

            using (var sw = new StringWriter())
            {
                var viewResult = _razorViewEngine.FindView(actionContext, viewName, false);
                //var viewResult = _razorViewEngine.GetView(viewName, false);
                if (viewResult.View == null)
                {
                    throw new ArgumentNullException($"{viewName} does not match any available view");
                }

                var viewDictionary = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
                {
                    Model = model
                };

                var viewContext = new ViewContext(
                    actionContext,
                    viewResult.View,
                    viewDictionary,
                    new TempDataDictionary(actionContext.HttpContext, _tempDataProvider),
                    sw,
                    new HtmlHelperOptions()
                );
                try
                {
                    await viewResult.View.RenderAsync(viewContext);
                }
                catch (Exception e)
                {

                }
                return sw.ToString();
            }
        }
    }

    #endregion - viewRenderer
}
