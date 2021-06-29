using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DBconection;
using System.Windows.Forms;

namespace DSI_PPAI.Clases
{
    class Empleado
    {
        
        private string nombre;
        private string apellido;
        public int legajo_empleado;
        Sede sede = new Sede();
        Acceso_Datos _bd = new Acceso_Datos();

        //Recupera el legajo del empleado de la base de datos correspondiente al nombre de usuario pasado por parámetro
        public string getLegajoEmpleado(string nombUsuario)
        {      
            string sql = "SELECT legajo_empleado FROM Usuario WHERE nombre = '" + nombUsuario+ "'";
            return _bd.EjecutarSelect(sql).Rows[0][0].ToString();
        }


        public string obtenerSedeDelEmpleado(string legajo)
        {
            return sede.getNombreSede(legajo);
        }

    }
}
