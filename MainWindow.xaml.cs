using Asignacion4.UI;
using Asignacion4.UI.Cap9;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Asignacion4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void BtnFecha(object sender, RoutedEventArgs e)
        {
            Cap_8 Cp = new Cap_8();
            Cp.Show();
        }

        private void BtnOrdenarCadenas(object sender, RoutedEventArgs e)
        {
            Cap_8_OrdenarCadenas Orden = new Cap_8_OrdenarCadenas();
            Orden.Show();
        }

        private void BtnGuardarProduc(object sender, RoutedEventArgs e)
        {
            GuardarProduct GP = new GuardarProduct();
            GP.Show();
        }

        private void StructEnla(object sender, RoutedEventArgs e)
        {
            StructEnlazada SE = new StructEnlazada();
            SE.Show();
        }
    }
}
