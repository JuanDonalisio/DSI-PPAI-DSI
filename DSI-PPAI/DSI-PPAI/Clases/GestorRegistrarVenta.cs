using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DBconection;
using System.Data;
using DSI_PPAI.Forms;
using System.Windows.Forms;

namespace DSI_PPAI.Clases
{
    class GestorRegistrarVenta
    {
        private string id_sede { get; set; }
        public string Pp_legajo;
        Acceso_Datos _BD = new Acceso_Datos();
        Login login = new Login();
        Sesion sesion = new Sesion();
        Empleado empleado = new Empleado();
        Sede sede = new Sede();

        public DataTable RegistrarVenta()
        {
            buscarSede();
            buscarUsuarioLogueado();
            return buscarTarifasExistentes();
        }

        //Se obtiene el nombre de la sede a traves del legajo del empleado logueado
        private string buscarSede() 
        {
            Pp_legajo = buscarUsuarioLogueado();
            return empleado.obtenerSedeDelEmpleado(Pp_legajo);
        }

        //Se obtiene el legajo del empleado que tiene usuario logueado
        public string buscarUsuarioLogueado()
        {
            string nombUsuario = "aomine";
            return sesion.getUsuario(nombUsuario);
        }

        //Se obtiene fecha y hora actual
        private string getFechaActual()
        {
            string sql = "SELECT getDate()";
            return _BD.EjecutarSelect(sql).Rows[0][0].ToString();
        }

        //Se obtienen las tarifas que se encuentran en periodo de vigencia
        private DataTable buscarTarifasExistentes()
        {
            string fechaActual = getFechaActual();
            return sede.obtenerTarifa(fechaActual, Pp_legajo);
        }
    }
}
