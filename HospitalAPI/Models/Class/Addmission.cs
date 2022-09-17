using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Addmission
    {
        [Key]
        public int AdmissionId { get; set; }
        //Foreign Key
        [Required, ForeignKey("Patient")]
        public int? PatientId { get; set; }
        public DateTime AdmissionDate { get; set; }
        //Foreign Key
        [Required, ForeignKey("Room")]
        public int? RoomId { get; set; }

        // Nev
        public virtual Patient Patient { get; set; }
        public virtual Room Room { get; set; }
    }
}
