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
    /// Interaction logic for Cap_8_OrdenarCadenas.xaml
    /// </summary>
    public partial class Cap_8_OrdenarCadenas : Window
    {
        public Cap_8_OrdenarCadenas()
        {
            InitializeComponent();
        }

        private void BtnOrdenar(object sender, RoutedEventArgs e)
        {
            
            TextRCadena1.Text = Cap8.Ordenar(TextCadena1.Text, TextCadena2.Text)[0];
            TextRCadena2.Text = Cap8.Ordenar(TextCadena1.Text, TextCadena2.Text)[1];
        }
    }
}
