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
    public class AssignmentRepository
    {
        MyDatabase db = new MyDatabase();

       
        //GetAll
        public IEnumerable<Assignment> GetAll()
        {
           
            return db.Assignments.ToList();

        }
        //GetId
        public Assignment GetById(int? id)
        {

            return db.Assignments.Find(id);
        }
        //Insert
        public void Insert(Assignment assignment)
        {


            db.Entry(assignment).State = EntityState.Added;
            db.SaveChanges();

        }

        //Update
        public void Update(Assignment assignment)
        {

            db.Entry(assignment).State = EntityState.Modified;
            db.SaveChanges();

        }
        //Delete
        public void Delete(Assignment assignment)
        {
            db.Entry(assignment).State = EntityState.Deleted;
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
