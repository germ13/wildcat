using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Wildcat.App.Views.Shared.Components
{
    public class UserProfileViewComponent : ViewComponent
    {
        private const string _DOMAIN = "PRECASTCORP";

        public UserProfileViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync(HttpContext context)
        {
            var name = User.Identity.Name.Replace(_DOMAIN + @"\", string.Empty);
            var initials = "" + name[0] + name[name.IndexOf('.') + 1];

            ViewBag.UserName = name;
            ViewBag.DisplayName = name.Replace('.', ' ');
            ViewBag.Initials = initials;

            return View();
        }
    }
}