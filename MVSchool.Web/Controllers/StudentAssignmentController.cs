using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVSchool.Services;
using MVSchool.Entities;
using MVSchool.Database;
using PagedList;
using PagedList.Mvc;


namespace MVSchool.Web.Controllers
{
    public class StudentAssignmentController : Controller
    {
        // GET: StudentAssignment
        public ActionResult AllStudentAssignments(string sortOrder, string searchName, string searchCourse, string searchAssignment,int? searchMaxGrade, int? searchMinGrade)
        {
            ViewBag.NameSort = String.IsNullOrEmpty(sortOrder) ? "NameDesc" : "";
            ViewBag.CourseSort = sortOrder == "CourseAsc" ? "CourseDesc" : "CourseAsc";
            ViewBag.AssignmentSort = sortOrder == "AssignmentAsc" ? "AssignmentDesc" : "AssignmentAsc";
            ViewBag.GradeSort = sortOrder == "GradeAsc" ? "GradeDesc" : "GradeAsc";
            ViewBag.SortOrder = sortOrder;

            ViewBag.SearchedName = searchName;
            ViewBag.SearchedCourse = searchCourse;
            ViewBag.SearchedAssignment = searchAssignment;
            ViewBag.SearchedMaxGrade = searchMaxGrade;
            ViewBag.SearchedMinGrade = searchMinGrade;
           

           

            StudAssignRepository studAssignRepository = new StudAssignRepository();
            var studAssign = studAssignRepository.GetAll();


            // ------------------------ Ταξινόμηση φθίνουσα/αύξουσα ----------------------------------------------------
            switch (sortOrder)
            {
                case "NameDesc":
                    studAssign = studAssign.OrderByDescending(x => x.Student.FirstName).ThenByDescending(x=>x.Student.LastName);
                    break;
                case "CourseAsc":
                    studAssign = studAssign.OrderBy(x => x.Course.Title);
                    break;
                case "CourseDesc":
                    studAssign = studAssign.OrderByDescending(x => x.Course.Title);
                    break;
                case "AssignmentAsc":
                    studAssign = studAssign.OrderBy(x => x.Assignment);
                    break;
                case "AssignmentDesc":
                    studAssign = studAssign.OrderByDescending(x => x.Assignment);
                    break;
                case "GradeAsc": studAssign = studAssign.OrderBy(x => x.Grade);
                    break;
                case "GradeDesc": studAssign = studAssign.OrderByDescending(x => x.Grade); 
                    break;

                default:
                    studAssign = studAssign.OrderBy(x => x.Student.FirstName).ThenBy(x => x.Student.LastName);
                    break;
            }

            //---------------------------------- Φιλτράρισμα ------------------------------------------
            if (!string.IsNullOrWhiteSpace(searchName))
            {
                studAssign = studAssign.Where(x => x.Student.FirstName.ToUpper().Contains(searchName.ToUpper()));
            }

            if (!string.IsNullOrWhiteSpace(searchCourse))
            {
                studAssign = studAssign.Where(x => x.Course.Title.ToUpper().Contains(searchCourse.ToUpper()));
            }

            if (!(searchAssignment is null))
            {
                studAssign = studAssign.Where(x => x.Assignment.Title.ToUpper().Contains(searchAssignment.ToUpper()));
            }
            if (!(searchMinGrade is null))
            {
                studAssign = studAssign.Where(x => x.Grade >= searchMinGrade);
            }
            if (!(searchMaxGrade is null))
            {
                studAssign = studAssign.Where(x => x.Grade <= searchMaxGrade);
            }
          
            return View(studAssign);
        }

    }
}