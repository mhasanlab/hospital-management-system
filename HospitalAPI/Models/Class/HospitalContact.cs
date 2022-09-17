using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class HospitalContact
    {
        [Key]
        public int ContactId { get; set; }
        [Required, StringLength(50), Display(Name = "Contact Type")]
        public int ContactType { get; set; }

        //Foreign Key
        [Required, ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        [Required, StringLength(15), Display(Name = "Phone")]
        public string Phone { get; set; }
        [Required, StringLength(50), Display(Name = "Email")]
        public string Email { get; set; }

        //Nev
        public virtual Hospital Hospital { get; set; }
    }
}
