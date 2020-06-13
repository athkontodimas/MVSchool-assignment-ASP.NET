using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVSchool.Web.Models;
using MVSchool.Entities;
using MVSchool.Services;

namespace MVSchool.Web.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        public ActionResult ShowAllStatistics()
        {
            StatisticsViewModel vm = new StatisticsViewModel();

            CourseRepository courseRepository = new CourseRepository();
            var courses = courseRepository.GetAll();
            StudentRepository studentRepository = new StudentRepository();
            var students = studentRepository.GetAll();
            TrainerRepository trainerRepository = new TrainerRepository();
            var trainers = trainerRepository.GetAll();
            AssignmentRepository assignmentRepository = new AssignmentRepository();
            var assignments = assignmentRepository.GetAll();
            

            vm.NoOfCourses = courses.Count();
            vm.NoOfStudents = students.Count();
            vm.NoOfTrainers = trainers.Count();
            vm.NoOfAssignments = assignments.Count();
                        
            vm.Courses = courses;
            vm.Trainers = trainers;
            vm.Students = students;
            vm.Assignments = assignments;


            //------------------------------------ Μεση βαθμολογία ανά Course (Στην κονσολα τρέχει...Στο browser δεν περνάει σωστά το vm )
            List<double> avgGradPerCourse = new List<double>();
            double[] avg = new double[6];
            foreach (var co in courses)
            {
                Console.WriteLine(co.Title);
                double sum = 0;
                int count = 0;
               
                foreach (var item in co.StudentAssignments)
                {
                    Console.WriteLine("\t\t" + item.Assignment.Title);
                    Console.WriteLine("\t\t\t" + item.Grade);
                    sum = sum + item.Grade;
                    count += 1;

                }
                avgGradPerCourse.Add((sum / count));
               
            }
            vm.AvgGradePerCourse = avgGradPerCourse;

            return View(vm);
        }
    }
}