using System.Collections.Generic;
using UniversityApp.Gateway;
using UniversityApp.Models;

namespace UniversityApp.Manager
{
    public class StudentManager
    {
        StudentGateway aGateway= new StudentGateway();
        public List<Student> GetStudents()
        {
            return aGateway.GetStudents();
        }
        public List<Department>GetDepartments()
        {
            return aGateway.GetDepartments();
        }
    }
}
