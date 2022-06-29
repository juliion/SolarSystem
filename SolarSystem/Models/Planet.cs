using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolarSystem.Models
{
    public class Planet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public double DistanceFromSun { get; set; }
        [Required]
        public double Diameter { get; set; }
        [Required]
        public double YearLength { get; set; }
        [Required]
        public double DayLength { get; set; }
        public string PhotoPath { get; set; }
        public string DocPath { get; set; }
        public int StarId { get; set; }
        [ForeignKey("StarId")]
        public virtual Star Star { get; set; }
        public virtual List<Moon> Moons { get; set; }

    }
}
