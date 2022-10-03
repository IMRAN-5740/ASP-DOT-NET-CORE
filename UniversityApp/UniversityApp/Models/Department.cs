using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UniversityApp.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Display(Name = "Department Short Name")]
        public string DeptShortName { get; set; }
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
    }
}
