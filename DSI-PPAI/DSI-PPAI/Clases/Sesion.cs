using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.Clases;

namespace DSI_PPAI.Clases
{
    class Sesion
    {
        
        public int getUsuario()
        {
            Usuario usuario = new Usuario();
            return usuario.getEmpleado();
        }
    }
}
