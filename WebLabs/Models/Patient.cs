using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLabs.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symptoms { get; set; }
        public int? RoomId { get; set; }
        public Room Room { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
    }
}
