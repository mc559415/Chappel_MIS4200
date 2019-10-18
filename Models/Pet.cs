using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Chappel_MIS4200.Models
{
    public class Pet
    {
        public int petID { get; set; }
        [Display(Name = "Pet Name")]
        public string petName { get; set; }
        [Display(Name = "Pet Weight")]
        public int petWeight { get; set; }
        [Display(Name = "Pet Type")]
        public string petType { get; set; }
        [Display(Name = "Owner Phone #")]
        public string ownerPhone { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}