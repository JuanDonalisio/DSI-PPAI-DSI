using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Clases
{
    class Usuario
    {
        private string nombre;
        private string clave;

        Empleado empleado = new Empleado();

        public string getEmpleado(string nombUsuario)
        {
            return empleado.getLegajoEmpleado(nombUsuario);
        }
    }
}
