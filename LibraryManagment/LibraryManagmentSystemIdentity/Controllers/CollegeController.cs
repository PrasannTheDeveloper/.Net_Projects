using LibraryManagmentSystemIdentity.Data;
using LibraryManagmentSystemIdentity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagmentSystemIdentity.Controllers
{
    public class CollegeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CollegeController(ApplicationDbContext context)
        {
            _context = context;
        }   

        public async Task<IActionResult> Index()
        {
            return View(await _context.Colleges.ToListAsync());
        }

        public async Task<IActionResult> Create()
        {
            var college = new CollegesModel();
            return View(college);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CollegesModel college)
        {
            if (ModelState.IsValid)
            {
                _context.Add(college);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(college);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var collage = await _context.Colleges.FindAsync(id);
               return View(collage);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, CollegesModel college)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            var extingCollege = await _context.Colleges.FindAsync(id);
            extingCollege.CollegeName = college.CollegeName;
            extingCollege.CollegeEmail = college.CollegeEmail;
            extingCollege.CollegeAddress = college.CollegeAddress;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var college = await _context.Colleges.FindAsync(id);
                _context.Remove(college);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
