using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Appointment
    {
<<<<<<< HEAD
        [Key]
        public int AppointmentId { get; set; }
        //Foreign Key
        [Required, ForeignKey("Patient")]
        public int PatientId { get; set; }
        public string Type { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public string AppointmentDes { get; set; }
        //Foreign Key
        [Required, ForeignKey("Doctor")]
=======
        public int AppointmentId { get; set; }
        public string Type { get; set; }
        [Required, Column(TypeName = "date"), DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]

        public DateTime AppointmentDate { get; set; }

        [Required, Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime AppointmentTime { get; set; }

        public string AppointmentDes { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        [ForeignKey("Doctor")]
>>>>>>> c02be5fe4259d06967c5a3aa991837aac4cf4c5b
        public int DoctorId { get; set; }

        //Nev
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
