using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Project.Data;
using Final_Project.Models;

namespace Final_Project.Controllers
{
    public class OrdenesController : Controller
    {
        private readonly OrdenesDbContext _context;

        public OrdenesController(OrdenesDbContext context)
        {
            _context = context;
        }

        // GET: Ordenes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orden.ToListAsync());
        }

        public async Task<IActionResult> Compras(string Buscar)
        {
            var movies = from m in _context.Orden select m;

            if (!String.IsNullOrEmpty(Buscar))
            {
                movies = movies.Where(s => s.Estado.Contains(Buscar));
            }

            return View(await movies.ToListAsync());
        }
      

        // GET: Ordenes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProductos = await _context.Orden
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataProductos == null)
            {
                return NotFound();
            }

            return View(dataProductos);
        }

        // GET: Ordenes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ordenes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Foto,Nombre,Descripcion,Cantidad,Estado,Categoria,Precio,NombreOrden,NombreCliente,ApellidoCliente,Direccion,Correo,Telefono,Latitud,Longitud")] DataProductos dataProductos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dataProductos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dataProductos);
        }

        // GET: Ordenes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProductos = await _context.Orden.FindAsync(id);
            if (dataProductos == null)
            {
                return NotFound();
            }
            return View(dataProductos);
        }

        // POST: Ordenes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Foto,Nombre,Descripcion,Cantidad,Estado,Categoria,Precio,NombreOrden,NombreCliente,ApellidoCliente,Direccion,Correo,Telefono,Latitud,Longitud")] DataProductos dataProductos)
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

        // GET: Ordenes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProductos = await _context.Orden
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataProductos == null)
            {
                return NotFound();
            }

            return View(dataProductos);
        }

        // POST: Ordenes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dataProductos = await _context.Orden.FindAsync(id);
            _context.Orden.Remove(dataProductos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DataProductosExists(int id)
        {
            return _context.Orden.Any(e => e.Id == id);
        }
    }
}
