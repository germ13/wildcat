using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Wildcat.App.Models;
using Wildcat.App.Utilities;
using Wildcat.App.ViewModels.Home;
using Wildcat.Entities.PCC.Wildcat;

namespace Wildcat.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly WildcatContext _wildcatContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,IHttpContextAccessor httpContextAccessor, WildcatContext wildcatContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _wildcatContext = wildcatContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.Log(LogLevel.Information, $"User: {_httpContextAccessor.HttpContext.User.Identity.Name} ");
            HomeViewModel vm = new HomeViewModel();

            vm.UserName = new WildcatUser(_wildcatContext).GetUserByName(User.Identity.Name).AppLoginName;
            vm.PlantLocation = new WildcatUser(_wildcatContext).GetSelectedLocation(_httpContextAccessor.HttpContext);

            return View(vm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Wildcat";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Hello";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int? statuscode = null)
        {
            if (Response.StatusCode == 404)
            {
                return View("NotFound");
            }
            else if (Response.StatusCode == 401)
            {
                return View("RestrictedAccess", new { });
            }
            else
            {
                var feature = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
                var refer = ViewData["ErrorUrl"] = feature?.OriginalPath;

                var error = new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                    StatusCode = Response.StatusCode,
                    User = HttpContext.User.Identity.Name,
                    Referer = refer.ToString(),
                    QueryString = null
                };
                return View(error);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult RestrictedAccess(int? statuscode = null)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult ExpiredToken(int? statuscode = null)
        {
            return View();
        }
    }
}