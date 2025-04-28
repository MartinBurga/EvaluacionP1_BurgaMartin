using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EvaluacionP1_BurgaMartin.Data;
using EvaluacionP1_BurgaMartin.Models;

namespace EvaluacionP1_BurgaMartin.Controllers
{
    public class PlanRecompensasController : Controller
    {
        private readonly EvaluacionP1_SQL_PlanRecompensas _context;

        public PlanRecompensasController(EvaluacionP1_SQL_PlanRecompensas context)
        {
            _context = context;
        }

        // GET: PlanRecompensas
        public async Task<IActionResult> Index()
        {
            var evaluacionP1_SQL_PlanRecompensas = _context.PlanRecompensas.Include(p => p.cliente);
            return View(await evaluacionP1_SQL_PlanRecompensas.ToListAsync());
        }

        // GET: PlanRecompensas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planRecompensas = await _context.PlanRecompensas
                .Include(p => p.cliente)
                .FirstOrDefaultAsync(m => m.IdPlan == id);
            if (planRecompensas == null)
            {
                return NotFound();
            }

            return View(planRecompensas);
        }

        // GET: PlanRecompensas/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Set<Cliente>(), "Id", "Id");
            return View();
        }

        // POST: PlanRecompensas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPlan,Nombre,fechaInicio,pntos,IdCliente")] PlanRecompensas planRecompensas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planRecompensas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Set<Cliente>(), "Id", "Id", planRecompensas.IdCliente);
            return View(planRecompensas);
        }

        // GET: PlanRecompensas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planRecompensas = await _context.PlanRecompensas.FindAsync(id);
            if (planRecompensas == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Set<Cliente>(), "Id", "Id", planRecompensas.IdCliente);
            return View(planRecompensas);
        }

        // POST: PlanRecompensas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPlan,Nombre,fechaInicio,pntos,IdCliente")] PlanRecompensas planRecompensas)
        {
            if (id != planRecompensas.IdPlan)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planRecompensas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanRecompensasExists(planRecompensas.IdPlan))
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
            ViewData["IdCliente"] = new SelectList(_context.Set<Cliente>(), "Id", "Id", planRecompensas.IdCliente);
            return View(planRecompensas);
        }

        // GET: PlanRecompensas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planRecompensas = await _context.PlanRecompensas
                .Include(p => p.cliente)
                .FirstOrDefaultAsync(m => m.IdPlan == id);
            if (planRecompensas == null)
            {
                return NotFound();
            }

            return View(planRecompensas);
        }

        // POST: PlanRecompensas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planRecompensas = await _context.PlanRecompensas.FindAsync(id);
            if (planRecompensas != null)
            {
                _context.PlanRecompensas.Remove(planRecompensas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanRecompensasExists(int id)
        {
            return _context.PlanRecompensas.Any(e => e.IdPlan == id);
        }
    }
}
