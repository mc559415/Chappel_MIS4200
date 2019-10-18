using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Chappel_MIS4200.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        [Display (Name="Appointment Date")]
        public DateTime appointmentDate { get; set; }
        public Pet petName { get; set; }

        //Link appointment and Pet
        [Display (Name ="Pet ID")]
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }


        //Link appointment and Vet
        public int vetID { get; set; }
        public virtual Vet Vet { get; set; }

    }
}