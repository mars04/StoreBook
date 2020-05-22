using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StoreBook.Models;

namespace StoreBook.Controllers
{
    public class PublishesController : Controller
    {
        private readonly StoreBookContext _context;

        public PublishesController(StoreBookContext context)
        {
            _context = context;
        }

        // GET: Publishes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Publish.ToListAsync());
        }

        // GET: Publishes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publish = await _context.Publish
                .FirstOrDefaultAsync(m => m.ID == id);
            if (publish == null)
            {
                return NotFound();
            }

            return View(publish);
        }

        // GET: Publishes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Publishes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] Publish publish)
        {
            if (ModelState.IsValid)
            {
                _context.Add(publish);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(publish);
        }

        // GET: Publishes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publish = await _context.Publish.FindAsync(id);
            if (publish == null)
            {
                return NotFound();
            }
            return View(publish);
        }

        // POST: Publishes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] Publish publish)
        {
            if (id != publish.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(publish);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PublishExists(publish.ID))
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
            return View(publish);
        }

        // GET: Publishes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publish = await _context.Publish
                .FirstOrDefaultAsync(m => m.ID == id);
            if (publish == null)
            {
                return NotFound();
            }

            return View(publish);
        }

        // POST: Publishes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publish = await _context.Publish.FindAsync(id);
            _context.Publish.Remove(publish);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PublishExists(int id)
        {
            return _context.Publish.Any(e => e.ID == id);
        }
    }
}
