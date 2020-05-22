using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreBook.Models;

namespace StoreBook.Controllers
{
    public class CatalogController : Controller
    {
        private readonly StoreBookContext _context;

        public CatalogController(StoreBookContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            return View(await _context.Book
                                .Include(c => c.Author)
                                .ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> ShowItem(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(c => c.Author)
                .Include(d => d.Genre)
                .Include(e => e.Publish)
                .Include(f => f.Series)
                .Include(g => g.Editor)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        /*        public IActionResult Index()
                {
                    return View();
                }*/
    }
}