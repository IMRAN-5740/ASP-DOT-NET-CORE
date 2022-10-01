using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityApp.Manager;
using UniversityApp.Models;
namespace UniversityApp.Controllers
{
    public class StudentsController : Controller
    {
        public ActionResult Index()
        {
            Student student = new Student();
            student.StudentName = "Mohammad Abdullah Al Imran";
            student.Email = "imranbsmrstucse@gmail.com";
            student.RegNo = "2018";
            student.Address = "Satana Baluya,Gobindaganj,Gaibandha";
            student.Department = "Computer Science and Engineering";
            ViewBag.Student = student;
            return View("Index");
        }
        [HttpGet]
        public ActionResult SaveStudent()
        {
            StudentManager studentManager = new StudentManager();
            ViewBag.Department = GetDepartments();
            ViewBag.Students = studentManager.GetStudents();
            return View();
        }

        [HttpPost]
        public string SaveStudent(Student student)
        {
            StudentManager studentManager = new StudentManager();
            string message = "";
            string connectionString = null;
            connectionString = "Data Source=MOHAMMAD-IMRAN;Initial Catalog=UniversityApp;User ID=sa;Password=imran";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string Query = "INSERT INTO Student_data (StudentName,Email,RegNo,Address,Department) " +
                "VALUES('" + student.StudentName + "','" + student.Email + "','" + student.RegNo + "','" + student.Address + "','" + student.Department + "')";
            SqlCommand command = new SqlCommand(Query, connection);
            int rowCount = command.ExecuteNonQuery();
            if (rowCount > 0)
            {
                // return "Data Saved Successfully";
                message = "Data Saved Successfully";
            }
            else
            {
                //return "Data Not Saved";
                message = "Data Not Saved";
            }
            connection.Close();
            

            ViewBag.Department = GetDepartments();
            ViewBag.Students = studentManager.GetStudents();
            return ViewBag.Message = message;
            //return View();     
        }
        public List<string>GetDepartments()
            {
            return new List<string> { "CSE", "EEE", "ACCE", "CE", "FAE", "Architecture" };
            }
        public ActionResult GetAllStudent()
        {
            ViewBag.BindAllStudent = BindAllStudent();
            return View(BindAllStudent());
        }
        public List<Student>BindAllStudent()
        {

            //return new List<Student>
            //{
            //  //new Student{StudentName="Mohammad Imran",Email="imranbsmrstucse@gmail.com",RegNo="2019",Address="Satana Baluya Gobindaganj Gaibandha",Department="Computer Science and Engineering"},
            //  //new Student{StudentName="Imran",Email="imranbsmrstucse@gmail.com",RegNo="2019",Address="Satana Baluya Gobindaganj Gaibandha",Department="Computer Science and Engineering"},
            //  //new Student{StudentName="Mohammad Abdullah Al Imran",Email="imranbsmrstucse@gmail.com",RegNo="2019",Address="Satana Baluya Gobindaganj Gaibandha",Department="Computer Science and Engineering"}
            //  new Student{}
            //};
            string connectionString = null;
            connectionString = "Data Source=MOHAMMAD-IMRAN;Initial Catalog=UniversityApp;User ID=sa;Password=imran";
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = "SELECT * FROM Student_data";
            SqlCommand command = new SqlCommand(Query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Student> students = new List<Student>();
            while (reader.Read())
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
