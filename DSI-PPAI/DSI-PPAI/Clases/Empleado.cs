using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DSI_PPAI.Clases
{
    class Empleado
    {
        
        private string nombre;
        private string apellido;
        public int legajo_empleado;
        Sede sede = new Sede();



        public string getLegajoEmpleado()
        {
            return legajo_empleado.ToString();
        }

        public string obtenerSedeDelEmpleado(string legajo)
        {
            return sede.getNombreSede(legajo);
        }

    }
}
