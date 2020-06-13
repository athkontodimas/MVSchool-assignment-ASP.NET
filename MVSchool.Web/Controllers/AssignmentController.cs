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
    public class AssignmentController : Controller
    {
        // GET: assignments
        public ActionResult ShowAssignments()
        {
            AssignmentRepository assignmentRepository = new AssignmentRepository();
            var assignment = assignmentRepository.GetAll();
            return View(assignment.ToList());
        }
        public ActionResult Details(int? id)
        {
            AssignmentRepository assignmentRepository = new AssignmentRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var assignment = assignmentRepository.GetById(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }
    
    }
}