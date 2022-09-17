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
        public string RoomType { get; set; }
        public decimal RoomCharge { get; set; }
        public string RoomLocation { get; set; }
        public bool Availability { get; set; }

        // Nev
        public virtual ICollection<Addmission> Addmissions { get; set; }
    }
}
