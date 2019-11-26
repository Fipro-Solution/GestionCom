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
    public class VehiculesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VehiculesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Vehicules
        public async Task<IActionResult> Index()
        {
            ViewBag.TotalVehicule = _context.Vehicule.Count();
            return View(await _context.Vehicule.ToListAsync());
        }

        // GET: Vehicules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicule = await _context.Vehicule
                .SingleOrDefaultAsync(m => m.Id == id);
            if (vehicule == null)
            {
                return NotFound();
            }

            return View(vehicule);
        }

        // GET: Vehicules/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vehicules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,Libelle,Actif,immatricule,Etat,Fourn,Modele,Marque,Categorie,Couleur,DatePMC,MantAcqui,DateAcqui,DateFinG,Nchassis,NMoteur,IndKilimetre,Cylindree,PoidsVide,PoidsUtile,Energie,puissance,Debout,Assise,theorique,Pratique,AVG,AVD,ARG,ARD,Secour,Restant,Amortis,Accessoire,Taxe,climatise,FermetureCentrale,Alarme,Saloncuir,DemarrageCode,Demarrageadistance,Abs,Radio,RadioCD,JanteAllu,Airbag,Commandeadistance,DirectionAssiste,SiegePilote,Observation,Vendue")] Vehicule vehicule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicule);
        }

        // GET: Vehicules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicule = await _context.Vehicule.SingleOrDefaultAsync(m => m.Id == id);
            if (vehicule == null)
            {
                return NotFound();
            }
            return View(vehicule);
        }

        // POST: Vehicules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Code,Libelle,Actif,immatricule,Etat,Fourn,Modele,Marque,Categorie,Couleur,DatePMC,MantAcqui,DateAcqui,DateFinG,Nchassis,NMoteur,IndKilimetre,Cylindree,PoidsVide,PoidsUtile,Energie,puissance,Debout,Assise,theorique,Pratique,AVG,AVD,ARG,ARD,Secour,Restant,Amortis,Accessoire,Taxe,climatise,FermetureCentrale,Alarme,Saloncuir,DemarrageCode,Demarrageadistance,Abs,Radio,RadioCD,JanteAllu,Airbag,Commandeadistance,DirectionAssiste,SiegePilote,Observation,Vendue")] Vehicule vehicule)
        {
            if (id != vehicule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehiculeExists(vehicule.Id))
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
            return View(vehicule);
        }

        // GET: Vehicules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicule = await _context.Vehicule
                .SingleOrDefaultAsync(m => m.Id == id);
            if (vehicule == null)
            {
                return NotFound();
            }

            return View(vehicule);
        }

        // POST: Vehicules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicule = await _context.Vehicule.SingleOrDefaultAsync(m => m.Id == id);
            _context.Vehicule.Remove(vehicule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehiculeExists(int id)
        {
            return _context.Vehicule.Any(e => e.Id == id);
        }
    }
}
