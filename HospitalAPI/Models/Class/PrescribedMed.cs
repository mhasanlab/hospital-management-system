using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class PrescribedMed
    {
        [Key]
        public int PrescMedId { get; set; }
        //Foreign Key
        [Required, ForeignKey("Patient")]
        public int PatientId { get; set; }
        //Foreign Key
        [Required, ForeignKey("Medicine")]
        public int MedicineId { get; set; }

        //Nev
        public virtual Medicine Medicine { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
