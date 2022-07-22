using System;
using System.IO;
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
using System.Windows.Markup;

namespace SolarSystem.Views
{
    /// <summary>
    /// Interaction logic for ReadMore.xaml
    /// </summary>
    public partial class ReadMore : Window
    {
        private readonly string _docPath;
        public ReadMore(string docPath)
        {
            _docPath = docPath;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(File.Exists(_docPath))
                Reader.Document = (FlowDocument)XamlReader.Load(File.OpenRead(_docPath));
            else
            {
                System.Windows.Forms.MessageBox.Show("Файл ще в розробці, зверніться пізніше!");
                DialogResult = false;
            }
        }
    }
}
