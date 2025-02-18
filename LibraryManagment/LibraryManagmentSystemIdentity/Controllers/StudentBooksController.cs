using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryManagmentSystemIdentity.Models;
using System.Threading.Tasks;
using LibraryManagmentSystemIdentity.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryManagmentSystemIdentity.Controllers
{
    public class StudentBooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentBooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StudentBooks
        public async Task<IActionResult> Index()
        {
            var studentBooks = await _context.StudentBooks
                .Include(sb => sb.Student)
                .Include(sb => sb.Book)
                .ToListAsync();
            return View(studentBooks);
        }

        // GET: StudentBooks/Create
        public IActionResult Create()
        {
            var studentBooks = new StudentBooksModel();

            // Ensure that the lists are populated
            var students = _context.Students.ToList();
            var books = _context.Books.ToList();

            Console.WriteLine($"Number of students: {students.Count}");
            Console.WriteLine($"Number of books: {books.Count}");

            // Populating the ViewBag with the list of students and books
            ViewBag.Students = new SelectList(students, "StudentId", "StudentName");
            ViewBag.Books = new SelectList(books, "BookId", "BookName");

            return View(studentBooks);
        }



        // POST: StudentBooks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentBooksModel studentBook)
        {
            Console.WriteLine($"📌 AuthorsId received in POST: {studentBook.StudentId}{studentBook.Student}");

            if (ModelState.IsValid)
            {
                _context.Add(studentBook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Students = new SelectList(_context.Students, "StudentId", "StudentName");
            ViewBag.Books = new SelectList(_context.Books, "BookId", "BookName");
            return View(studentBook);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int studentId, int bookId)
        {
            Console.WriteLine($"📌 StudentId: {studentId}, BookId: {bookId}");

            var studentBook = await _context.StudentBooks
                .Include(sb => sb.Student)
                .Include(sb => sb.Book)
                .FirstOrDefaultAsync(sb => sb.StudentId == studentId && sb.BookId == bookId);

            if (studentBook == null)
            {
                return NotFound();
            }

            return View(studentBook);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int studentid, int bookid, StudentBooksModel studentBook)
        {
            var studentBookInDb = await _context.StudentBooks
                .Include(sb => sb.Student)
                .Include(sb => sb.Book)
                .FirstOrDefaultAsync(sb => sb.StudentId == studentid && sb.BookId == bookid);
            if (ModelState.IsValid)
            {
                studentBookInDb.BorrowedDate = studentBook.BorrowedDate;
                studentBookInDb.ReturnDate = studentBook.ReturnDate;
                _context.Update(studentBookInDb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentBook);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int studentid, int bookid)
        {
            var studentBookInDb = await _context.StudentBooks
                .Include(sb => sb.Student)
                .Include(sb => sb.Book)
                .FirstOrDefaultAsync(sb => sb.StudentId == studentid && sb.BookId == bookid);

            if (studentBookInDb == null)
            {
                return NotFound();  // Return an error if no matching record is found
            }

            if (ModelState.IsValid)
            {
                _context.Remove(studentBookInDb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));  // Redirect to the Index action after deletion
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
