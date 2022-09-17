using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialist { get; set; }

        // Nev
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<PatientReport> PatientReports { get; set; }
    }
}
