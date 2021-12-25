using eTicket.Models.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDBContext _appDBContext;

        public MoviesController(AppDBContext context)
        {
            _appDBContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _appDBContext.Movies.ToListAsync();
            return View(result);
        }
    }
}
