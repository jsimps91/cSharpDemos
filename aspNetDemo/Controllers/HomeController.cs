using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace aspNetDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}