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

        [Required, StringLength(100), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, StringLength(100), Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Specialist { get; set; }
        //nev
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
