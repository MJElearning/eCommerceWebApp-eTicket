using eTicket.Models.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    public class ScreensController : Controller
    {
        private readonly AppDBContext _appDBContext;

        public ScreensController(AppDBContext context)
        {
            _appDBContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _appDBContext.Screens.ToListAsync();
            return View(result);
        }
    }
}
