using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Carsafa.Models;

namespace Carsafa.Controllers
{
    public class OwnersController : Controller
    {
        private readonly DB_128040_bart0146Context _context;

        public OwnersController(DB_128040_bart0146Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
              return _context.Owners != null ? 
                          View(await _context.Owners.ToListAsync()) :
                          Problem("Entity set 'DB_128040_bart0146Context.Owners'  is null.");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Owners == null)
            {
                return NotFound();
            }

            var owner = await _context.Owners
                .Include(o => o.Purchases)
                .ThenInclude(p => p.Car)
                .ThenInclude(c => c.Make)
                .FirstOrDefaultAsync(m => m.OwnerId == id);

            if (owner == null)
            {
                return NotFound();
            }

            return View(owner);
        }
    }
}
