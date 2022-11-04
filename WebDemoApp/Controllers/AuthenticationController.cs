using Microsoft.AspNetCore.Mvc;

namespace WebDemoApp.Controllers
{
    public class AuthenticationController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
