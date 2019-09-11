using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chappel_MIS4200.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime appointmentDate { get; set; }
        public int petID { get; set; }
        public Pet petName { get; set; }

    }
}