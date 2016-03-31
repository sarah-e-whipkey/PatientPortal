using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace PatientPortal.Models
{
    public class Dashboard {

        public string Welcome { get; set; }

        public Dashboard()
        {
            var patientName = "";
            var sb = new StringBuilder();

            sb.AppendFormat("Hello {0}!", patientName);
            Welcome = @"Appointment requests made through this portal are for no sooner than 1 day in advance. 
                        If you need an appointment sooner than 1 day, please call the office.";

        }

    }

    
}
