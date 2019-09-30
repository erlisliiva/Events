using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RIK.Models
{
    [Table("Persons")]
    public class PersonModel
    {
        [Key]
        public int PersonId { get; set; }

        public bool IsBusiness { get; set; } = true;

        [Required]
        [MaxLength(50, ErrorMessage = "Name is too long!")]
        [Display(Name = "Eesnimi:")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name is too long!")]
        [Display(Name = "Perenimi:")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Isikukood:")]
        public string PersonalCode { get; set; }

        [Required]
        [Display(Name = "Maksmisviis:")]
        public string PayingMethod { get; set; }

        public string Info { get; set; }

        public EventModel EventModel { get; set; }
    }
}