using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        //Foreign Key
        [Required, ForeignKey("Patient")]
        public int PatientId { get; set; }
        public decimal? DocCharge { get; set; }
        public decimal? MedCharge { get; set; }
        public decimal? RoomCharge { get; set; }
        public decimal? OperationCharge { get; set; }
        public decimal? NursingCharge { get; set; }
        public decimal? LabCharge { get; set; }
        public decimal? Advance { get; set; }

        //Nev
        public virtual Patient Patient { get; set; }
    }
}
