using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DBconection;
using System.Data;


namespace DSI_PPAI.Clases
{
    class GestorRegistrarVenta
    {
        Acceso_Datos _bd = new Acceso_Datos();

        //Se obtiene el nombre de la sede a traves del legajo del empleado logueado
        private string buscarSede(int legajo) 
        {
            Empleado empleado = new Empleado();
            legajo = buscarUsuarioLogueado();
            return empleado.obtenerSedeDelEmpleado(legajo);
        }

        //Se obtiene el legajo del empleado que tiene usuario logueado
        private int buscarUsuarioLogueado()
        {
            Sesion sesion = new Sesion();
            return sesion.getUsuario();
        }

        //Se obtiene fecha y hora actual
        private string getFechaActual() {
            string sql = "SELECT getDate()";
            return _bd.EjecutarSelect(sql).Rows[0][0].ToString();
        }

        //Se obtienen las tarifas que se encuentran en periodo de vigencia
        private void buscarTarifasExistentes() {
            string fechaActual = getFechaActual();
            Tarifa tarifa = new Tarifa();
            string sql = "SELECT fechaInicioVigencia, fechaFinVigencia FROM Tarifa ";
            DataTable tabla = _bd.EjecutarSelect(sql);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tarifa.esVigente(fechaActual,tabla.Rows[0][i].ToString(),tabla.Rows[1][i].ToString()) == true) {
                    tarifa.getTarifa();
                }
            }
        }
    }
}
