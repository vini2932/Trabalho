using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgenciaViagemTrabalho.Models;

namespace AgenciaViagemTrabalho.Controllers
{
    public class PassagemClienteVendasController : Controller
    {
        private readonly ViagemContext _context;

        public PassagemClienteVendasController(ViagemContext context)
        {
            _context = context;
        }

        // GET: PassagemClienteVendas
        public async Task<IActionResult> Index()
        {
            var viagemContext = _context.PassagemClienteVenda.Include(p => p.IdClienteNavigation).Include(p => p.IdPassagemNavigation);
            return View(await viagemContext.ToListAsync());
        }

        // GET: PassagemClienteVendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passagemClienteVenda = await _context.PassagemClienteVenda
                .Include(p => p.IdClienteNavigation)
                .Include(p => p.IdPassagemNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passagemClienteVenda == null)
            {
                return NotFound();
            }

            return View(passagemClienteVenda);
        }

        // GET: PassagemClienteVendas/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Cpf");
            ViewData["IdPassagem"] = new SelectList(_context.Passagem, "Id", "Destino");
            return View();
        }

        // POST: PassagemClienteVendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCliente,IdPassagem,Preco,DataCompra")] PassagemClienteVenda passagemClienteVenda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(passagemClienteVenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Cpf", passagemClienteVenda.IdCliente);
            ViewData["IdPassagem"] = new SelectList(_context.Passagem, "Id", "Destino", passagemClienteVenda.IdPassagem);
            return View(passagemClienteVenda);
        }

        // GET: PassagemClienteVendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passagemClienteVenda = await _context.PassagemClienteVenda.FindAsync(id);
            if (passagemClienteVenda == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Cpf", passagemClienteVenda.IdCliente);
            ViewData["IdPassagem"] = new SelectList(_context.Passagem, "Id", "Destino", passagemClienteVenda.IdPassagem);
            return View(passagemClienteVenda);
        }

        // POST: PassagemClienteVendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCliente,IdPassagem,Preco,DataCompra")] PassagemClienteVenda passagemClienteVenda)
        {
            if (id != passagemClienteVenda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(passagemClienteVenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PassagemClienteVendaExists(passagemClienteVenda.Id))
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
            ViewData["IdCliente"] = new SelectList(_context.Cliente, "Id", "Cpf", passagemClienteVenda.IdCliente);
            ViewData["IdPassagem"] = new SelectList(_context.Passagem, "Id", "Destino", passagemClienteVenda.IdPassagem);
            return View(passagemClienteVenda);
        }

        // GET: PassagemClienteVendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passagemClienteVenda = await _context.PassagemClienteVenda
                .Include(p => p.IdClienteNavigation)
                .Include(p => p.IdPassagemNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passagemClienteVenda == null)
            {
                return NotFound();
            }

            return View(passagemClienteVenda);
        }

        // POST: PassagemClienteVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var passagemClienteVenda = await _context.PassagemClienteVenda.FindAsync(id);
            _context.PassagemClienteVenda.Remove(passagemClienteVenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PassagemClienteVendaExists(int id)
        {
            return _context.PassagemClienteVenda.Any(e => e.Id == id);
        }
    }
}
