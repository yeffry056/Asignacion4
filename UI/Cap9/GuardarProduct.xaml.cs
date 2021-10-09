using System;
using System.Collections;
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
    /// Interaction logic for GuardarProduct.xaml
    /// </summary>
    public partial class GuardarProduct : Window
    {
       
        
        public GuardarProduct()
        {
            InitializeComponent();

        }
        public struct Productos_0
        {
            public int codigo;
            public string nombre;
            public int precio;
            public string marca;

            public Productos_0(int codigo, string nombre, int precio, string marca)
            {
                this.codigo = codigo;
                this.nombre = nombre;
                this.precio = precio;
                this.marca = marca;

            }

           
        }
        private Productos_0[] p = new Productos_0[20];
        //private Productos_0 p;

        private int cont = 0;
        private void BtnGuardar(object sender, RoutedEventArgs e)
        {
            if (cont < 20)
            {
                p[cont].codigo = Convert.ToInt32(TextCodigo.Text);
                p[cont].nombre = TextNombre.Text;
                p[cont].marca = TextMarca.Text;
                p[cont].precio = Convert.ToInt32(TextPrecio.Text);

                cont++;
            }
            else
                MessageBox.Show("no se permiten mas productos");
            
        }

        
    }
}
