using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientPortal.Models
{
    public class UserAccount: PatientAccount
    {
        public string Password { get; set; }
    }
}
