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
        Usuario usuario = new Usuario();

        public int getUsuario()
        {
            return usuario.getEmpleado();
        }
    }
}
