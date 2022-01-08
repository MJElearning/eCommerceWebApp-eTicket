using eTicket.Models;
using eTicket.Models.Data;
using eTicket.Models.Data.Services;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _actorsService;

        public ActorsController(IActorsService service)
        {
            _actorsService = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _actorsService.GetAll();
            return View(data);
        }

        //Get Actors Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ActorName,ProfileURL,ActorBio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _actorsService.AddActor(actor);
            return RedirectToAction("Index");
        }
    }
}
