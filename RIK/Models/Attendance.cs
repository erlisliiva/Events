using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RIK.Models
{
    public class Attendance
    {
        public PersonModel PersonModel { get; set; }
        public EventModel EventModel { get; set; }
    }
}