using MyMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class StudentController : Controller
    {
        static IList<Student> studentList = new List<Student>
            {
                new Student(){StudentID=1,Name="Kamran Yaseen",Age=21},
                new Student(){StudentID=2,Name="Imran Yaseen",Age=23},
                new Student(){StudentID=3,Name="Yousuf Yaseen",Age=23},
                new Student(){StudentID=4,Name="Azhar Yaseen",Age=26},
                new Student(){StudentID=5,Name="Sana Yaseen",Age=12 },
                new Student(){StudentID=6,Name="Aiman Saleem",Age=32},
                new Student(){StudentID=7,Name="Ahlam TRemimi",Age=53},
                new Student(){StudentID=8,Name="Ibrahim Yaseen",Age=53},
                new Student(){StudentID=9,Name="Aamir Sattar",Age=34},
                new Student(){StudentID=10,Name="Abdullah Khan",Age=23}
            };
        public ActionResult Index()
        {
            return View(studentList.OrderBy(s=>s.StudentID).ToList());
        }

        public ActionResult Edit(int Id)
        {
            var std = studentList.Where(s => s.StudentID == Id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            if (ModelState.IsValid)
            {
                var student = studentList.Where(s => s.StudentID == std.StudentID).FirstOrDefault();
                studentList.Remove(std);
                studentList.Add(std);
                return RedirectToAction("Index");
            }
            return View("Index");
           
        }
    }
}
