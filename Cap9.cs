using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion4
{
    public class Cap9
    {
        public struct Productos
        {
            public int codigo;
            public string nombre;
            public int precio;
            public string marca;

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("",codigo, nombre, precio, marca);
                return (sb.ToString());
            }
        }
        public struct Mascota 
        {
            public string nombre;
            public int edad;
        }
        public struct Dueño
        {
            public string nombre;
            public string apellido;
            public string cedula;
            public int edad;
        }




        public struct Informacion
        {
            public Dueño dueño;
            public Mascota mascota;
        }

        enum Neumaticos {Deportivos, De_Pista, invierno, todo_Terreno};
        
    }
}
