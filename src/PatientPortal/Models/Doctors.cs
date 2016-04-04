using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientPortal.Models
{
    public class Doctors
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }

        //public Doctors Login(int Id, int Pw)
        //{

        //    foreach (var doc in MDs)
        //    {
        //        if (Id == doc.Id && Pw == doc.Password)
        //        {

        //            return doc;
        //        }

        //    }
        //    return null;
        //}
    }
}