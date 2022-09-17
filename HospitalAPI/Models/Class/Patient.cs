using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime Dob { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // Nev
        public virtual ICollection<Addmission> Addmissions { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Lab> Labs { get; set; }
        public virtual ICollection<PatientReport> PatientReports { get; set; }
        public virtual ICollection<PrescribedMed> PrescribedMeds { get; set; }
    }
}
