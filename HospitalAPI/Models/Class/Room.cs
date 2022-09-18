using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required,Display(Name ="Room Type")]
        public string RoomType { get; set; }
        [Required, Display(Name = "Room Charge")]
        public decimal RoomCharge { get; set; }
        [Required, Display(Name = "Room Location")]
        public string RoomLocation { get; set; }
        [Required,StringLength(5)]
        public bool Availability { get; set; }

        // Nev
        public virtual ICollection<Addmission> Addmissions { get; set; }
    }
}
