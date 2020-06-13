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
    public class CourseController : Controller
    {
        // GET: courses
        public ActionResult ShowCourses()
        {
            CourseRepository courseRepository = new CourseRepository();
            var course = courseRepository.GetAll();

            return View(course.ToList());
        }
        public ActionResult Details(int? id)
        {
            CourseRepository courseRepository = new CourseRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var course = courseRepository.GetById(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        public ActionResult ShowStudentsPerCourse()
        {
            CourseRepository courseRepository = new CourseRepository();
            var courses = courseRepository.GetAll();
            return View(courses.ToList());
        }

        public ActionResult ShowAssignmentsPerCourse()
        {
            CourseRepository courseRepository = new CourseRepository();
            var course = courseRepository.GetAll();
            return View(course.ToList());
        }
    }
}