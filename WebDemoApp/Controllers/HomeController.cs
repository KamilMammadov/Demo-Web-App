using Microsoft.AspNetCore.Mvc;

namespace WebDemoApp.Controllers
{
    public class HomeController :Controller
    {
        public ViewResult Index()
        {
            return View();  
        }
    }
}
