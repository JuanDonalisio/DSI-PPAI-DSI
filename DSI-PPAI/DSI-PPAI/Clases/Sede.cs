using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DBconection;

namespace DSI_PPAI.Clases
{
    class Sede
    {
        private string nombre;
        private int cantidadMaximaVisitante;

        public string getNombreSede(int legajo)
        {
            Acceso_Datos _bd = new Acceso_Datos();
            string sql = "SELECT s.nombre FROM Empleado e JOIN Sede s ON e.id_sede = s.id_sede WHERE e.legajo = " + legajo;
            return _bd.EjecutarSelect(sql).Rows[0][0].ToString();
        }

        public void obtenerTarifa() {

        }
    }
}
