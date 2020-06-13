using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVSchool.Database;
using MVSchool.Entities;
using System.Data.Entity;

namespace MVSchool.Services
{
    public class StudentCourseRepository
    {

        MyDatabase db = new MyDatabase();
        StudentCourseRepository studentCourseRepository = new StudentCourseRepository();
        //GetAll
        //GetAll
        public IEnumerable<StudentCourse> GetAll()
        {
            var studentCourse = studentCourseRepository.GetAll();
            return studentCourse;

        }
        //GetId
        public Course GetById(int? id)
        {

            return db.Courses.Find(id);
        }
        //Insert
        public void Insert(Course trainer)
        {


            db.Entry(trainer).State = EntityState.Added;
            db.SaveChanges();

        }

        //Update
        public void Update(Course trainer)
        {

            db.Entry(trainer).State = EntityState.Modified;
            db.SaveChanges();

        }
        //Delete
        public void Delete(Course trainer)
        {
            db.Entry(trainer).State = EntityState.Deleted;
            db.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}
