using eTicket.Models.Data;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDBContext _appDBContext;

        public ActorsController(AppDBContext context)
        {
            _appDBContext = context;
        }
        public IActionResult Index()
        {
            var data = _appDBContext.Actors.ToList();
            return View(data);
        }
    }
}
