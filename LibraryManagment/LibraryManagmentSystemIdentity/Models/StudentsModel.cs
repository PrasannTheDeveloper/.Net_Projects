using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagmentSystemIdentity.Models
{
    public class StudentsModel
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public int StudentAge { get; set; }

        [ValidateNever]
        public List<StudentBooksModel> StudentBooks { get; set; } = new List<StudentBooksModel>();

        [ForeignKey("College")]
        public int CollegeId { get; set; }
        [ValidateNever]
        public CollegesModel College { get; set; }
    }
}
