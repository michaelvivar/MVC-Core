using Microsoft.AspNetCore.Mvc;
using Website.Services;

namespace Website.Controllers
{
    public class MainController : Controller
    {
        private readonly IUserService UserService;
        public MainController(IUserService userService)
        {
            UserService = userService;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        [Route("Error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
