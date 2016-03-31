using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientPortal.Models
{
    public class Doctors
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public int IdNumber { get; set; }
        public int Password { get; set; }


        public Doctors()
        {
            MDs = new List<Doctors>();
            MDs.Add(new Doctors { FirstName = "Henry", LastName = "Thomas", Specialty = "Primary Care Physician", IdNumber = 2100, Password = 0012 });
            MDs.Add(new Doctors { FirstName = "Jenny", LastName = "Lee", Specialty = "Cardiologist", IdNumber = 3343, Password = 3433 });
            MDs.Add(new Doctors { FirstName = "Jane", LastName = "Doe", Specialty = "ENT", IdNumber = 1245, Password = 5421 });

        }

        public List<Doctors> MDs { get; set; }

        public Doctors Login(int Id, int Pw)
        {

            foreach (var doc in MDs)
            {
                if (Id == doc.IdNumber && Pw == doc.Password)
                {

                    return doc;
                }

            }
            return null;
        }
    }
}