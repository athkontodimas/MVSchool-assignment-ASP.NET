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
    public class StudentRepository
    {
        MyDatabase db = new MyDatabase();

        //GetAll
        public IEnumerable<Student> GetAll()
        {
           
            return db.Students.ToList();

        }
        //GetId
        public Student GetById(int? id)
        {

            return db.Students.Find(id);
        }
        //Insert
        public void Insert(Student student)
        {


            db.Entry(student).State = EntityState.Added;
            db.SaveChanges();

        }

        //Update
        public void Update(Student student)
        {

            db.Entry(student).State = EntityState.Modified;
            db.SaveChanges();

        }
        //Delete
        public void Delete(Student student)
        {
            db.Entry(student).State = EntityState.Deleted;
            db.SaveChanges();
        }

        //private bool disposed = false;
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

    }
}
