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
    public class MoonsViewModel : INotifyPropertyChanged
    {
        private readonly SolarSystemContext _context;
        private Moon _selectedMoon;
        public ObservableCollection<Moon> Moons { get; set; }
        public Moon SelectedMoon
        {
            set
            {
                _selectedMoon = value;
                OnPropertyChanged("SelectedMoon");
            }
            get
            {
                return _selectedMoon;
            }
        }
        public MoonsViewModel()
        {
            _context = new SolarSystemContext();
            Moons = new ObservableCollection<Moon>();
            foreach (var moon in _context.Moons)
            {
                Moons.Add(moon);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}