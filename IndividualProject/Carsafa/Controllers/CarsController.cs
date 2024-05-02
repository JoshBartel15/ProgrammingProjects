using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Carsafa.Models;
using Microsoft.EntityFrameworkCore.Query;

namespace Carsafa.Controllers
{
    public class CarsController : Controller
    {
        private readonly DB_128040_bart0146Context _context;

        public CarsController(DB_128040_bart0146Context context)
        {
            _context = context;
            
        }

        public async Task<IActionResult> Index(string id = "", string make = "All", string color = "All", string type = "All", int year = 2022)
        {
            //var dB_128040_bart0146Context = _context.Cars.Include(c => c.Make);
            //return View(await dB_128040_bart0146Context.ToListAsync());

            if (_context.Cars == null)
            {
                return Problem("The database you're trying to use is null");
            }

            IQueryable<Car> query = _context.Cars.Include(c => c.Make);
                
            if(make != "All")
            {
                query = query.Where(c => c.Make.Make1 == make);
            }
            if(color != "All")
            {
                query = query.Where(c => c.Color == color);
            }
            if(type != "All")
            {
                query = query.Where(c => c.Type == type);
            }
            if(year != 2022)
            {
                query = query.Where(c => c.Year == year);
            }
            List<Car> cars = await query.ToListAsync();

            return View(cars);
        }


        public async Task<IActionResult> Makes()
        {
            List<string> makes = new List<string>();

            foreach (Car car in _context.Cars)
            {
                if (!makes.Contains(car.Make.Make1))
                {
                    makes.Add(car.Make.Make1);
                }
            }

            makes = _context.Cars.Select(car => car.Make.Make1).Distinct().ToList();

            return View(makes);
        }   

        public async Task<IActionResult> Colors()
        {
            List<string> colors = new List<string>();

            foreach (Car car in _context.Cars)
            {
                if (!colors.Contains(car.Color))
                {
                    colors.Add(car.Color);
                }
            }

            colors = _context.Cars.Select(car => car.Color).Distinct().ToList();

            return View(colors);
        }

        public async Task<IActionResult> Types()
        {
            List<string> types = new List<string>();

            foreach (Car car in _context.Cars)
            {
                if (!types.Contains(car.Type))
                {
                    types.Add(car.Type);
                }
            }

            types = _context.Cars.Select(car => car.Type).Distinct().ToList();

            return View(types);
        }

        public async Task<IActionResult> Years()
        {
            List<int> years = new List<int>();

            foreach (Car car in _context.Cars)
            {
                if (!years.Contains(car.Year))
                {
                    years.Add(car.Year);
                }
            }

            years = _context.Cars.Select(car => car.Year).Distinct().ToList();

            return View(years);
        }



        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cars == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .Include(c => c.Make)
                .FirstOrDefaultAsync(m => m.CarId == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        private bool CarExists(int id)
        {
          return (_context.Cars?.Any(e => e.CarId == id)).GetValueOrDefault();
        }
        public List<Make> GetDistinctMakes()
        {
            return _context.Cars.Select(car => car.Make).Distinct().ToList();
        }

    }
}

