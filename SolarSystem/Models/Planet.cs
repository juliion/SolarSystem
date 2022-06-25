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
        public float DistanceFromSun { get; set; }
        [Required]
        public float Diameter { get; set; }
        [Required]
        public float YearLength { get; set; }
        [Required]
        public float DayLength { get; set; }
        public string PhotoPath { get; set; }
        public string DocPath { get; set; }
        public int StarId { get; set; }
        [ForeignKey("StarId")]
        public virtual Star Star { get; set; }
        public virtual List<Satellite> Satellites { get; set; }

    }
}
