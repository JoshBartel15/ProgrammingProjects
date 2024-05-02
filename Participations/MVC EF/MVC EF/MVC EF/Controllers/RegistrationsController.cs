using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_EF.Models;

namespace MVC_EF.Controllers
{
    public class RegistrationsController : Controller
    {
        private readonly DB_128040_practiceContext _context;

        public RegistrationsController(DB_128040_practiceContext context)
        {
            _context = context;
        }

        // GET: Registrations
        public async Task<IActionResult> Index()
        {
            var dB_128040_practiceContext = _context.Registrations.Include(r => r.Course).Include(r => r.Student);
            return View(await dB_128040_practiceContext.ToListAsync());
        }

        // GET: Registrations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Registrations == null)
            {
                return NotFound();
            }

            var registration = await _context.Registrations
                .Include(r => r.Course)
                .Include(r => r.Student)
                .FirstOrDefaultAsync(m => m.RegistrationId == id);
            if (registration == null)
            {
                return NotFound();
            }

            return View(registration);
        }
    }
}
