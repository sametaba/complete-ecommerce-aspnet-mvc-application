using eTicketsQ.Data;
using eTicketsQ.Data.Services;
using eTicketsQ.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTicketsQ.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //get : Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePicture,Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));

        }

        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("Not Found");
            return View(actorDetails);
        }

        //Get : Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Not Found");
            return View(actorDetails);
        }

        /*[HttpGet]
        public async Task<IActionResult> EditGet(int id)
        {
            if (id == 0) return NotFound();

            var actor = await _service.GetByIdAsync(id);
            if (actor == null) return NotFound();

            return View(actor);
        }*/

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePicture,Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        //Get : Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Not Found");
            return View(actorDetails);
        }

        

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Not Found");

            await _service.DeleteAsync(id);

            
            return RedirectToAction(nameof(Index));
        }

    }
}