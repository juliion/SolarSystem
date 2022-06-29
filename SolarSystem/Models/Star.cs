using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolarSystem.Models
{
    public class Star
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public double Age { get; set; }
        [Required]
        public double Diameter { get; set; }
        [Required]
        [MaxLength(50)]
        public string Mass { get; set; }
        [Required]
        public double AbsoluteMagnitude { get; set; }
        [Required]
        public double SurfaceTemp { get; set; }
        public string PhotoPath { get; set; }
        public string DocPath { get; set; }

        public virtual List<Planet> Planets { get; set; }

    }
}
