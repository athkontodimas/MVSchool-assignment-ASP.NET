using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVSchool.Services;
using MVSchool.Entities;
using MVSchool.Database;
using System.Net;

namespace MVSchool.Web.Controllers
{
    public class StudentController : Controller
    {
        // GET: students
        public ActionResult ShowStudents()
        {
            StudentRepository studentRepository = new StudentRepository();
            var students = studentRepository.GetAll();
            return View(students);
        }
        public ActionResult Details(int? id)
        {
            StudentRepository studentRepository = new StudentRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var student = studentRepository.GetById(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
    }
}