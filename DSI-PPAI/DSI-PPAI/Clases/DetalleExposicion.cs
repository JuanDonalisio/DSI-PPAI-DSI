using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DBconection;
namespace DSI_PPAI.Clases
{
    class DetalleExposicion
    {
        Acceso_Datos _bd = new Acceso_Datos();
        Obra obra = new Obra();
        public int[] getDetalleExposicion(string id_exposicion)
        {
            string sql = "SELECT id_obra FROM DetalleExposicion WHERE id_exposicion ="+ id_exposicion;
            System.Data.DataTable id_obras = _bd.EjecutarSelect(sql);
            return obra.getDuracionResumida(id_obras);
        }
    }
}
