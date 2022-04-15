using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLabs.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
    }
}
