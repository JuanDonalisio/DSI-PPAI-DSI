using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DBconection;
using DSI_PPAI.ClasesAuxiliares;
using DSI_PPAI.DBconection;

namespace DSI_PPAI.Clases
{
    class Entrada
    {
        private string fechaVenta;
        private string horaVenta;
        private string monto;
        private string numero;
        Acceso_Datos _bd = new Acceso_Datos();

        public int esTuFecha(string id_sede,string fechaActual) {
            string sql = "SELECT count(*) FROM Entrada WHERE fecha_venta =" + fechaActual + "AND id_sede =" + id_sede;
            int cantidad = int.Parse(_bd.EjecutarSelect(sql).ToString());
            return cantidad;
        }
    }
}
