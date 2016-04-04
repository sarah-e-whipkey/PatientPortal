using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientPortal.Models
{
    public class MedRecords
    {
        [Required(ErrorMessage ="Conditions required")]
        public string Conditions { get; set; }

        public string Allergies { get; set; }

        [Required(ErrorMessage ="Social history required")]
        public string SocialHistory { get; set; }
        

    }
}
