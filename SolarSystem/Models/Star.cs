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
        public float Age { get; set; }
        [Required]
        public float Diameter { get; set; }
        [Required]
        public float Mass { get; set; }
        [Required]
        public float SurfaceTemp { get; set; }
        public string PhotoPath { get; set; }
        public string DocPath { get; set; }

        public virtual List<Planet> Planets { get; set; }

    }
}
