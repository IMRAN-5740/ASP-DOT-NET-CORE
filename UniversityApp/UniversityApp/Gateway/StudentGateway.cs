using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityApp.Models;


namespace UniversityApp.Gateway
{
    public class StudentGateway
    {
        public List<Student>GetStudents()
        {
            string connectionString = null;
            connectionString= "Data Source=MOHAMMAD-IMRAN;Initial Catalog=UniversityApp;User ID=sa;Password=imran";
            SqlConnection connection = new SqlConnection(connectionString);
            
            string Query = "SELECT *FROM vStudentInfo";
            SqlCommand command=new SqlCommand(Query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Student> students = new List<Student>();
            while(reader.Read())
            {
                Student student = new Student();
                student.StudentName = reader["StudentName"].ToString();
                student.Email = reader["Email"].ToString();
                student.RegNo = reader["RegNo"].ToString();
                student.Address = reader["Address"].ToString();
                student.DepartmentName = reader["DepartmentName"].ToString();
                students.Add(student);
            }
            connection.Close();
            return students;
            
        }
        public List<Department>GetDepartments()
        {
            string connectionString = null;
            connectionString = "Data Source=MOHAMMAD-IMRAN;Initial Catalog=UniversityApp;User ID=sa;Password=imran";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM Department_data";
            SqlCommand command = new SqlCommand(Query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Department> departments = new List<Department>();
            while (reader.Read())
            {
                Department department = new Department();
                department.Id = (int)reader["Id"];
                department.DeptShortName = reader["DeptShortName"].ToString();
                //department.Department = reader["Department"].ToString();
                
                departments.Add(department);
            }
            connection.Close();
            return departments;
        }
    }
}
