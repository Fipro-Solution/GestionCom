using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ManagementProjet.Data;
using ManagementProjet.Models;

namespace ManagementProjet.Controllers
{
    public class OrdreMissionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdreMissionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OrdreMissions
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.OrdreMission.Include(o => o.Vehicule);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: OrdreMissions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordreMission = await _context.OrdreMission
                .Include(o => o.Vehicule)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (ordreMission == null)
            {
                return NotFound();
            }

            return View(ordreMission);
        }

        // GET: OrdreMissions/Details/5
        public async Task<IActionResult> DetailsPrint(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordreMission = await _context.OrdreMission
                .Include(o => o.Vehicule)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (ordreMission == null)
            {
                return NotFound();
            }

            return View(ordreMission);
        }

        // GET: OrdreMissions/Create
        public IActionResult Create()
        {
            ViewData["VehiculeId"] = new SelectList(_context.Vehicule, "Id", "Libelle");
            ViewData["VehiculeIdV2"] = new SelectList(_context.Vehicule, "Id", "immatricule");
            return View();
        }

        // POST: OrdreMissions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,DateMission,VehiculeId,matricule,Conducteur,NumPermis,CIN,Destinations,CompteurInit,CompteurFinal,DateDepart,DateRetour,LibelleMission1,LibelleMission2,LibelleMission3,DetailsMission,FraisMission1,FraisMission2,FraisMission3,Total")] OrdreMission ordreMission)
        {
            if (ModelState.IsValid)
            {
                ordreMission.Total = ordreMission.FraisMission1 + ordreMission.FraisMission2 + ordreMission.FraisMission3;
                _context.Add(ordreMission);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VehiculeId"] = new SelectList(_context.Vehicule, "Id", "Libelle", ordreMission.VehiculeId);
            ViewData["VehiculeIdV2"] = new SelectList(_context.Vehicule, "Id", "immatricule", ordreMission.VehiculeId);

            return View(ordreMission);
        }

        // GET: OrdreMissions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordreMission = await _context.OrdreMission.SingleOrDefaultAsync(m => m.Id == id);
            if (ordreMission == null)
            {
                return NotFound();
            }
            ViewData["VehiculeId"] = new SelectList(_context.Vehicule, "Id", "Libelle", ordreMission.VehiculeId);
            ViewData["VehiculeIdV2"] = new SelectList(_context.Vehicule, "Id", "immatricule", ordreMission.VehiculeId);

            return View(ordreMission);
        }

        // POST: OrdreMissions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Code,DateMission,VehiculeId,matricule,Conducteur,NumPermis,CIN,Destinations,CompteurInit,CompteurFinal,DateDepart,DateRetour,LibelleMission1,LibelleMission2,LibelleMission3,DetailsMission,FraisMission1,FraisMission2,FraisMission3,Total")] OrdreMission ordreMission)
        {
            if (id != ordreMission.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    ordreMission.Total = ordreMission.FraisMission1 + ordreMission.FraisMission2 + ordreMission.FraisMission3;
                    _context.Update(ordreMission);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdreMissionExists(ordreMission.Id))
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
            ViewData["VehiculeId"] = new SelectList(_context.Vehicule, "Id", "Libelle", ordreMission.VehiculeId);
            ViewData["VehiculeIdV2"] = new SelectList(_context.Vehicule, "Id", "immatricule", ordreMission.VehiculeId);

            return View(ordreMission);
        }

        // GET: OrdreMissions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordreMission = await _context.OrdreMission
                .Include(o => o.Vehicule)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (ordreMission == null)
            {
                return NotFound();
            }

            return View(ordreMission);
        }

        // POST: OrdreMissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordreMission = await _context.OrdreMission.SingleOrDefaultAsync(m => m.Id == id);
            _context.OrdreMission.Remove(ordreMission);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdreMissionExists(int id)
        {
            return _context.OrdreMission.Any(e => e.Id == id);
        }
        public IActionResult GetLMatById(int matId)
        {

            var data = from c in _context.Vehicule
                       where c.Id == matId
                       select c;
            return View(data);
        }
    }
}
