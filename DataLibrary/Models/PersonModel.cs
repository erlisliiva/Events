using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class PersonModel
    {
        public int PersonId { get; set; }
        public int PersonFK { get; set; }
        public bool IsBusiness { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalCode { get; set; }
        public string PayingMethod { get; set; }
        public string Info { get; set; }
    }
}
