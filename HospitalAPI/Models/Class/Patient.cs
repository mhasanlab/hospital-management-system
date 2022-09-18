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
        
        [Required, StringLength(100),Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, StringLength(100), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required,Display(Name = "Patient Gender")]
        public string Gender { get; set; }
        [Required,StringLength(300),Display(Name ="Patient Address")]
        public string Address { get; set; }
        [Required,Display(Name ="Patient City")]
        public string City { get; set; }
        [Required, Column(TypeName = "date"),Display(Name ="Date Of Brith"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string DOB { get; set; }
        
        [Required, StringLength(12), Display(Name = "Patient Phone No")]
        public string Phone { get; set; }
        
        [Required, StringLength(50)]
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
