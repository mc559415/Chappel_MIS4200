using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Chappel_MIS4200.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        [Display(Name = "Vet Name")]
        public string vetName { get; set; }
        [Display(Name = "Vet Phone")]
        public string vetPhone { get; set; }
        [Display(Name = "Vet Email")]
        public string vetEmail { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}