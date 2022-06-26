using System;
using System.Data.Entity;
using System.Linq;
using SolarSystem.Models;

namespace SolarSystem.Context
{
    public class SolarSystemContext : DbContext
    {
        public SolarSystemContext()
            : base("name=SolarSystemContext")
        {
        }

        public virtual DbSet<Star> Stars { get; set; }
        public virtual DbSet<Planet> Planets { get; set; }
        public virtual DbSet<Satellite> Satellites { get; set; }
    }
}