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

namespace SolarSystem.ViewModel
{
    public class StarsViewModel : INotifyPropertyChanged
    {
        private readonly SolarSystemContext _context;
        private Star _selectedStar;
        public ObservableCollection<Star> Stars { get; set; }
        public Star SelectedStar
        {
            set
            {
                _selectedStar = value;
                OnPropertyChanged("SelectedStar");
            }
            get
            {
                return _selectedStar;
            }
        }
        public StarsViewModel()
        {
            _context = new SolarSystemContext();
            Stars = new ObservableCollection<Star>();
            foreach (var star in _context.Stars)
            {
                Stars.Add(star);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
