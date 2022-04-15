using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLabs.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public ICollection<Patient> Patients { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
    }
}
