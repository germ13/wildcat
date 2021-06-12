using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Wildcat.Entities.PCC.Wildcat;

namespace Wildcat.App.Views.Shared.Components
{
    public class BreadCrumbViewComponent : ViewComponent
    {
        private readonly WildcatContext _dbContext;

        public BreadCrumbViewComponent(WildcatContext context)
        {
            _dbContext = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(HttpContext context)
        {
            var crumb = context.Request.Path.ToString().Split('/');
            crumb[0] = $"{context.Request.Scheme}://{context.Request.Host}/";

            return View(crumb);
        }
    }
}