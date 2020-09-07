using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Student.Models;

namespace Student.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentClass studentClass;

        public HomeController(StudentClass studentClass)
        {
            this.studentClass = studentClass;
        }

        public IActionResult Index()
        {
            var model = studentClass.GetStudents();
            return View(model);
        }



        public IActionResult StudentAdd(Guid id)
        {
            Models.Student model = id == default ? new Models.Student() : studentClass.GetStudentById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult StudentAdd(Models.Student model)
        {
            if (ModelState.IsValid)
            {
                studentClass.ChangeStudent(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult StudentEdit(Guid id)
        {
            Models.Student model = id == default ? new Models.Student() : studentClass.GetStudentById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult StudentEdit(Models.Student model)
        {
            if (ModelState.IsValid)
            {
                studentClass.ChangeStudent(model);
                return RedirectToAction("index");
            }
            return View(model);
        }


        [HttpPost]
        public IActionResult RemoveStudent(Guid id)
        {
            studentClass.RemoveStudent(new Models.Student { Id = id });
            return RedirectToAction("index");
        }

    }
}
