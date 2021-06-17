using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DSI_PPAI.DBconection;

namespace DSI_PPAI.Forms
{
    class NE_Login
    {
        public enum ResultadoValidacion { existe, no_existe }
        DataTable tabla = new DataTable();
        Acceso_Datos _BD = new Acceso_Datos();
        public ResultadoValidacion Validar_Usuario(String usuario, String password)
        {
            String sql = @"SELECT * FROM Empleados WHERE usuario = '" + usuario + "'"
                                + "AND contrasena = '" + password + "'"; // comando que va a ejecutar
            tabla = _BD.EjecutarSelect(sql); //la ejecucion de este comando me devuelve un DataTable

            if (tabla.Rows.Count == 1)
            {
                return ResultadoValidacion.existe;
            }
            else
            {
                return ResultadoValidacion.no_existe;
            }
        }
    }
}
