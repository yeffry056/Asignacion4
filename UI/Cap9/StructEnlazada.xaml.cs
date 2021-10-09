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
using static Asignacion4.Cap9;

namespace Asignacion4.UI.Cap9
{
    /// <summary>
    /// Interaction logic for StructEnlazada.xaml
    /// </summary>
    public partial class StructEnlazada : Window
    {
        public StructEnlazada()
        {
            InitializeComponent();
        }
        private Informacion[] informacion = new Informacion[20];
        private int cont = 0;
        private void BtnGuardar(object sender, RoutedEventArgs e)
        {
            if (cont < 20)
            {
                informacion[cont].dueño.nombre = TextNombreDue.Text;
                informacion[cont].dueño.apellido = TextApellido.Text;
                informacion[cont].dueño.edad = Convert.ToInt32(TextEdadDue.Text);
                informacion[cont].mascota.nombre = TextNombreMascota.Text;
                informacion[cont].mascota.edad = Convert.ToInt32(TextEdadMascota.Text);
                cont++;
            } else
                MessageBox.Show("No se permiten mas registros");
                
        }
    }
}
