using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagmentSystemIdentity.Models
{
    public class CollegesModel
    {
        [Key]
        public int CollegeId { get; set; }
        public string CollegeName { get; set; }
        public string CollegeAddress { get; set; }
        public string CollegeEmail { get; set; }

        [ValidateNever]
        public List<StudentsModel> Students { get; set; } = new List<StudentsModel>();

    }
}
