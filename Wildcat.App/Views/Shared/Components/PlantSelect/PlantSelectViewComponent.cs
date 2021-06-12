using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Wildcat.App.Utilities;
//TODO using Wildcat.App.ViewModels.Loupe;
using Wildcat.Entities.PCC.Wildcat;

namespace Wildcat.App.Views.Shared.Components.PlantSelect
{
    public class PlantSelectViewModel
    {
        public string SelectedPlant { get; set; }
        public List<SelectListItem> Plants { get; set; }
    }

    public class PlantSelectViewComponent : ViewComponent
    {
        //TODO why was HttContextAccessor being used here?
        private readonly WildcatContext _context;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        public PlantSelectViewComponent(WildcatContext context) //, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            //_httpContextAccessor = httpContextAccessor;
        }

        public IViewComponentResult Invoke()
        {
            EndUser user = new WildcatUser(_context).GetUserByName(User.Identity.Name);

            List<SelectListItem> Locations = new List<SelectListItem>();
            foreach (var i in user.EndUserToLocation)
            {
                bool selected = i.LocationCode == new WildcatUser(_context).GetSelectedLocation(HttpContext);
                var loc = _context.Location.Where(x => x.LocationCode == i.LocationCode && x.Active == true).FirstOrDefault();
                if (loc != null)
                {
                    Locations.Add(new SelectListItem
                    {
                        Text = i.LocationCode,
                        Value = i.LocationCode,
                        Selected = selected
                    });
                }
            }
            PlantSelectViewModel vm = new PlantSelectViewModel();
            vm.Plants = Locations;
            vm.SelectedPlant = new WildcatUser(_context).GetSelectedLocation(HttpContext);

            CookieOptions opt = new CookieOptions();
            opt.Expires = System.DateTime.Now.AddMonths(3);
            HttpContext.Response.Cookies.Append("SelectedLocation", vm.SelectedPlant, opt);

            return View(vm);
        }
    }
}