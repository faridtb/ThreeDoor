using Microsoft.AspNetCore.Mvc;

namespace TeamApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult<string> GetTest()
        {
            return "test text";
        }
    }
}
