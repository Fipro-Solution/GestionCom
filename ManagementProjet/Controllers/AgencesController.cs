﻿using System;
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
    public class AgencesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AgencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Agences
        public async Task<IActionResult> Index()
        {
            return View(await _context.Agence.ToListAsync());
        }

        // GET: Agences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agence = await _context.Agence
                .SingleOrDefaultAsync(m => m.Id == id);
            if (agence == null)
            {
                return NotFound();
            }

            return View(agence);
        }

        // GET: Agences/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Agences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,code,libelle,proprietaire,capital,MatFiscale,Address,Tel,Fax,Telecopie,email,AdrsUrl,Contact,TelContact,GsmContact,MatCNSS,Smigar,Cnss,CnssEmployeur,Fiprolos,AccidentTravail,Tfp")] Agence agence)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agence);
        }

        // GET: Agences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agence = await _context.Agence.SingleOrDefaultAsync(m => m.Id == id);
            if (agence == null)
            {
                return NotFound();
            }
            return View(agence);
        }

        // POST: Agences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,code,libelle,proprietaire,capital,MatFiscale,Address,Tel,Fax,Telecopie,email,AdrsUrl,Contact,TelContact,GsmContact,MatCNSS,Smigar,Cnss,CnssEmployeur,Fiprolos,AccidentTravail,Tfp")] Agence agence)
        {
            if (id != agence.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgenceExists(agence.Id))
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
            return View(agence);
        }

        // GET: Agences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agence = await _context.Agence
                .SingleOrDefaultAsync(m => m.Id == id);
            if (agence == null)
            {
                return NotFound();
            }

            return View(agence);
        }

        // POST: Agences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agence = await _context.Agence.SingleOrDefaultAsync(m => m.Id == id);
            _context.Agence.Remove(agence);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgenceExists(int id)
        {
            return _context.Agence.Any(e => e.Id == id);
        }
    }
}
