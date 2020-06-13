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
    public class TrainerRepository
    {
       
            MyDatabase db = new MyDatabase();

             //GetAll
             public IEnumerable<Trainer> GetAll()
            {
               
            return db.Trainers.ToList();//.Include(x => x.Courses);

            }
            //GetId
            public Trainer GetById(int? id)
            {

                return db.Trainers.Find(id);
            }
            //Insert
            public void Insert(Trainer trainer)//Add
            {

                db.Entry(trainer).State = EntityState.Added;
                db.SaveChanges();

            }

            //Update
            public void Update(Trainer trainer)
            {

                db.Entry(trainer).State = EntityState.Modified;
                db.SaveChanges();

            }
            //Delete
            public void Delete(Trainer trainer)
            {
                db.Entry(trainer).State = EntityState.Deleted;
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
