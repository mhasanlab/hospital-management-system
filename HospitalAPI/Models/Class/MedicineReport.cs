using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class MedicineReport
    {
        [Key]
        public int MedReportId { get; set; }
        //Foreign Key
        [Required, ForeignKey("Medicine")]
        public int MedicineId { get; set; }
        //Foreign Key
        [Required, ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public double Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirDate { get; set; }
        public bool Availability { get; set; }

        //Nev
        public virtual Medicine Medicine { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
