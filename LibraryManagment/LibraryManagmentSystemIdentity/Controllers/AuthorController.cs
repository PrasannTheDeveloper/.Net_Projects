using Azure.Core;
using LibraryManagmentSystemIdentity.Data;
using LibraryManagmentSystemIdentity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagmentSystemIdentity.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthorController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Authors.ToListAsync());
        }  
        
        public async Task<IActionResult> Create()
        {
            var author = new AuthorsModel();
            return View(author);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AuthorsModel author)
        {
            if(ModelState.IsValid)
            {
               _context.Add(author);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var author = await _context.Authors.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }
            return View(author);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, AuthorsModel author)
        {
            if (id <= 0 || author == null)
            {
                return NotFound();
            }

            var existingAuthor = await _context.Authors.FindAsync(id);
            if (existingAuthor == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    
                    existingAuthor.AuthorName = author.AuthorName;
                    existingAuthor.BirthDate = author.BirthDate;
                    existingAuthor.DeadDate = author.DeadDate;
                    existingAuthor.Bio = author.Bio;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Authors.Any(e => e.AuthorId == author.AuthorId))
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

            return View(author);
        }


        public async Task<IActionResult> Delete(int id)
        {
            var author = await _context.Authors.FindAsync(id);

            if (author == null)
            {
                TempData["ErrorMessage"] = "Author not found.";
                return RedirectToAction(nameof(Index));
            }

            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Author deleted successfully.";
            return RedirectToAction(nameof(Index));
        }

    }
}
