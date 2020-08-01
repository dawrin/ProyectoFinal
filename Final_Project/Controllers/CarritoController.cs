using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;

namespace Final_Project.Controllers
{
    public class CarritoController : Controller
    {
        private readonly CarritoDbContex _context;

        public CarritoController(CarritoDbContex context)
        {
            _context = context;
        }

        // GET: Carrito
        public async Task<IActionResult> Index()
        {
            return View(await _context.DATA.ToListAsync());
        }

        // GET: Carrito/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProductos = await _context.DATA
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataProductos == null)
            {
                return NotFound();
            }

            return View(dataProductos);
        }

        // GET: Carrito/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carrito/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Foto,Nombre,Descripcion,Cantidad,Estado,Categoria")] DataProductos dataProductos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dataProductos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dataProductos);
        }

        // GET: Carrito/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProductos = await _context.DATA.FindAsync(id);
            if (dataProductos == null)
            {
                return NotFound();
            }
            return View(dataProductos);
        }

        // POST: Carrito/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Foto,Nombre,Descripcion,Cantidad,Estado,Categoria")] DataProductos dataProductos)
        {
            if (id != dataProductos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dataProductos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataProductosExists(dataProductos.Id))
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
            return View(dataProductos);
        }

        // GET: Carrito/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProductos = await _context.DATA
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataProductos == null)
            {
                return NotFound();
            }

            return View(dataProductos);
        }

        // POST: Carrito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dataProductos = await _context.DATA.FindAsync(id);
            _context.DATA.Remove(dataProductos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DataProductosExists(int id)
        {
            return _context.DATA.Any(e => e.Id == id);
        }
    }
}
