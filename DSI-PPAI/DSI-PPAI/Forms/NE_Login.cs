using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DSI_PPAI.DBconection;
using DSI_PPAI.Clases;
using System.Windows.Forms;

namespace DSI_PPAI.Forms
{
    class NE_Login
    {
        //Login login = new Login();
        public enum ResultadoValidacion { existe, no_existe }
        DataTable tabla = new DataTable();
        Acceso_Datos _BD = new Acceso_Datos();
        public ResultadoValidacion Validar_Usuario(String usuario, String password)
        {
            String sql = @"SELECT legajo_empleado FROM Usuario WHERE nombre = '" + usuario + "'"
                                + "AND contrasena = '" + password + "'"; // comando que va a ejecutar
            tabla = _BD.EjecutarSelect(sql); //la ejecucion de este comando me devuelve un DataTable

            if (tabla.Rows.Count == 1)
            {
                //login.id_usuario = tabla.Rows[0][0].ToString();
                Empleado emp = new Empleado();
                MessageBox.Show(tabla.Rows[0][0].ToString());
                emp.legajo_empleado = int.Parse(tabla.Rows[0][0].ToString());
                return ResultadoValidacion.existe;
            }
            else
            {
                return ResultadoValidacion.no_existe;
            }
        }
    }
}
