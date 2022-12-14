using Microsoft.AspNetCore.Mvc;
using NihongoNoGoi.DataAccess.Repositories.IRepositories;
using NihongoNoGoi.Models;

namespace NihongoNoGoi.Controllers
{
    public class VocabularyController : Controller
    {
        private readonly IUnitOfWork _db;
        public VocabularyController(IUnitOfWork db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Vocabulary> Vocabulary = _db.VocabularyRepository.GetAll();
            return View(Vocabulary);
        }

        public IActionResult Upsert()
        {
            return View();
        }

        public IActionResult Remove(int id)
        {
            Vocabulary word = _db.VocabularyRepository.GetFirstOrDefault(u => u.Id == id);
            return View(word);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult RemovePOST(int? id)
        {
            Vocabulary word = _db.VocabularyRepository.GetFirstOrDefault(u => u.Id == id);
            if(word == null)
            {
                return NotFound();
            }
            _db.VocabularyRepository.Remove(word);
            _db.Save();
            return RedirectToAction("Index");
        }
    }
}
