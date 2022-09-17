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
        public string MedicineName { get; set; }
        public string MedicineType { get; set; }
        public string MedicineDes { get; set; }
        public decimal MedicinePrice { get; set; }

        // Nev
        public virtual ICollection<MedicineReport> MedicineReports { get; set; }
        public virtual ICollection<PrescribedMed> PrescribedMeds { get; set; }
    }
}
