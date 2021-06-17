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

    

        public int getLegajoEmpleado() {
            return this.legajo;
        }

        public string obtenerSedeDelEmpleado(int legajo)
        {
            Sede sede = new Sede();
            return sede.getNombreSede(legajo);
        }

    }
}
