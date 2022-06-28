﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using SolarSystem.Models;
using SolarSystem.Context;

namespace SolarSystem.ViewModel
{
    public class PlanetsViewModel : INotifyPropertyChanged
    {
        private readonly SolarSystemContext _context;
        private Planet _selectedPlanet;
        public ObservableCollection<Planet> Planets { get; set; }
        public Planet SelectedPlanet
        {
            set
            {
                _selectedPlanet = value;
                OnPropertyChanged("SelectedPlanet");
            }
            get
            {
                return _selectedPlanet;
            }
        }
        public PlanetsViewModel()
        {
            _context = new SolarSystemContext();
            Planets = new ObservableCollection<Planet>();
            foreach (var planet in _context.Planets)
            {
                Planets.Add(planet);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
