using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Required,StringLength(70), Display(Name ="Supplier Name")]
        public string SupplierName { get; set; }
        [Required, StringLength(15)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [Required, StringLength(200)]
        public string Address { get; set; }
        // Nev
        public virtual ICollection<MedicineReport> MedicineReports { get; set; }
    }
}
