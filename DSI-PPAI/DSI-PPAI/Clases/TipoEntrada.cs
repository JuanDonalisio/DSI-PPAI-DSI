using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DBconection;
using DSI_PPAI.ClasesAuxiliares;
using System.Data;

namespace DSI_PPAI.Clases
{
    class TipoEntrada
    {
        private string IdYnombre;
        Acceso_Datos _BD = new Acceso_Datos();
        public EstructuraComboBox GetTipoEntrada()
        {
            EstructuraComboBox edc = new EstructuraComboBox();

            edc.Value = "id_tipo_entrada";
            edc.Display = "nombre";
            edc.Sql = "SELECT * FROM TipoDeEntrada";
            edc.Tabla = _BD.EjecutarSelect(edc.Sql);

            return edc;
        }

        //Recupero el id y nombre del tipo de entrada asociado al id de la tarifa
        public string getNombreTipoEntrada(string id_tarifa)
        {
            string sql = "SELECT t.id_tipo_entrada, te.nombre as nombre_tipo_entrada FROM Tarifa t " +
                         "JOIN TipoDeEntrada te on t.id_tipo_entrada = te.id_tipo_entrada " +
                         "WHERE t.id_tarifa = " + id_tarifa + 
                         " ORDER BY t.id_tipo_entrada";
            DataTable tabla = _BD.EjecutarSelect(sql);
            IdYnombre = (tabla.Rows[0][0].ToString() + ", " + tabla.Rows[0][1].ToString());
            return IdYnombre;
        }

    }
}
