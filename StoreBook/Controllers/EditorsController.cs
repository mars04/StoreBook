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
    public class EditorsController : Controller
    {
        private readonly StoreBookContext _context;

        public EditorsController(StoreBookContext context)
        {
            _context = context;
        }

        // GET: Editors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Editor.ToListAsync());
        }

        // GET: Editors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editor = await _context.Editor
                .FirstOrDefaultAsync(m => m.ID == id);
            if (editor == null)
            {
                return NotFound();
            }

            return View(editor);
        }

        // GET: Editors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Editors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] Editor editor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(editor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(editor);
        }

        // GET: Editors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editor = await _context.Editor.FindAsync(id);
            if (editor == null)
            {
                return NotFound();
            }
            return View(editor);
        }

        // POST: Editors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] Editor editor)
        {
            if (id != editor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(editor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EditorExists(editor.ID))
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
            return View(editor);
        }

        // GET: Editors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editor = await _context.Editor
                .FirstOrDefaultAsync(m => m.ID == id);
            if (editor == null)
            {
                return NotFound();
            }

            return View(editor);
        }

        // POST: Editors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var editor = await _context.Editor.FindAsync(id);
            _context.Editor.Remove(editor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EditorExists(int id)
        {
            return _context.Editor.Any(e => e.ID == id);
        }
    }
}
