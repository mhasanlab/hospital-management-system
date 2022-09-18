using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Hospital
    {
        [Key]
        public int HospitalId { get; set; }
        [Required, StringLength(150), Display(Name = "Hospital Name")]
        public string HospitalName { get; set; }
        [Required, StringLength(50), Display(Name = "Hospital Type")]
        public string HospitalType { get; set; }
        [Required, StringLength(200)]
        public string Area { get; set; }
        [Required, StringLength(50)]
        public string Road { get; set; }
        [Required, StringLength(50)]
        public string Country { get; set; }

        // Nev
        public virtual ICollection<HospitalContact> HospitalContacts { get; set; }
    }
}
