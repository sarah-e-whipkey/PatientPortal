using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientPortal.Models
{
    public class PatientAccount
    {
        [Required(ErrorMessage ="First Name required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender must be selected")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Date of birth required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Social Security Number required")]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$)", ErrorMessage ="Valid SSN required")]
        public string SocialSecurityNumber { get; set; }

        [Required(ErrorMessage = "Race required")]
        public string Race { get; set; }

        [Required(ErrorMessage = "Ethnicity required")]
        public string Ethnicity { get; set; }

        [Required(ErrorMessage = "Address required")]
        public string Address { get; set; }

        [Required(ErrorMessage ="Phone Number required")]
        [Phone(ErrorMessage ="Valid Phone Number required")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Email Address required")]
        [EmailAddress(ErrorMessage ="Valid Email Address required")]
        public string Email { get; set; }
    }
}
