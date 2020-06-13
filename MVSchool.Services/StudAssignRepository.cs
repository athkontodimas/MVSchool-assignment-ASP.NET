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
    public class StudAssignRepository
    {
       
            MyDatabase db = new MyDatabase();


            //GetAll
            public IEnumerable<StudentAssignment> GetAll()
            {

                return db.StudentAssignments.ToList();

            }
            //GetId
            public StudentAssignment GetById(int? id)
            {

                return db.StudentAssignments.Find(id);
            }
            //Insert
            public void Insert(StudentAssignment studentassignment)
            {


                db.Entry(studentassignment).State = EntityState.Added;
                db.SaveChanges();

            }

            //Update
            public void Update(StudentAssignment studentassignment)
            {

                db.Entry(studentassignment).State = EntityState.Modified;
                db.SaveChanges();

            }
            //Delete
            public void Delete(StudentAssignment studentassignment)
            {
                db.Entry(studentassignment).State = EntityState.Deleted;
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



