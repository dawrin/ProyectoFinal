using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Project.Data;
using Final_Project.Models;
using System.IO;

namespace Final_Project.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Productos.ToListAsync());
        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProductos = await _context.Productos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataProductos == null)
            {
                return NotFound();
            }

            return View(dataProductos);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Foto,Nombre,Descripcion,Cantidad,Estado,Categoria")] DataProductos datos)
        {
            foreach (var file in Request.Form.Files)
            {
                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms);
                datos.Foto = ms.ToArray();
                ms.Close();
                ms.Dispose();

                _context.Add(datos);

                await _context.SaveChangesAsync();

            }
            return RedirectToAction("Index", "Productos");
        }

        public async Task<ActionResult> RenderImage(int id)
        {
            DataProductos item = await _context.Productos.FindAsync(id);

            byte[] photoBack = item.Foto;

            return File(photoBack, "image/png");
        }
        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProductos = await _context.Productos.FindAsync(id);
            if (dataProductos == null)
            {
                return NotFound();
            }
            return View(dataProductos);
        }

        // POST: Productos/Edit/5
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

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProductos = await _context.Productos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataProductos == null)
            {
                return NotFound();
            }

            return View(dataProductos);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dataProductos = await _context.Productos.FindAsync(id);
            _context.Productos.Remove(dataProductos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DataProductosExists(int id)
        {
            return _context.Productos.Any(e => e.Id == id);
        }
    }
}
