using RIK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.EventProcessor;
using Microsoft.AspNet;
using DataLibrary.BusinessLogic;
using static DataLibrary.BusinessLogic.PersonProcessor;



namespace RIK.Controllers
{
    public class EventController : Controller
    {

        public ActionResult EventCreation()
        {
            return View();
        }

        //Main
        public ActionResult ViewEvents()
        {
            ViewBag.Message = "Events List";

            var data = LoadEvents();
            List<EventModel> events = new List<EventModel>();
            foreach (var item in data)
            {
                events.Add(new EventModel
                {
                    Id = item.Id,
                    EventName = item.EventName,
                    StartDate = item.StartDate,
                    Location = item.Location,
                    Info = item.Info
                });
            }

            return View(events);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EventCreation(EventModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateEvent(
                    model.EventName,
                    model.StartDate,
                    model.Location,
                    model.Info);
                return RedirectToAction("ViewEvents");
            }
            return View();
        }

        //GET one 
        public ActionResult ViewEventParticipants(int id, PersonModel personModel)
        {

            ViewBag.Message = "Events List";

            var data = LoadEventById(id);

            List<EventModel> events = new List<EventModel>();

            foreach (var item in data)
            {
                events.Add( new EventModel
                {
                    EventName = item.EventName,
                    StartDate = item.StartDate,
                    Location = item.Location,
                    Info = item.Info
                    
                });
            }
            return View(events);
        }



    }
}