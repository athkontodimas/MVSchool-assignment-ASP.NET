using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVSchool.Services;
using MVSchool.Entities;
using MVSchool.Database;
using System.Net;
using PagedList;

namespace MVSchool.Web.Controllers
{
    public class TrainerController : Controller
    {
        
        // GET: Trainers
        public ActionResult ShowTrainers(string sortOrder, string searchFirstName, string searchLastName, string searchSubject,int? page, int? itemsPerPage)
        {
            ViewBag.FirstNameSort = String.IsNullOrEmpty(sortOrder) ? "FirstNameDesc" : "";
            ViewBag.LastNameSort = sortOrder== "LastNameAsc" ? "LastNameDesc" : "LastNameAsc";
            ViewBag.SubjectSort = sortOrder == "SubjAsc" ? "SubjDesc" : "SubjAsc";
            ViewBag.SortOrder = sortOrder;
            
            ViewBag.SearchdFirstName = searchFirstName;
            ViewBag.SearchedLastName = searchLastName;
            ViewBag.SearchedSubject = searchSubject;

            ViewBag.CurrentPage = page;
            ViewBag.PageSize = itemsPerPage;

           
            
            TrainerRepository trainerRepository = new TrainerRepository();
            var trainers = trainerRepository.GetAll();


            // ------------------------ Ταξινόμηση φθίνουσα/αύξουσα ----------------------------------------------------
            switch (sortOrder)
            {
                case "FirstNameDesc": trainers = trainers.OrderByDescending(x => x.FirstName);
                    break;
                case "LastNameAsc":
                    trainers = trainers.OrderBy(x => x.LastName);
                    break;
                case "LastNameDesc":
                    trainers = trainers.OrderByDescending(x => x.LastName);
                    break;
                case "SubjAsc":
                    trainers = trainers.OrderBy(x => x.Subject);
                    break;
                case "SubjDesc":
                    trainers = trainers.OrderByDescending(x => x.Subject);
                    break;


                default: trainers = trainers.OrderBy(x => x.FirstName);
                    break;
            }
            //---------------------------------- Φιλτράρισμα ------------------------------------------
            if (!string.IsNullOrWhiteSpace(searchFirstName))
            {
                trainers = trainers.Where(x => x.FirstName.ToUpper().Contains(searchFirstName.ToUpper()));
            }
            
            if (!string.IsNullOrWhiteSpace(searchLastName))
            {
                trainers = trainers.Where(x => x.LastName.ToUpper().Contains(searchLastName.ToUpper()));
            }
            
            if (!(searchSubject is null)) 
            {
                trainers = trainers.Where(x => x.Subject.ToUpper().Contains(searchSubject.ToUpper()));
            }

            int pageSize = itemsPerPage ?? 5;
            int pageNum = page ?? 1;


            return View(trainers.ToPagedList(pageNum, pageSize));
        }
        public ActionResult Details(int? id)
        {
            TrainerRepository trainerRepository = new TrainerRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var trainer=  trainerRepository.GetById(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        public ActionResult ShowTrainersPerCourse()
        {
            TrainerRepository trainerRepository = new TrainerRepository();
            var trainers = trainerRepository.GetAll();
            return View(trainers);
        }

    }
}