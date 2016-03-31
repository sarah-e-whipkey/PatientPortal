using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientPortal.Models
{
    public class VitalSigns
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public double BMI { get
            {
                return Weight / Math.Pow(Height, 2) * 703;
            } }
    }
}
