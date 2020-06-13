using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVSchool.Database;
using MVSchool.Entities;
using MVSchool.Services;


namespace MVSchool.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDatabase db = new MyDatabase())
            {
                TrainerRepository trainerRepository = new TrainerRepository();
                StudentRepository studentRepository = new StudentRepository();
                AssignmentRepository assignmentRepository = new AssignmentRepository();
                CourseRepository courseRepository = new CourseRepository();
                StudAssignRepository studAssignmentRepository = new StudAssignRepository();

                var studentlist = studentRepository.GetAll();
                var trainerlist = trainerRepository.GetAll();
                var assignmentlist = assignmentRepository.GetAll();
                var courselist = courseRepository.GetAll();
                var studassignlist = studAssignmentRepository.GetAll();

                //======================   Grades per student
                foreach (var student in studentlist)
                {
                    Console.WriteLine(student.FirstName);
                    foreach (var assignment in student.StudentAssignments)
                    {

                        Console.WriteLine("\t\t" + assignment.Assignment.Title + " " + assignment.Grade);
                    }

                }

                //=============================== Grades per sudent per course
                Console.WriteLine("====================GRADES PER COURSE PER STUDENTS==================================");
                foreach (var studas in studassignlist)
                {
                    Console.WriteLine(studas.Student.FirstName + " " + studas.Course.Title);
                    Console.WriteLine("\t\t\t\t" + studas.Assignment.Title + " " + studas.Grade);

                }


                foreach (var stude in studentlist)
                {
                    Console.WriteLine($"Student: {stude.LastName}");

                    foreach (var cours in stude.Courses)
                    {
                        Console.Write("\t\t");
                        Console.WriteLine("Course: " + cours.Title);
                        foreach (var assign in cours.Assignments)
                        {
                            Console.Write("\t\t\t\t");
                            Console.WriteLine("Assignment title: " + assign.Title);
                        }
                    }
                    Console.WriteLine();
                }



                //Console.WriteLine("========================================================================");

                foreach (var course in courselist)
                {
                    Console.Write("In " + course.Title);
                    Console.WriteLine(" are enrolled " + course.Students.Count() + " students");
                    foreach (var studentCourse in course.Students)
                    {
                        Console.Write("\t\t");
                        Console.WriteLine(studentCourse.FirstName + " " + studentCourse.LastName);

                    }
                    Console.WriteLine();
                }
                //================================== Assignments per course===========================
                foreach (var item in courselist)
                {
                    Console.WriteLine(item.Title);
                    foreach (var item2 in item.Assignments)
                    {
                        Console.WriteLine("\t\t\t" + item2.Title);
                    }
                }

                //=========================================== Students per course per assignment ==============================


                foreach (var stud in studentlist)
                {
                    Console.WriteLine(stud.FirstName);
                    foreach (var item in stud.StudentAssignments)
                    {
                        Console.WriteLine("\t\t" + item.Assignment.Title);
                        Console.WriteLine("\t\t\t" + item.Course.Title);
                    }
                }

                //=========================================== Average grade per course ==============================

                List<double> avgGradPerCourse = new List<double>();
                
                foreach (var co in courselist)
                {
                    Console.WriteLine(co.Title);
                    double sum = 0;
                    int count = 0;
                    foreach (var item in co.StudentAssignments)
                    {
                        //Console.WriteLine("\t\t" + item.Assignment.Title);
                        //Console.WriteLine("\t\t\t" + item.Grade);
                        sum = sum + item.Grade;
                        count += 1;
                        
                    }
                    avgGradPerCourse.Add(sum/count);  //λιστα με τη μεση βαθμολογία για κάθε μάθημα
                    Console.WriteLine("Average grade is: "+(sum/count));
                    
                }
               
              
                
               
            }

        }
    }
}
