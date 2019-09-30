using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RIK.Models
{
    public class EventModel
    {
        
        public int Id { get; set; }

        [Required]
        public string EventName { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime StartDate { get; set; }
        [Required]
        public string Location { get; set; }
        public string Info { get; set; }

        private ICollection<PersonModel> personModels;

        public ICollection<PersonModel> GetPersonModels()
        {
            if (personModels == null)
            {
                personModels = new List<PersonModel>();
            }
            return personModels;
        }

        public void SetPersonModels(ICollection<PersonModel> value)
        {
            personModels = value;
        }
        public void Add(PersonModel personModel)
        {

        }


    }
}