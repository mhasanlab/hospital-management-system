using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Lab
    {
        [Key]
        public int LabNo { get; set; }
        //Foreign Key
        [Required, ForeignKey("MedicalTest")]
        public int MedicalTestCode { get; set; }
        [Required,DataType(DataType.Date),Display(Name ="Test Date")]
        public DateTime TestDate { get; set; }
        //Foreign Key
        [Required, ForeignKey("Patient")]
        public int PatientId { get; set; }
        [Required,Range(3,10)]
        public decimal Height { get; set; }
        [Required,StringLength(3,ErrorMessage = "Weight can't be more than 3 Digit")]
        public decimal Weight { get; set; }
        [Required, Display(Name = "Blood Pressure")]
        public decimal BloodPressure { get; set; }
        [Required, Range(2, 4), Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }

        //Nev
        public virtual MedicalTest MedicalTest { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
