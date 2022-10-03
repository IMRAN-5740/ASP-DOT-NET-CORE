using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace UniversityApp.Models

{
    public class Student
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage="Please Provide Student Name"),MinLength(5)]
        [Display(Name ="Student Name")]
        public string StudentName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Reg No")]
        public string RegNo { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
    }
}
