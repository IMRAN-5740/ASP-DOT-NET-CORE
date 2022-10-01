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
            
            string Query = "SELECT * FROM Student_data";
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
                student.Department = reader["Department"].ToString();
                students.Add(student);
            }
            connection.Close();
            return students;
            
        }
    }
}
