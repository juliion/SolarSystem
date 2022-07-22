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
    /// Interaction logic for AboutStar.xaml
    /// </summary>
    public partial class AboutStar : Window
    {
        public AboutStar(StarsViewModel starsVM)
        {
            InitializeComponent();
            this.DataContext = starsVM;
        }
    }
}
