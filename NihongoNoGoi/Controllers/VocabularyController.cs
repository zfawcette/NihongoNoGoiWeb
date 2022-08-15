using Microsoft.AspNetCore.Mvc;

namespace NihongoNoGoi.Controllers
{
    public class VocabularyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert()
        {
            return View();
        }

        public IActionResult Remove()
        {
            return View();
        }
    }
}
