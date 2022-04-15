using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLabs.Models
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Patient> Patients { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
