namespace MVSchool.Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MVSchool.Entities;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<MVSchool.Database.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVSchool.Database.MyDatabase context)
        {

            //--------Create students------------------------------------
            Student s1 = new Student() { FirstName = "Sotiris", LastName = "Papadopoulos", DateOfBirth = new DateTime(1985, 5, 20), PhotoUrl = "https://image.shutterstock.com/image-photo/confident-handsome-student-holding-books-600w-366568778.jpg" };
            Student s2 = new Student() { FirstName = "Maria", LastName = "Giannakopoulou", DateOfBirth = new DateTime(1993, 2, 28), PhotoUrl = ""};
            Student s3 = new Student() { FirstName = "Giannis", LastName = "Golas", DateOfBirth = new DateTime(1998, 7, 7), PhotoUrl = "https://image.shutterstock.com/z/stock-photo-young-man-or-teenage-student-isolated-on-color-background-with-backpack-and-books-1603057081.jpg" };
            Student s4 = new Student() { FirstName = "Kyriakh", LastName = "Nolemh", DateOfBirth = new DateTime(1979, 4, 9), PhotoUrl = "https://image.shutterstock.com/z/stock-photo-shot-of-young-asian-female-student-sitting-at-table-and-writing-on-notebook-young-female-student-534602335.jpg" };
            Student s5 = new Student() { FirstName = "Giwrgos", LastName = "Ipatiou", DateOfBirth = new DateTime(1995, 10, 29), PhotoUrl = "https://image.shutterstock.com/z/stock-photo-shot-of-young-asian-female-student-sitting-at-table-and-writing-on-notebook-young-female-student-534602335.jpg" };
            Student s6 = new Student() { FirstName = "Mixalis", LastName = "Kwnstantinou", DateOfBirth = new DateTime(1988, 8, 12), PhotoUrl = "https://image.shutterstock.com/image-photo/portrait-male-student-standing-college-600w-763464100.jpg" };
            Student s7 = new Student() { FirstName = "Athanasios", LastName = "Liopidas", DateOfBirth = new DateTime(1990, 11, 9), PhotoUrl = "https://image.shutterstock.com/z/stock-photo-student-college-student-teenager-283862963.jpg" };
            Student s8 = new Student() { FirstName = "Panagiotis", LastName = "Sekinas", DateOfBirth = new DateTime(1989, 8, 3), PhotoUrl = "https://image.shutterstock.com/z/stock-photo-smiling-young-nerdy-bearded-stylish-student-is-standing-on-pure-background-in-glasses-and-casual-662951155.jpg" };
            Student s9 = new Student() { FirstName = "Hlias", LastName = "Liopis", DateOfBirth = new DateTime(1982, 6, 15), PhotoUrl ="" };
            Student s10 = new Student() { FirstName = "Vasilikh", LastName = "Xouliara", DateOfBirth = new DateTime(1991, 7, 13), PhotoUrl ="" };
            Student s11 = new Student() { FirstName = "Georgia", LastName = "Lamprinakou", DateOfBirth = new DateTime(1986, 8, 30), PhotoUrl ="" };
            Student s12 = new Student() { FirstName = "Vasilis", LastName = "Papadatos", DateOfBirth = new DateTime(1981, 3, 25), PhotoUrl ="" };
            Student s13 = new Student() { FirstName = "Minas", LastName = "Apostolou", DateOfBirth = new DateTime(1996, 1, 20), PhotoUrl ="" };
            Student s14 = new Student() { FirstName = "Sokratis", LastName = "Lantemas", DateOfBirth = new DateTime(1983, 12, 3), PhotoUrl ="" };
            Student s15 = new Student() { FirstName = "Antwnis", LastName = "Adam", DateOfBirth = new DateTime(1991, 9, 5), PhotoUrl = "https://image.shutterstock.com/z/stock-photo-portrait-of-smiling-young-college-student-with-books-and-backpack-against-white-background-1192615495.jpg" };
            Student s16 = new Student() { FirstName = "Gerasimos", LastName = "Veremis", DateOfBirth = new DateTime(1991, 12, 7), PhotoUrl ="" };
            Student s17 = new Student() { FirstName = "Sofia", LastName = "Vavouri", DateOfBirth = new DateTime(1991, 1, 25), PhotoUrl ="" };
            Student s18 = new Student() { FirstName = "Polyxeni", LastName = "Tsiklitira", DateOfBirth = new DateTime(1981, 2, 6), PhotoUrl ="" };
            Student s19 = new Student() { FirstName = "Olga", LastName = "Mylwna", DateOfBirth = new DateTime(1999, 6, 14), PhotoUrl ="" };
            Student s20 = new Student() { FirstName = "Sotiria", LastName = "Kalamitsi", DateOfBirth = new DateTime(1978, 8, 19), PhotoUrl ="" };
            Student s21 = new Student() { FirstName = "Emmanuela", LastName = "Alepoudeli", DateOfBirth = new DateTime(1983, 4, 29), PhotoUrl ="" };
            Student s22 = new Student() { FirstName = "Marianna", LastName = "Diplarakou", DateOfBirth = new DateTime(1990, 3, 30), PhotoUrl = ""};
            Student s23 = new Student() { FirstName = "Marina", LastName = "Makouli", DateOfBirth = new DateTime(1995, 6, 12), PhotoUrl ="" };
            Student s24 = new Student() { FirstName = "Lampros", LastName = "Ouzounis", DateOfBirth = new DateTime(1999, 11, 10), PhotoUrl ="" };
            Student s25 = new Student() { FirstName = "Aikaterini", LastName = "Papathanasiou", DateOfBirth = new DateTime(1991, 4, 10), PhotoUrl = ""};
            Student s26 = new Student() { FirstName = "Emmanouil", LastName = "Nikandros", DateOfBirth = new DateTime(2000, 7, 19), PhotoUrl ="" };
            Student s27 = new Student() { FirstName = "Stavros", LastName = "Xwrafas", DateOfBirth = new DateTime(1988, 9, 22), PhotoUrl = ""};
            Student s28 = new Student() { FirstName = "Apostolos", LastName = "Peponis", DateOfBirth = new DateTime(1983, 3, 27), PhotoUrl = ""};
            Student s29 = new Student() { FirstName = "Pavlina", LastName = "Aleura", DateOfBirth = new DateTime(1990, 5, 18), PhotoUrl = "" };
            Student s30 = new Student() { FirstName = "Paraskeui", LastName = "Mpoutidi", DateOfBirth = new DateTime(1979, 1, 31), PhotoUrl = ""};
            Student s31 = new Student() { FirstName = "Nikolaos", LastName = "Eutaxias", DateOfBirth = new DateTime(1984, 10, 1), PhotoUrl = ""};
            Student s32 = new Student() { FirstName = "Dimitra", LastName = "Xantoumi", DateOfBirth = new DateTime(2001, 9, 13), PhotoUrl = ""};
            Student s33 = new Student() { FirstName = "Pantelehmon", LastName = "Mhtropoulos", DateOfBirth = new DateTime(1977, 9, 26), PhotoUrl = ""};
            Student s34 = new Student() { FirstName = "Alexandra", LastName = "Kazazi", DateOfBirth = new DateTime(1980, 10, 7), PhotoUrl ="" };
            Student s35 = new Student() { FirstName = "Iakobos", LastName = "Pipinos", DateOfBirth = new DateTime(1987, 4, 17), PhotoUrl = ""};
            


            //--------Create trainers------------------------------------
            Trainer t1 = new Trainer() { FirstName = "Kyriakos", LastName = "Papaspyroy", Subject = "Mathematics" };
            Trainer t2 = new Trainer() { FirstName = "Xaralampos", LastName = "Mantekas", Subject = "Coding" };
            Trainer t3 = new Trainer() { FirstName = "Sotiris", LastName = "Lamprou", Subject = "Literature" };
            Trainer t4 = new Trainer() { FirstName = "Georgios", LastName = "Sotirakopoulos", Subject = "Science" };
            Trainer t5 = new Trainer() { FirstName = "Spyridwn", LastName = "Papadakis", Subject = "Arts" };

            //------------------Create Courses
            Course c1 = new Course() { Title = "Computer programming", StartDate = new DateTime(2019, 09, 15), EndDate = new DateTime(2020, 04, 10) };
            Course c2 = new Course() { Title = "Algebra", StartDate = new DateTime(2019, 09, 18), EndDate = new DateTime(2020, 04, 12) };
            Course c3 = new Course() { Title = "Geometry", StartDate = new DateTime(2019, 09, 15), EndDate = new DateTime(2020, 04, 10) };
            Course c4 = new Course() { Title = "Poetry", StartDate = new DateTime(2019, 10, 05), EndDate = new DateTime(2020, 05, 20) };
            Course c5 = new Course() { Title = "Physics", StartDate = new DateTime(2020, 1, 20), EndDate = new DateTime(2020, 07, 10) };
            Course c6 = new Course() { Title = "Music", StartDate = new DateTime(2020, 1, 22), EndDate = new DateTime(2020, 07, 15) };

            //------------------Create Assignments
            Assignment a1 = new Assignment() { Title = "C# Calculator", Description = "Create calculator app with C#", SubmissionDate = new DateTime(2020, 3, 5) };
            Assignment a2 = new Assignment() { Title = "Calendar page", Description = "Create web app presents current date", SubmissionDate = new DateTime(2020, 2, 20) };
            Assignment a3 = new Assignment() { Title = "Ecdl test", Description = "Complete ecdl Internet test", SubmissionDate = new DateTime(2019, 12, 10) };
            Assignment a4 = new Assignment() { Title = "Triangle area", Description = "Compute area of the given triangle", SubmissionDate = new DateTime(2019, 10, 23) };
            Assignment a5 = new Assignment() { Title = "Geometric mean", Description = "Compute geometric mean of 10 values", SubmissionDate = new DateTime(2020, 1, 13) };
            Assignment a6 = new Assignment() { Title = "Speed", Description = "Calculate speed of a train", SubmissionDate = new DateTime(2020, 5, 17) };
            Assignment a7 = new Assignment() { Title = "Periodic Table", Description = "Write the type of all chemical elements", SubmissionDate = new DateTime(2020, 3, 12) };
            Assignment a8 = new Assignment() { Title = "Poetry", Description = "Write about your favorite poem and its writer", SubmissionDate = new DateTime(2020, 11, 6) };
            Assignment a9 = new Assignment() { Title = "Song", Description = "Write a short song using all notes", SubmissionDate = new DateTime(2020, 4, 4) };
            Assignment a10 = new Assignment() { Title = "Table calculations", Description = "Multiply 2 two-dimensional tables", SubmissionDate = new DateTime(2020, 2, 20) };
            Assignment a11 = new Assignment() { Title = "Variance", Description = "Find variance of 3 numbers", SubmissionDate = new DateTime(2020, 3, 30) };
            Assignment a12 = new Assignment() { Title = "Square Volume", Description = "Calculate volume of a square", SubmissionDate = new DateTime(2020, 4, 5) };
            Assignment a13 = new Assignment() { Title = "Circle area", Description = "Calculate area of the circle", SubmissionDate = new DateTime(2020, 3, 20) };
            Assignment a14 = new Assignment() { Title = "Drawing", Description = "Draw a car", SubmissionDate = new DateTime(2020, 6, 16) };
            Assignment a15 = new Assignment() { Title = "Theater", Description = "Write a small play", SubmissionDate = new DateTime(2020, 4, 4) };
            Assignment a16 = new Assignment() { Title = "Friction", Description = "Calculate coefficient of friction", SubmissionDate = new DateTime(2020, 5, 3) };
            Assignment a17 = new Assignment() { Title = "Spanish Literature", Description = "Describe a spanish novel you have read ", SubmissionDate = new DateTime(2020, 5, 15) };
            Assignment a18 = new Assignment() { Title = "Grammar", Description = "Find and correct errors in syntax", SubmissionDate = new DateTime(2020, 3, 10) };

            //-----------------Assign trainer to course
            c1.Trainer = t2;
            c2.Trainer = t1;
            c3.Trainer = t1;
            c4.Trainer = t3;
            c5.Trainer = t4;
            c6.Trainer = t5;


            //-----------------Assign assignment to course
            c1.Assignments = new List<Assignment> { a1, a2, a3 };
            c2.Assignments = new List<Assignment> { a5, a10, a11 };
            c3.Assignments = new List<Assignment> { a4, a12, a13 };
            c4.Assignments = new List<Assignment> { a8, a17, a18 };
            c5.Assignments = new List<Assignment> { a6, a7, a16 };
            c6.Assignments = new List<Assignment> { a9, a14, a15 };

            //-----------------Assign student to course
            s1.Courses = new List<Course> { c5, c2, c6 };
            s2.Courses = new List<Course> { c4, c1 };
            s3.Courses = new List<Course> { c6, c2 };
            s4.Courses = new List<Course> { c1, c5, c3 };
            s5.Courses = new List<Course> { c2, c4 };
            s6.Courses = new List<Course> { c3, c2, c6 };
            s7.Courses = new List<Course> { c3, c1 };
            s8.Courses = new List<Course> { c4, c3 };
            s9.Courses = new List<Course> { c5, c1, c6 };
            s10.Courses = new List<Course> { c2, c4 };
            s11.Courses = new List<Course> { c5, c3 };
            s12.Courses = new List<Course> { c4, c1, c6 };
            s13.Courses = new List<Course> { c5, c3 };
            s14.Courses = new List<Course> { c1, c2 };
            s15.Courses = new List<Course> { c5, c4, c6 };

            //StudentCourse sc1 = new StudentCourse()  { /*Onoma = s1.StudentId + c1.CourseId + "1",*/ Student = s1, Course = c1 };
            // StudentCourse sc2 = new StudentCourse()  {/*Onoma = s1.StudentId + c2.CourseId + "2",*/ Student = s1, Course = c2 };
            // StudentCourse sc3 = new StudentCourse()  {/*Onoma = s2.StudentId + c4.CourseId + "3",*/ Student = s2, Course = c4 };
            //StudentCourse sc4 = new StudentCourse()  { /*Onoma = s2.StudentId + c1.CourseId + "4",*/Student = s2, Course = c1 };
            // StudentCourse sc5 = new StudentCourse()  {/*Onoma = s3.StudentId + c6.CourseId + "5",*/ Student = s3, Course = c6 };
            //StudentCourse sc6 = new StudentCourse()  { /*Onoma = s3.StudentId + c2.CourseId + "6",*/ Student = s3, Course = c2 };
            // StudentCourse sc7 = new StudentCourse()  {/*Onoma = s4.StudentId + c1.CourseId + "7",*/ Student = s4, Course = c1 };
            //StudentCourse sc8 = new StudentCourse()  { /*Onoma = s4.StudentId + c5.CourseId + "8",*/ Student = s4, Course = c5 };
            // StudentCourse sc9 = new StudentCourse()  {/*Onoma = s4.StudentId + c3.CourseId + "9",*/ Student = s4, Course = c3 };
            //StudentCourse sc10 = new StudentCourse() { /*Onoma = s5.StudentId + c2.CourseId + "10",*/Student = s5, Course = c2 };
            // StudentCourse sc11 = new StudentCourse() {/*Onoma = s6.StudentId + c3.CourseId + "11",*/Student = s6, Course = c3 };
            //StudentCourse sc12 = new StudentCourse() { /*Onoma = s7.StudentId + c3.CourseId + "12",*/Student = s7, Course = c3 };
            // StudentCourse sc13 = new StudentCourse() {/*Onoma = s7.StudentId + c1.CourseId + "13",*/ Student = s7, Course = c1 };
            //StudentCourse sc14 = new StudentCourse() { /*Onoma = s8.StudentId + c4.CourseId + "14",*/ Student = s8, Course = c4 };
            // StudentCourse sc15 = new StudentCourse() {/*Onoma = s9.StudentId + c5.CourseId + "15",*/ Student = s9, Course = c5 };
            //StudentCourse sc16 = new StudentCourse() { /*Onoma = s10.StudentId + c2.CourseId + "16",*/ Student = s10, Course = c2 };
            // StudentCourse sc17 = new StudentCourse() {/*Onoma = s11.StudentId + c3.CourseId + "17",*/Student = s6, Course = c3 };
            //StudentCourse sc18 = new StudentCourse() { /*Onoma = s7.StudentId + c3.CourseId + "18",*/ Student = s7, Course = c3 };
            // StudentCourse sc19 = new StudentCourse() {/*Onoma = s7.StudentId + c1.CourseId + "19",*/ Student = s7, Course = c1 };
            //StudentCourse sc20 = new StudentCourse() { /*Onoma = s8.StudentId + c4.CourseId + "20",*/ Student = s8, Course = c4 };
            // StudentCourse sc21 = new StudentCourse() {/*Onoma = s9.StudentId + c5.CourseId + "21",*/ Student = s9, Course = c5 };
            // StudentCourse sc22 = new StudentCourse() {/* Onoma = s10.StudentId + c2.CourseId + "22,*/ Student = s10, Course = c2 };

            //StudentCourse sc1 = new StudentCourse(s1, c1) { Onoma="1"};
            //StudentCourse sc2 = new StudentCourse(s1, c2){ Onoma="2"};
            //StudentCourse sc3 = new StudentCourse(s2, c4){ Onoma="3"};
            //StudentCourse sc4 = new StudentCourse(s2, c1){ Onoma="4"};
            //StudentCourse sc5 = new StudentCourse(s3, c6){ Onoma="5"};
            //StudentCourse sc6 = new StudentCourse(s3, c2){ Onoma="6"};
            //StudentCourse sc7 = new StudentCourse(s4, c1){ Onoma="7"};
            //StudentCourse sc8 = new StudentCourse(s4, c5){ Onoma="8"};
            //StudentCourse sc9 = new StudentCourse(s4, c3) { Onoma = "9" };
            //StudentCourse sc10 = new StudentCourse(s5, c2){ Onoma="10"};
            //StudentCourse sc11 = new StudentCourse(s6, c3){ Onoma="11"};
            //StudentCourse sc12 = new StudentCourse(s7, c3){ Onoma="12"};
            //StudentCourse sc13 = new StudentCourse(s7, c1){ Onoma="13"};
            //StudentCourse sc14 = new StudentCourse(s8, c4){ Onoma="14"};
            //StudentCourse sc15 = new StudentCourse(s9, c5){ Onoma="15"};
            //StudentCourse sc16 = new StudentCourse(s10, c2){ Onoma = "16" };

            //StudentAssignment sa1 = new StudentAssignment(s1, a3);

            //StudentAssignment sa2 = new StudentAssignment(s1, a6);
            //StudentAssignment sa3 = new StudentAssignment(s1, a16);
            //StudentAssignment sa4 = new StudentAssignment(s2, a2);
            //StudentAssignment sa5 = new StudentAssignment(s2, a1);

            //StudentAssignment sa6 = new StudentAssignment(s3, a6);
            //StudentAssignment sa7 = new StudentAssignment(s3, a2);

            //StudentAssignment sa8 = new StudentAssignment(s4, a1);
            //StudentAssignment sa9 = new StudentAssignment(s4, a5);
            //StudentAssignment sa10 = new StudentAssignment(s4, a3);


            StudentAssignment sa1 = new StudentAssignment() { Student = s1, Assignment = a3    ,Course=c1        , Grade = 45 };
            StudentAssignment sa2 = new StudentAssignment() { Student = s1, Assignment = a6    ,Course=c5        , Grade = 46 };
            StudentAssignment sa3 = new StudentAssignment() { Student = s1, Assignment = a16   ,Course= c5       , Grade = 47 };
            StudentAssignment sa4 = new StudentAssignment() { Student = s2, Assignment = a5    ,Course=c2         , Grade = 48 };
            StudentAssignment sa5 = new StudentAssignment() { Student = s2, Assignment = a10   ,Course=c2         , Grade = 49 };
            StudentAssignment sa6 = new StudentAssignment() { Student = s3, Assignment = a13   ,Course=c3        , Grade = 50 };
            StudentAssignment sa7 = new StudentAssignment() { Student = s3, Assignment = a18   ,Course=c4         , Grade = 51 };
            StudentAssignment sa8 = new StudentAssignment() { Student = s4, Assignment = a15   ,Course=c6         , Grade = 52 };
            StudentAssignment sa9 = new StudentAssignment() { Student = s4, Assignment = a9    ,Course=c6         , Grade = 53 };
            StudentAssignment sa10 = new StudentAssignment() { Student = s5, Assignment = a2   ,Course=c1         , Grade = 54 };
            StudentAssignment sa11 = new StudentAssignment() { Student = s6, Assignment = a5   ,Course=c2         , Grade = 55 };
            StudentAssignment sa12 = new StudentAssignment() { Student = s3, Assignment = a7   ,Course=c5         , Grade = 56 };
            StudentAssignment sa13 = new StudentAssignment() { Student = s7, Assignment = a9   ,Course=c6         , Grade = 57 };
            StudentAssignment sa14 = new StudentAssignment() { Student = s8, Assignment = a12  ,Course=c3         , Grade = 58 };
            StudentAssignment sa15 = new StudentAssignment() { Student = s10, Assignment = a6  ,Course=c5         , Grade = 59 };
            StudentAssignment sa16 = new StudentAssignment() { Student = s11, Assignment = a9  ,Course=c6         , Grade = 60 };
            StudentAssignment sa17 = new StudentAssignment() { Student = s10, Assignment = a8  ,Course=c4         , Grade = 61 };
            StudentAssignment sa18 = new StudentAssignment() { Student = s11, Assignment = a1  ,Course=c1         , Grade = 62 };
            StudentAssignment sa19 = new StudentAssignment() { Student = s9, Assignment = a2   ,Course=c1         , Grade = 63 };
            StudentAssignment sa20 = new StudentAssignment() { Student = s7, Assignment = a5   ,Course=c2         , Grade = 64 };
            StudentAssignment sa21 = new StudentAssignment() { Student = s15, Assignment = a18 ,Course=c4         , Grade = 65 };
            StudentAssignment sa22 = new StudentAssignment() { Student = s20, Assignment = a11 ,Course=c2         , Grade = 66 };
            StudentAssignment sa23 = new StudentAssignment() { Student = s25, Assignment = a3  ,Course=c1         , Grade = 67 };



            context.Students.AddOrUpdate(x => x.LastName, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s11, s12, s13, s14, s15,
                s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30, s31,s32,s33,s34,s35);
            context.Assignments.AddOrUpdate(x => x.Title, a1, a2, a3, a4, a5, a6, a7, a8, a9,a10,a11,a12,a13,a14,a15,a16,a17,a18);
            context.Trainers.AddOrUpdate(x => x.LastName, t1, t2, t3, t4, t5);
            context.Courses.AddOrUpdate(x => x.Title, c1, c2, c3, c4, c5, c6);
            // context.StudentCourses.AddOrUpdate(x=>x.Onoma, sc1, sc2, sc3, sc4, sc5, sc6, sc7, sc8, sc9, sc10, sc11, sc12, sc13, sc14, sc15, sc16);
            
           context.StudentAssignments.AddOrUpdate(x => x.Grade, sa1,sa2,sa3,sa4,sa5,sa6,sa7,sa8,sa9,sa10,sa11,sa12, sa13,sa14,sa15,sa16, sa17, sa18, sa19, sa20, sa21,
                 sa22, sa23);
            
            context.SaveChanges();

        }
    }
}
