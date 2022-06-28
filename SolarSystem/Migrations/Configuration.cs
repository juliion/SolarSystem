namespace SolarSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SolarSystem.Models;
    using SolarSystem.Context;
    internal sealed class Configuration : DbMigrationsConfiguration<SolarSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SolarSystemContext context)
        {
            context.Stars.AddOrUpdate(star => star.Id,
                 new Star()
                 { 
                     Id = 1,
                     Name = "Сонце",
                     Age = 4.6,
                     Diameter = 1392700,
                     Mass = "2 * 10^30",
                     AbsoluteMagnitude = -26.74,
                     SurfaceTemp = 5505,
                     PhotoPath = @"..\..\Images\SunPhoto.jpg",
                     DocPath = @"..\..\Docs\SunDoc.xaml"
                 }
              );
            context.Planets.AddOrUpdate(planet => planet.Id,
                new Planet() 
                {
                    Id = 1,
                    Name = "Меркурій",
                    DistanceFromSun = 58,
                    Diameter = 4879,
                    YearLength = 88,
                    DayLength = 1407,
                    PhotoPath = @"..\..\Images\MercuryPhoto.jpg",
                    DocPath = @"..\..\Docs\MercuryDoc.xaml",
                    StarId = 1
                },
                new Planet()
                {
                    Id = 2,
                    Name = "Венера",
                    DistanceFromSun = 108,
                    Diameter = 12100,
                    YearLength = 225,
                    DayLength = 2802,
                    PhotoPath = @"..\..\Images\VenusPhoto.jpg",
                    DocPath = @"..\..\Docs\VenusDoc.xaml",
                    StarId = 1
                },
                 new Planet()
                 {
                     Id = 3,
                     Name = "Земля",
                     DistanceFromSun = 150,
                     Diameter = 12756,
                     YearLength = 365,
                     DayLength = 24,
                     PhotoPath = @"..\..\Images\EarthPhoto.jpg",
                     DocPath = @"..\..\Docs\EarthDoc.xaml",
                     StarId = 1
                 },
                 new Planet()
                 {
                     Id = 4,
                     Name = "Марс",
                     DistanceFromSun = 228,
                     Diameter = 6792,
                     YearLength = 687,
                     DayLength = 24.6,
                     PhotoPath = @"..\..\Images\MarsPhoto.jpg",
                     DocPath = @"..\..\Docs\MarsDoc.xaml",
                     StarId = 1
                 },
                 new Planet()
                 {
                     Id = 5,
                     Name = "Юпітер",
                     DistanceFromSun = 778.5,
                     Diameter = 142984,
                     YearLength = 4300,
                     DayLength = 10,
                     PhotoPath = @"..\..\Images\JupiterPhoto.jpg",
                     DocPath = @"..\..\Docs\JupiterDoc.xaml",
                     StarId = 1
                 },
                 new Planet()
                 {
                     Id = 6,
                     Name = "Сатурн",
                     DistanceFromSun = 1427,
                     Diameter = 120420,
                     YearLength = 11000,
                     DayLength = 10.5,
                     PhotoPath = @"..\..\Images\SaturnPhoto.jpg",
                     DocPath = @"..\..\Docs\SaturnDoc.xaml",
                     StarId = 1
                 },
                 new Planet()
                 {
                     Id = 7,
                     Name = "Уран",
                     DistanceFromSun = 2860,
                     Diameter = 51300,
                     YearLength = 31000,
                     DayLength = 17.2,
                     PhotoPath = @"..\..\Images\UranusPhoto.jpg",
                     DocPath = @"..\..\Docs\UranusDoc.xaml",
                     StarId = 1
                 },
                 new Planet()
                 {
                     Id = 8,
                     Name = "Нептун",
                     DistanceFromSun = 4500,
                     Diameter = 49500,
                     YearLength = 60200,
                     DayLength = 18,
                     PhotoPath = @"..\..\Images\NeptunePhoto.jpg",
                     DocPath = @"..\..\Docs\NeptuneDoc.xaml",
                     StarId = 1
                 }
              );
            context.Moons.AddOrUpdate(moon => moon.Id,
                new Moon() 
                {
                    Id = 1,
                    Name = "Місяць",
                    Age = 4.5,
                    Diameter = 3474.8,
                    ApparentMagnitude = -12.74,
                    PhotoPath = @"..\..\Images\MoonPhoto.jpg",
                    DocPath = @"..\..\Docs\MoonDoc.xaml",
                    PlanetId = 3
                },
                new Moon()
                {
                    Id = 2,
                    Name = "Фобос",
                    Age = 4.5,
                    Diameter = 22.533,
                    ApparentMagnitude = 11.8,
                    PhotoPath = @"..\..\Images\PhobosPhoto.jpg",
                    DocPath = @"..\..\Docs\PhobosDoc.xaml",
                    PlanetId = 4
                },
                new Moon()
                {
                    Id = 3,
                    Name = "Деймос",
                    Age = 4.5,
                    Diameter = 12.4,
                    ApparentMagnitude = 12.89,
                    PhotoPath = @"..\..\Images\DeimosPhoto.jpg",
                    DocPath = @"..\..\Docs\DeimosDoc.xaml",
                    PlanetId = 4
                },
                new Moon()
                {
                    Id = 4,
                    Name = "Іо",
                    Age = 1,
                    Diameter = 3643.2,
                    ApparentMagnitude = 5.02,
                    PhotoPath = @"..\..\Images\ІоPhoto.jpg",
                    DocPath = @"..\..\Docs\ІоDoc.xaml",
                    PlanetId = 5
                },
                new Moon()
                {
                    Id = 5,
                    Name = "Європа",
                    Age = 4.5,
                    Diameter = 3121.6,
                    ApparentMagnitude = 5.29,
                    PhotoPath = @"..\..\Images\EuropePhoto.jpg",
                    DocPath = @"..\..\Docs\EuropeDoc.xaml",
                    PlanetId = 5
                },
                new Moon()
                {
                    Id = 6,
                    Name = "Ганімед",
                    Age = 4.5,
                    Diameter = 5268.2,
                    ApparentMagnitude = 4.61,
                    PhotoPath = @"..\..\Images\GanymedePhoto.jpg",
                    DocPath = @"..\..\Docs\GanymedeDoc.xaml",
                    PlanetId = 5
                },
                new Moon()
                {
                    Id = 7,
                    Name = "Титан",
                    Age = 4,
                    Diameter = 5149.5,
                    ApparentMagnitude = 8.2,
                    PhotoPath = @"..\..\Images\TitaniumPhoto.jpg",
                    DocPath = @"..\..\Docs\TitaniumDoc.xaml",
                    PlanetId = 6
                },
                new Moon()
                {
                    Id = 8,
                    Name = "Енцелад",
                    Age = 1,
                    Diameter = 504.2,
                    ApparentMagnitude = 11.7,
                    PhotoPath = @"..\..\Images\EnceladusPhoto.jpg",
                    DocPath = @"..\..\Docs\EnceladusDoc.xaml",
                    PlanetId = 6
                },
                new Moon()
                {
                    Id = 9,
                    Name = "Міранда",
                    Age = 3.5,
                    Diameter = 471.6,
                    ApparentMagnitude = 15.8,
                    PhotoPath = @"..\..\Images\MirandaPhoto.jpg",
                    DocPath = @"..\..\Docs\MirandaDoc.xaml",
                    PlanetId = 7
                },
                new Moon()
                {
                    Id = 10,
                    Name = "Аріель",
                    Age = 3.8,
                    Diameter = 1157.8,
                    ApparentMagnitude = 14.4,
                    PhotoPath = @"..\..\Images\ArielPhoto.jpg",
                    DocPath = @"..\..\Docs\ArielDoc.xaml",
                    PlanetId = 7
                },
                new Moon()
                {
                    Id = 11,
                    Name = "Умбріель",
                    Age = 3.5,
                    Diameter = 1169.4,
                    ApparentMagnitude = 14.5,
                    PhotoPath = @"..\..\Images\UmbrielPhoto.jpg",
                    DocPath = @"..\..\Docs\UmbrielDoc.xaml",
                    PlanetId = 7
                },
                new Moon()
                {
                    Id = 12,
                    Name = "Тритон",
                    Age = 4.5,
                    Diameter = 2706.8,
                    ApparentMagnitude = 13.47,
                    PhotoPath = @"..\..\Images\TritonPhoto.jpg",
                    DocPath = @"..\..\Docs\TritonDoc.xaml",
                    PlanetId = 8
                },
                new Moon()
                {
                    Id = 13,
                    Name = "Нереїда",
                    Age = 4.5,
                    Diameter = 340,
                    ApparentMagnitude = 19.2,
                    PhotoPath = @"..\..\Images\NereidPhoto.jpg",
                    DocPath = @"..\..\Docs\NereidDoc.xaml",
                    PlanetId = 8
                },
                new Moon()
                {
                    Id = 14,
                    Name = "Протей",
                    Age = 4.5,
                    Diameter = 420,
                    ApparentMagnitude = 19.7,
                    PhotoPath = @"..\..\Images\ProteusPhoto.jpg",
                    DocPath = @"..\..\Docs\ProteusDoc.xaml",
                    PlanetId = 8
                }
            );
        }
    }
}
