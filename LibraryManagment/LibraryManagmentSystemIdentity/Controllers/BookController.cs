using LibraryManagmentSystemIdentity.Data;
using LibraryManagmentSystemIdentity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagmentSystemIdentity.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Books.Include(b => b.Author).ToListAsync());
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Authors = await _context.Authors.ToListAsync();
            var book = new BooksModel();
            return View(book);
        }
        [HttpPost]
        public async Task<IActionResult>Create(BooksModel book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Authors = await _context.Authors.ToListAsync();
            return View(book);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Authors = await _context.Authors.ToListAsync();
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return View("Error");
            }
            return View(book);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, BooksModel book)
        {
            ViewBag.Authors = await _context.Authors.ToArrayAsync();
            var existingBook = await _context.Books.FindAsync(id);
            if (existingBook == null)
            {
                return View("Error");
            }
            existingBook.BookName = book.BookName;
            existingBook.Description = book.Description;
            existingBook.AuthorId = book.AuthorId;

            _context.Books.Update(existingBook);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index"); 
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await _context.Books.FindAsync(id);
            if (delete == null)
            {
                return View("Error");
            }
            _context.Books.Remove(delete);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Book Deleted Successfully";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> SearchAuthors(string searchTerm)
        {
            var authors = await _context.Authors
                .Where(a => a.AuthorName.Contains(searchTerm))
                .Select(a => new { a.AuthorId, a.AuthorName })
                .Take(10)
                .ToListAsync();

            return Json(authors);
        }

    }
}
