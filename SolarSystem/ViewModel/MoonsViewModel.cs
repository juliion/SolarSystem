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
        private RelayCommand _selectMoon;
        public RelayCommand SelectMoon
        {
            get
            {
                return _selectMoon ?? (_selectMoon = new RelayCommand(obj =>
                {
                    Moon selectedMoon = obj as Moon;
                    if (selectedMoon != null)
                    {
                        SelectedMoon = selectedMoon;
                        AboutMoon aboutMoon = new AboutMoon(this);
                        aboutMoon.Show();
                    }

                }));
            }
        }

        private RelayCommand _openReadMoreMoon;
        public RelayCommand OpenReadMoreMoon
        {
            get
            {
                return _openReadMoreMoon ?? (_openReadMoreMoon = new RelayCommand(obj =>
                {
                    ReadMore readMore = new ReadMore(SelectedMoon.DocPath);
                    readMore.ShowDialog();
                }));
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
