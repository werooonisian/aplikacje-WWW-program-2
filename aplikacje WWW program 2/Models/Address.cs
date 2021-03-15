using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace aplikacje_WWW_program_2.Models
{
    public class Address 
    {
        [Display(Name = "Twoja ulubiona ulica")]
        [Required(ErrorMessage ="Pole jest obowiązkowe")]
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
    }
}
