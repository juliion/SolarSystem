using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SolarSystem.ViewModel;

namespace SolarSystem.Views
{
    /// <summary>
    /// Interaction logic for AboutPlanet.xaml
    /// </summary>
    public partial class AboutPlanet : Window
    {
        private readonly PlanetsViewModel _planetsVM;
        public AboutPlanet(PlanetsViewModel planetsVM)
        {
            _planetsVM = planetsVM;
            InitializeComponent();
            this.DataContext = _planetsVM;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (_planetsVM.SelectedPlanet.Moons.Count == 0)
                PlanetMoonsPanel.Visibility = Visibility.Hidden;
        }
    }
}
