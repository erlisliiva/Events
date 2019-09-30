using RIK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BusinessLogic.PersonProcessor;
using static DataLibrary.BusinessLogic.EventProcessor;


namespace RIK.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PersonCreation()
        {
            return View();
        }

        public ActionResult ViewParticipants()
        {
            ViewBag.Message = "Person List";

            var data = LoadPersons();
            List<PersonModel> persons = new List<PersonModel>();
            foreach (var item in data)
            {
                persons.Add(new PersonModel
                {
                    PersonId = item.PersonId,
                    IsBusiness = item.IsBusiness,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    PersonalCode = item.PersonalCode,
                    PayingMethod = item.PayingMethod,
                    Info = item.Info
             
                });
            }
            return View(persons);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PersonCreation(PersonModel item, int id)
        {
            var data = LoadEventById(id);

            EventModel eventModel = new EventModel();

            foreach (var collection in data)
            {
                eventModel = new EventModel
                {
                    EventName = collection.EventName,
                    StartDate = collection.StartDate,
                    Location = collection.Location,
                    Info = collection.Info

                };
            }


            if (ModelState.IsValid)
            {
                
                    CreatePerson(
                   eventModel.Id,
                   item.IsBusiness,
                   item.FirstName,
                   item.LastName,
                   item.PersonalCode,
                   item.PayingMethod,
                   item.Info
                   );
                
                return RedirectToAction("ViewParticipants");
            }
            return View();
        }

        



    }
}