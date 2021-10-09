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

namespace Asignacion4.UI
{
    /// <summary>
    /// Interaction logic for Cap_8.xaml
    /// </summary>
    public partial class Cap_8 : Window
    {
        public Cap_8()
        {
            InitializeComponent();
        }

        private void BtnTiempo(object sender, RoutedEventArgs e)
        {
            TextHora.Text = Cap8.Fecha();
        }
    }
}
