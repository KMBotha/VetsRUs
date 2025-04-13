using Microsoft.AspNetCore.Mvc;
using VetsMVC.Models;
using VetsMVC.Services;

namespace VetsMVC.Controllers
{
    public class DogController : Controller
    {
        private readonly VetServices _vetServices;

        public DogController(VetServices vetService)
        {
            _vetServices = vetService;
        }

        public async Task<IActionResult> Index()
        {
            var dogs = await _vetServices.GetAllDogs();
            return View(dogs);
        }

        public async Task<IActionResult> DogDetails(int id)
        {
            var dog = await _vetServices.GetDog(id);
            return View(dog);
        }

        public IActionResult AddDog() => View();

        [HttpPost]
        public async Task<IActionResult> AddDog(Dog dog)
        {
            await _vetServices.CreateDog(dog);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> EditDog(int id)
        {
            var dog = await _vetServices.GetDog(id);
            return View(dog);
        }

        [HttpPost]
        public async Task<IActionResult> EditDog(int id, Dog dog)
        {
            await _vetServices.UpdateDog(id, dog);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> RemoveDog(int id)
        {
            var dog = await _vetServices.GetDog(id);
            return View(dog);
        }

        [HttpPost, ActionName("RemoveDog")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _vetServices.DeleteDog(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
