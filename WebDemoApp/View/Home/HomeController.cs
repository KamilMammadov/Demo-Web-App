using Microsoft.AspNetCore.Mvc;

namespace WebDemoApp.View.Home
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
