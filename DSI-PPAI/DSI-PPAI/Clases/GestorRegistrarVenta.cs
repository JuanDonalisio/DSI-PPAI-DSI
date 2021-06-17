using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DSI_PPAI.Clases
{
    class GestorRegistrarVenta
    {
        
        private void buscarSede(string empl) 
        {
            Empleado empleado = new Empleado();
            empl = buscarUsuarioLogueado();
            
        }

        private string buscarUsuarioLogueado()
        {
            Sesion sesion = new Sesion();
            return sesion.getUsuario();

        }
    }
}
