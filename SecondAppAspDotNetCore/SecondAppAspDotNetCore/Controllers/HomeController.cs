using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecondAppAspDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SecondAppAspDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public string GetStudentInfo(Student student)
        {
            return "Student Name :"+student.Name+Environment.NewLine+"Student Email :"+student.Email+Environment.NewLine+"Student Address :"+student.Address+Environment.NewLine+"Student Father Name :"+student.FatherName+Environment.NewLine;
        }
        //public string Hello(string name)
        //{
        //    return ("Welcome to the ASP DOT NET CORE Application with Mohammad Imran."+name);
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
