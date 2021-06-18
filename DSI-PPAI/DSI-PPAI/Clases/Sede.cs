using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DBconection;
using System.Data;
using System.Windows.Forms;

namespace DSI_PPAI.Clases
{
    class Sede
    {
        private string nombre;
        public string id_sede { get; set; }
        private int cantidadMaximaVisitante;
        Acceso_Datos _BD = new Acceso_Datos();

        public string getNombreSede(string legajo)
        {
            string sql = "SELECT s.nombre FROM Empleado e JOIN Sede s ON e.id_sede = s.id_sede WHERE e.legajo = " + legajo;
            //VER COMO HACER LLEGAR EL LEGAJO DEL EMPLEADO, EL RESTO FUNCIONA
            MessageBox.Show(legajo);
            return _BD.EjecutarSelect(sql).Rows[0][0].ToString();
        }

        public DataTable obtenerTarifa(string fechaActual)
        {
            //Instancio la tarifa
            Tarifa tarifa = new Tarifa();
            //Recupero todas las tarifas
            string sqlTodasLasTarifas = "SELECT t.id_tarifa, t.fechaInicioVigencia, t.fechaFinVigencia FROM Tarifa t " +
                         "JOIN Tarifas_X_Sede st on st.id_tarifa = t.id_tarifa " +
                         "JOIN TipoDeEntrada te on t.id_tipo_entrada = te.id_tipo_entrada " +
                         "JOIN TipoDeVisita tv on t.id_tipo_visita = tv.id_tipo_visita " +
                         "WHERE st.id_sede = " + id_sede;
            //VER COMO HACER LLEGAR EL ID DE LA SEDE, EL RESTO FUNCIONA
            DataTable tablaTodasLasTarifas = _BD.EjecutarSelect(sqlTodasLasTarifas);

            //Recupero los nombres de columna que voy a usar sin datos
            //string sqlIDTarifas = "SELECT t.id_tarifa, t.id_tipo_entrada, te.nombre as nombre_tipo_entrada, t.id_tipo_visita, tv.nombre as nombre_tipo_visita FROM Tarifa t " +
            //                      "JOIN TipoDeEntrada te on t.id_tipo_entrada = te.id_tipo_entrada " +
            //                      "JOIN TipoDeVisita tv on t.id_tipo_visita = tv.id_tipo_visita " +
            //                      "WHERE t.id_tarifa = -1 ";
            //DataTable tablaIDTarifas = _BD.EjecutarSelect(sqlIDTarifas);
            DataTable tablaIDTarifas = new DataTable();
            tablaIDTarifas.Columns.Add("id_tarifa", typeof(String));
            tablaIDTarifas.Columns.Add("id_tipo_entrada", typeof(String));
            tablaIDTarifas.Columns.Add("nombre_tipo_entrada", typeof(String));
            tablaIDTarifas.Columns.Add("id_tipo_visita", typeof(String));
            tablaIDTarifas.Columns.Add("nombre_tipo_visita", typeof(String));

            //Cargo la tabla a devolver con los datos de las tarifas vigentes
            for (int i = 0; i < tablaTodasLasTarifas.Rows.Count; i++)
            {
                if (tarifa.esVigente(fechaActual, tablaTodasLasTarifas.Rows[i][1].ToString(), tablaTodasLasTarifas.Rows[i][2].ToString()) == true)
                {
                    string[] columnas = tarifa.getTarifa(tablaTodasLasTarifas.Rows[i][0].ToString()).Split(',');
                    tablaIDTarifas.Rows.Add (columnas[0].Trim(), columnas[1].Trim(), columnas[2].Trim(), columnas[3].Trim(), columnas[4].Trim());
                }
            }
            return tablaIDTarifas;
        }
    }
}
