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
    class TipoVisita
    {
        private string IdYnombre;
        Acceso_Datos _BD = new Acceso_Datos();
        public EstructuraComboBox GetTipoVisita()
        {
            EstructuraComboBox edc = new EstructuraComboBox();

            edc.Value = "id_tipo_visita";
            edc.Display = "nombre";
            edc.Sql = "SELECT * FROM TipoDeVisita";
            edc.Tabla = _BD.EjecutarSelect(edc.Sql);

            return edc;
        }

        public string getNombreTipoVisita(string id_tarifa)
        {
            //Recupero el id y nombre del tipo de visita asociado al id de la tarifa
            string sql = "SELECT t.id_tipo_visita, tv.nombre as nombre_tipo_visita FROM Tarifa t " +
                         "JOIN TipoDeVisita tv on t.id_tipo_visita = tv.id_tipo_visita " +
                         "WHERE t.id_tarifa = " + id_tarifa;
            DataTable tabla = _BD.EjecutarSelect(sql);
            IdYnombre = (tabla.Rows[0][0].ToString() + ", " + tabla.Rows[0][1].ToString());
            return IdYnombre;
        }



    }
}
