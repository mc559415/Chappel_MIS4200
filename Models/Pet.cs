using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chappel_MIS4200.Models
{
    public class Pet
    {
        public int petID { get; set; }
        public string petName { get; set; }
        public int petWeight { get; set; }
        public string petType { get; set; }
        public string ownerPhone { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}