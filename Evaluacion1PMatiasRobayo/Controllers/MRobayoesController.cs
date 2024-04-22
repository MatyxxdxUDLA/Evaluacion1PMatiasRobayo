using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Evaluacion1PMatiasRobayo.Data;
using Evaluacion1PMatiasRobayo.Models;

namespace Evaluacion1PMatiasRobayo.Controllers
{
    public class MRobayoesController : Controller
    {
        private readonly Evaluacion1PMatiasRobayoContext _context;

        public MRobayoesController(Evaluacion1PMatiasRobayoContext context)
        {
            _context = context;
        }

        // GET: MRobayoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.MRobayo.ToListAsync());
        }

        // GET: MRobayoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mRobayo = await _context.MRobayo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mRobayo == null)
            {
                return NotFound();
            }

            return View(mRobayo);
        }

        // GET: MRobayoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MRobayoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,Apellido,Promedio,Estudia,FechaNacimiento")] MRobayo mRobayo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mRobayo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mRobayo);
        }

        // GET: MRobayoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mRobayo = await _context.MRobayo.FindAsync(id);
            if (mRobayo == null)
            {
                return NotFound();
            }
            return View(mRobayo);
        }

        // POST: MRobayoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Apellido,Promedio,Estudia,FechaNacimiento")] MRobayo mRobayo)
        {
            if (id != mRobayo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mRobayo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MRobayoExists(mRobayo.Id))
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
            return View(mRobayo);
        }

        // GET: MRobayoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mRobayo = await _context.MRobayo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mRobayo == null)
            {
                return NotFound();
            }

            return View(mRobayo);
        }

        // POST: MRobayoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mRobayo = await _context.MRobayo.FindAsync(id);
            if (mRobayo != null)
            {
                _context.MRobayo.Remove(mRobayo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MRobayoExists(int id)
        {
            return _context.MRobayo.Any(e => e.Id == id);
        }
    }
}
