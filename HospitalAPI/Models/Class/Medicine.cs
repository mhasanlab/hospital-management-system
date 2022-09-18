using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Medicine
    {
        [Key]
        public int MedicineId { get; set; }
        [Required, StringLength(70), Display(Name = "Medicine Name")]
        public string MedicineName { get; set; }
        [Required, StringLength(50), Display(Name = "Type")]
        public string MedicineType { get; set; }
        [StringLength(150), Display(Name = "Description")]
        public string MedicineDes { get; set; }
        [Column(TypeName ="money"),DisplayFormat(DataFormatString ="{0.00}"), Display(Name = "Price")]
        public decimal MedicinePrice { get; set; }

        // Nev
        public virtual ICollection<MedicineReport> MedicineReports { get; set; }
        public virtual ICollection<PrescribedMed> PrescribedMeds { get; set; }
    }
}
