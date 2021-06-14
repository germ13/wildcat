using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.App.Models;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Logic.Administration;
using Wildcat.Logic.Administration.SecurityGroups;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels
{
    public class SecurityGroupViewModel
    {
        public List<SecurityGroup> SecurityGroups { get; set; }
        public SecurityGroup EditGroup { get; set; }
        public string SecurityGroupName { get; set; }
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public SecurityGroupViewModel()
        {
            SecurityGroupName = "";
            EditGroup = new SecurityGroup();
            SecurityGroups = new List<SecurityGroup>();
        }
    }

    public class EditGroupPartialResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;
        public Task<string> Form { get; set; }
        public SecurityGroup Group { get; set; }
        public EditGroupPartialResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                ID = ID.Replace(@"%20"," ");
                SecurityGroup group = _wildcatContext.SecurityGroup.Where(x => x.SecurityName == ID).FirstOrDefault();

                Form = _viewRenderService.RenderToStringAsync("Administration/SecurityGroup/EditGroupsPartial", group);
                success = true;
                message = "";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }


    public class AddGroupResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public AddGroupResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                var securityGroup = _wildcatContext.SecurityGroup.Where(x => x.SecurityName.ToUpper() == ID.ToUpper()).FirstOrDefault();

                if (securityGroup == null)
                {
                    _wildcatContext.SecurityGroup.Add(new SecurityGroup
                    {
                        SecurityName = ID.ToUpper(),
                        Active = true,
                        Added = DateTime.Now,
                        AddedBy = _httpContextAccessor.HttpContext.User.Identity.Name,
                        Updated = DateTime.Now,
                        UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name
                    });

                    message = "Security Group added.";
                }
                else
                {
                    securityGroup.Active = true;
                    securityGroup.Updated = DateTime.Now;
                    securityGroup.UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name;

                    message = "Security Group reactivated.";
                }

                _wildcatContext.SaveChanges();
                success = true;
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message;
            }
        }
    }

    public class EditGroupResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public EditGroupResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string ID, bool Active)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                var securityGroup = _wildcatContext.SecurityGroup.Where(x => x.SecurityName.ToUpper() == ID.ToUpper()).FirstOrDefault();
                securityGroup.Active = Active;
                securityGroup.Updated = DateTime.Now;
                securityGroup.UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name;

                if (Active)
                {
                    message = "Security Group reactivated.";
                }
                else
                {

                    message = "Security Group deactivated.";
                }

                _wildcatContext.SaveChanges();
                success = true;
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message;
            }
        }
    }

    public class SecurityGroupDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<SecurityGroup> data { get; set; }

        public SecurityGroupDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<SecurityGroup>();
        }

    }

    public class SecurityGroupDataTableData
    {
        public SecurityGroupDataSet set;
        public SecurityGroupDataTableData(WildcatContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new SecurityGroupDataSet();

            SecurityGroupsAdministration adminClass = new SecurityGroupsAdministration(context, viewRenderService);

            set.draw = draw;
            set.data = adminClass.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

}