using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medic
{
    public partial class gVars
    {
        public static Entities entities = new Entities();
    }
    public partial class Doctors
    {
        public override string ToString()
        {
            return FullName;
        }
    }
    public partial class Patients
    {
        public override string ToString()
        {
            return FullName;
        }
    }
    public partial class Appointments
    {
        public override string ToString()
        {
            return $"{AppointmentDate}";
        }
    }
}
