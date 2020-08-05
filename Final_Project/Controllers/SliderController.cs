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
    public class SliderController : Controller
    {
        private readonly SliderDbContext _context;

        public SliderController(SliderDbContext context)
        {
            _context = context;
        }

        // GET: Slider
        public async Task<IActionResult> Index()
        {
            return View(await _context.Slider.ToListAsync());
        }
        public async Task<IActionResult> Inicio()
        {
            return View(await _context.Slider.ToListAsync());
        }


        // GET: Slider/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProductos = await _context.Slider
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataProductos == null)
            {
                return NotFound();
            }

            return View(dataProductos);
        }

        // GET: Slider/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Slider/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Foto,FotoSlider,Nombre,Descripcion,Cantidad,Estado,Categoria,Precio,NombreOrden,NombreCliente,ApellidoCliente,Direccion,Correo,FechaCliente,Telefono,Latitud,Longitud")] DataProductos datos)
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
            return RedirectToAction("Index", "Slider");
        }

        public async Task<ActionResult> RenderImage(int id)
        {
            DataProductos item = await _context.Slider.FindAsync(id);

            byte[] photoBack = item.Foto;

            return File(photoBack, "image/png");
        }

        // GET: Slider/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProductos = await _context.Slider.FindAsync(id);
            if (dataProductos == null)
            {
                return NotFound();
            }
            return View(dataProductos);
        }

        // POST: Slider/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Foto,FotoSlider,Nombre,Descripcion,Cantidad,Estado,Categoria,Precio,NombreOrden,NombreCliente,ApellidoCliente,Direccion,Correo,FechaCliente,Telefono,Latitud,Longitud")] DataProductos dataProductos)
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

        // GET: Slider/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataProductos = await _context.Slider
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataProductos == null)
            {
                return NotFound();
            }

            return View(dataProductos);
        }

        // POST: Slider/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dataProductos = await _context.Slider.FindAsync(id);
            _context.Slider.Remove(dataProductos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DataProductosExists(int id)
        {
            return _context.Slider.Any(e => e.Id == id);
        }
    }
}
