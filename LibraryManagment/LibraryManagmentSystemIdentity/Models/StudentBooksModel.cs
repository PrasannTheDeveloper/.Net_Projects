using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagmentSystemIdentity.Models
{
    public class StudentBooksModel
    {
        [Key, Column(Order = 0)]
        public int StudentId { get; set; }

        [ValidateNever]
        [ForeignKey("StudentId")]
        public StudentsModel Student { get; set; }

        [Key, Column(Order = 1)]
        public int BookId { get; set; }

        [ValidateNever]
        [ForeignKey("BookId")]
        public BooksModel Book { get; set; }

        public DateTime BorrowedDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
