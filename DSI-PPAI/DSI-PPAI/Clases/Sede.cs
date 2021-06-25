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
        private int cantidadMaximaVisitante;
        public string id_sede { get; set; }
        Entrada entrada = new Entrada();
        ReservaVisita reservaVisita = new ReservaVisita();
        Acceso_Datos _BD = new Acceso_Datos();
        Exposicion exposicion = new Exposicion();

        public string getNombreSede(string legajo)
        {
            string sql = "SELECT s.id_sede FROM Empleado e JOIN Sede s ON e.id_sede = s.id_sede WHERE e.legajo = " + legajo ;
            string NombreSede = _BD.EjecutarSelect(sql).Rows[0][0].ToString();
            return NombreSede;
        }

        public DataTable obtenerTarifa(string fechaActual, string leg)
        {
            //Instancio la tarifa
            Tarifa tarifa = new Tarifa();

            //Consulta para obtener id de la sede a partir del nombre

            string sql = "SELECT id_sede FROM Empleado WHERE legajo = '" + leg + "'";
            string id_sede = _BD.EjecutarSelect(sql).Rows[0][0].ToString();

            //Recupero todas las tarifas
            string sqlTodasLasTarifas = "SELECT DISTINCT t.id_tarifa, t.fechaInicioVigencia, t.fechaFinVigencia FROM Tarifa t " +
                         "JOIN Tarifas_X_Sede st on st.id_tarifa = t.id_tarifa " +
                         "JOIN TipoDeEntrada te on t.id_tipo_entrada = te.id_tipo_entrada " +
                         "JOIN TipoDeVisita tv on t.id_tipo_visita = tv.id_tipo_visita " +
                         "WHERE st.id_sede = " + id_sede ;
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
            tablaIDTarifas.Columns.Add("monto", typeof(String));
            tablaIDTarifas.Columns.Add("montoAdicional", typeof(String));

            //Cargo la tabla a devolver con los datos de las tarifas vigentes
            for (int i = 0; i < tablaTodasLasTarifas.Rows.Count; i++)
            {
                if (tarifa.esVigente(fechaActual, tablaTodasLasTarifas.Rows[i][1].ToString(), tablaTodasLasTarifas.Rows[i][2].ToString()) == true)
                {
                    string[] columnas = tarifa.getTarifa(tablaTodasLasTarifas.Rows[i][0].ToString()).Split(',');
                    tablaIDTarifas.Rows.Add (columnas[0].Trim(), columnas[1].Trim(), columnas[2].Trim(), columnas[3].Trim(), columnas[4].Trim(), columnas[5].Trim(), columnas[6].Trim());
                }
            }
            return tablaIDTarifas;
        }

        public int obtenerCantidadMaximaVisitantes(string id_sede) {
            string sql = "SELECT cant_max_visitantes FROM Sede WHERE id_sede =" + id_sede;
            int max = int.Parse(_BD.EjecutarSelect(sql).Rows[0][0].ToString());
            return max;
        }

        public int validarFechaEntradas(string id_sede, string fechaActual) {

            string sql = "SELECT fechaVenta FROM Entrada WHERE id_sede =" + id_sede;
            DataTable tabla = _BD.EjecutarSelect(sql);
            int contador = 0;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (entrada.esTuFecha(tabla.Rows[i][0].ToString(), fechaActual))
                {
                    contador += 1;
                }
            }
            return contador;
            
        }

        //Cantidad total de alumnos confirmados de todas las reservas que cumplen la condicion
        public int obtenerEntradasDeReserva(string id_sede, int[] duracion) {
            string sql = "SELECT * FROM ReservaVisita WHERE id_sede =" + id_sede;
            DataTable reservas = _BD.EjecutarSelect(sql);
            int cantidad = 0;
            for (int i = 0; i < reservas.Rows.Count; i++)
            {

                if(reservaVisita.estaEnFecha(reservas.Rows[i]) == true && reservaVisita.estaEnRangoDuracion(reservas.Rows[i], duracion) == true){
                    cantidad = cantidad + reservaVisita.getAlumnosConfirmados(reservas.Rows[i]);
                }
            }
            return cantidad;
        }

        public int[] obtenerDuracionExposicionesVigentes(string id_sede, string fechaActual) {
            string sql = "SELECT id_exposicion FROM Exposiciones_X_Sede WHERE id_sede = " + id_sede;
            DataTable id_exposiciones = _BD.EjecutarSelect(sql);

            int[] contador = new int[3];
            for (int i = 0; i < id_exposiciones.Rows.Count; i++)
            {
                if (exposicion.esVigenteExposicion(id_exposiciones.Rows[i][0].ToString(), fechaActual) == true)
                {
                    contador = exposicion.getExposicion(id_exposiciones.Rows[i][0].ToString());
                }
            }
            return contador;
        }
    }
}
