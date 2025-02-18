using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagmentSystemIdentity.Models
{
    public class BooksModel
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        [ValidateNever]
        public AuthorsModel Author { get; set; }

        [ValidateNever]
        public List<StudentBooksModel> StudentBooks { get; set; } = new List<StudentBooksModel>();
    }
}
