using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YouthActionM3.Data;
using YouthActionM3.Models;

namespace YouthActionM3.Controllers
{
    public class ServiceCentresController : Controller
    {
        private readonly YouthActionM3Context _context;

        public ServiceCentresController(YouthActionM3Context context)
        {
            _context = context;
        }

        // GET: ServiceCentres
        public async Task<IActionResult> Index()
        {
              return _context.ServiceCentre != null ? 
                          View(await _context.ServiceCentre.ToListAsync()) :
                          Problem("Entity set 'YouthActionM3Context.ServiceCentre'  is null.");
        }

        // GET: ServiceCentres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ServiceCentre == null)
            {
                return NotFound();
            }

            var serviceCentre = await _context.ServiceCentre
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceCentre == null)
            {
                return NotFound();
            }

            return View(serviceCentre);
        }

        // GET: ServiceCentres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServiceCentres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,ContactNumber,Manager,NoOfProjects,NoOfEmployees")] ServiceCentre serviceCentre)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceCentre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(serviceCentre);
        }

        // GET: ServiceCentres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ServiceCentre == null)
            {
                return NotFound();
            }

            var serviceCentre = await _context.ServiceCentre.FindAsync(id);
            if (serviceCentre == null)
            {
                return NotFound();
            }
            return View(serviceCentre);
        }

        // POST: ServiceCentres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address,ContactNumber,Manager,NoOfProjects,NoOfEmployees")] ServiceCentre serviceCentre)
        {
            if (id != serviceCentre.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceCentre);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceCentreExists(serviceCentre.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(serviceCentre);
        }

        // GET: ServiceCentres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ServiceCentre == null)
            {
                return NotFound();
            }

            var serviceCentre = await _context.ServiceCentre
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceCentre == null)
            {
                return NotFound();
            }

            return View(serviceCentre);
        }

        // POST: ServiceCentres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ServiceCentre == null)
            {
                return Problem("Entity set 'YouthActionM3Context.ServiceCentre'  is null.");
            }
            var serviceCentre = await _context.ServiceCentre.FindAsync(id);
            if (serviceCentre != null)
            {
                _context.ServiceCentre.Remove(serviceCentre);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceCentreExists(int id)
        {
          return (_context.ServiceCentre?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
