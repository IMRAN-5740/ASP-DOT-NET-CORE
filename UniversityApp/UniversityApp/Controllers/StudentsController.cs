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
            student.DepartmentId = 1;
            ViewBag.Student = student;
            return View("Index");
        }
        [HttpGet]
        public ActionResult SaveStudent()
        {
            StudentManager studentManager = new StudentManager();
            ViewBag.Department = studentManager.GetDepartments();
            ViewBag.Students = studentManager.GetStudents();
            return View();
        }

        [HttpPost]
        public ActionResult SaveStudent(Student student)
        {
           
            StudentManager studentManager = new StudentManager(); 
            string message = "";
            if(ModelState.IsValid)
            {
               
                string connectionString = null;
                connectionString = "Data Source=MOHAMMAD-IMRAN;Initial Catalog=UniversityApp;User ID=sa;Password=imran";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string Query = "INSERT INTO Student_data (StudentName,Email,RegNo,Address,DepartmentId) " +
                    "VALUES('" + student.StudentName + "','" + student.Email + "','" + student.RegNo + "','" + student.Address + "','" + student.DepartmentId + "')";
                SqlCommand command = new SqlCommand(Query, connection);
                int rowCount = command.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    message = "Data Saved Successfully";
                }
                else
                {
                    message = "Data Not Saved";
                }
                connection.Close();
            }
            
            
            

            ViewBag.Department = studentManager.GetDepartments();
            ViewBag.Students = studentManager.GetStudents();
            ViewBag.Message = message;
            return View();     
        }
        //public List<string>GetDepartments()
        //    {
        //    return new List<string> { "CSE", "EEE", "ACCE", "CE", "FAE", "Architecture" };
        //    }
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

            string Query = "SELECT * FROM vStudentInfo";
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
                //student.DepartmentId = (int)reader["DepartmentId"]; 
                student.DepartmentName = reader["DepartmentName"].ToString(); 
                students.Add(student);
            }
            connection.Close();
            return students;
        }
    }
}
