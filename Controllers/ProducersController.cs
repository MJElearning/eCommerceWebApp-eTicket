using eTicket.Models.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDBContext _appDBContext;

        public ProducersController(AppDBContext context)
        {
            _appDBContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _appDBContext.Producers.ToListAsync();
            return View();
        }
    }
}
