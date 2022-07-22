using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using SolarSystem.Models;
using SolarSystem.Context;
using SolarSystem.Commands;
using SolarSystem.Views;

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

        private RelayCommand _selectPlanet;
        public RelayCommand SelectPlanet
        {
            get
            {
                return _selectPlanet ?? (_selectPlanet = new RelayCommand(obj =>
                {
                    Planet selectedPlanet = obj as Planet;
                    if(selectedPlanet != null)
                    {
                        SelectedPlanet = selectedPlanet;
                        AboutPlanet aboutPlanet = new AboutPlanet(this);
                        aboutPlanet.Show();
                    }

                }));
            }
        }
        private RelayCommand _openReadMorePlanet;
        public RelayCommand OpenReadMorePlanet
        {
            get
            {
                return _openReadMorePlanet ?? (_openReadMorePlanet = new RelayCommand(obj =>
                {
                    ReadMore readMore = new ReadMore(SelectedPlanet.DocPath);
                    readMore.ShowDialog();
                }));
            }
        }
        public PlanetsViewModel()
        {
            _context = new SolarSystemContext();
            Planets = new ObservableCollection<Planet>();
            foreach (var planet in _context.Planets.OrderByDescending(p => p.Id))
            {
                Planets.Add(planet);
            }
        }
        public MoonsViewModel MoonsVM { get; set; } = new MoonsViewModel();

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
