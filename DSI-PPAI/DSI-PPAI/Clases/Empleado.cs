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
        private int legajo;
        Sede sede = new Sede();



        public int getLegajoEmpleado() {
            return this.legajo;
        }

        public string obtenerSedeDelEmpleado(int legajo)
        {
            return sede.getNombreSede(legajo);
        }

    }
}
