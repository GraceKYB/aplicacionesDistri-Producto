using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Login.Data;
using Login.Models;


namespace Login.Controllers
{
    [Authorize]
    public class ProductoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Productos.Include(p => p.Categoria).Include(p => p.Subcategoria);
            return View(await applicationDbContext.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewData["CatId"] = new SelectList(_context.Categorias, "CatId", "CatNombre");
            ViewData["SubcId"] = new SelectList(_context.Subcategorias, "SubcId", "SubcNombre");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProId,ProNombre,ProDescripcion,ProPrecio,ProStock,CatId,SubcId")] Producto producto, IFormFile ProImagen)
        {
            if (ModelState.IsValid)
            {
                if (ProImagen != null && ProImagen.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await ProImagen.CopyToAsync(memoryStream);
                        producto.ProImagen = memoryStream.ToArray();
                    }
                }
                else
                {
                    ModelState.AddModelError("ProImagen", "Debe seleccionar una imagen.");
                    ViewData["CatId"] = new SelectList(_context.Categorias, "CatId", "CatNombre", producto.CatId);
                    ViewData["SubcId"] = new SelectList(_context.Subcategorias, "SubcId", "SubcNombre", producto.SubcId);
                    return View(producto);
                }

                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CatId"] = new SelectList(_context.Categorias, "CatId", "CatNombre", producto.CatId);
            ViewData["SubcId"] = new SelectList(_context.Subcategorias, "SubcId", "SubcNombre", producto.SubcId);
            return View(producto);
        }

        // GET: Productoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["CatId"] = new SelectList(_context.Categorias, "CatId", "CatNombre", producto.CatId);
            ViewData["SubcId"] = new SelectList(_context.Subcategorias, "SubcId", "SubcNombre", producto.SubcId);
            return View(producto);
        }

        // POST: Productoes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProId,ProNombre,ProDescripcion,ProPrecio,ProStock,CatId,SubcId")] Producto producto, IFormFile ProImagen)
        {
            if (id != producto.ProId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (ProImagen != null && ProImagen.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await ProImagen.CopyToAsync(memoryStream);
                            producto.ProImagen = memoryStream.ToArray();
                        }
                    }
                    else
                    {
                        var existingProducto = await _context.Productos.AsNoTracking().FirstOrDefaultAsync(p => p.ProId == id);
                        if (existingProducto != null)
                        {
                            producto.ProImagen = existingProducto.ProImagen;
                        }
                    }

                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.ProId))
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
            ViewData["CatId"] = new SelectList(_context.Categorias, "CatId", "CatNombre", producto.CatId);
            ViewData["SubcId"] = new SelectList(_context.Subcategorias, "SubcId", "SubcNombre", producto.SubcId);
            return View(producto);
        }

        // GET: Productoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.Categoria)
                .Include(p => p.Subcategoria)
                .FirstOrDefaultAsync(m => m.ProId == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Productos.Any(e => e.ProId == id);
        }
    }
}
