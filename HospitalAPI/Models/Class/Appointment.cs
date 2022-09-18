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

        [Key]
        public int AppointmentId { get; set; }
        [Required,Display(Name ="Appoinment Type")]
        public string Type { get; set; }
        [Required, Column(TypeName = "date"), Display(Name = "Appointment Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AppointmentDate { get; set; }

        [Required, Column(TypeName = "date"), Display(Name = "Appointment Time"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AppointmentTime { get; set; }
        [Required,StringLength(300),Display(Name = "Appointment Description")]
        public string AppointmentDes { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        //Nev
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
