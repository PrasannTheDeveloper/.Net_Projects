using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagmentSystemIdentity.Models
{
    public class AuthorsModel
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeadDate { get; set; }
        public string Bio { get; set; }

        [ValidateNever]
        public List<BooksModel> Books { get; set; } = new List<BooksModel>();
    }
}
