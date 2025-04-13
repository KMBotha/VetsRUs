using Microsoft.AspNetCore.Mvc;
using VetsMVC.Models;
using VetsMVC.Services;

namespace VetsMVC.Controllers
{
    public class CatController : Controller
    {
        private readonly VetServices _vetServices;

        public CatController(VetServices vetService)
        {
            _vetServices = vetService;
        }

        public async Task<IActionResult> Index()
        {
            var cats = await _vetServices.GetAllCats();
            return View(cats);
        }

        public async Task<IActionResult> CatDetails(int id)
        {
            var cat = await _vetServices.GetCat(id);
            return View(cat);
        }

        public IActionResult AddCat() => View();

        [HttpPost]
        public async Task<IActionResult> AddCat(Cat cat)
        {
            await _vetServices.CreateCat(cat);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> EditCat(int id)
        {
            var cat = await _vetServices.GetCat(id);
            return View(cat);
        }

        [HttpPost]
        public async Task<IActionResult> EditCat(int id, Cat cat)
        {
            await _vetServices.UpdateCat(id, cat);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> RemoveCat(int id)
        {
            var cat = await _vetServices.GetCat(id);
            return View(cat);
        }

        [HttpPost, ActionName("RemoveCat")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _vetServices.DeleteCat(id);
            return RedirectToAction(nameof(Index));
        }
    }
}