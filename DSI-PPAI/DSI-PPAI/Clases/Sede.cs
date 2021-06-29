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

        //Recupera de la base de datos la sede correspondiente al legajo del empleado logueado
        public string getNombreSede(string legajo)
        {
            string sql = "SELECT s.id_sede FROM Empleado e JOIN Sede s ON e.id_sede = s.id_sede WHERE e.legajo = " + legajo ;
            string NombreSede = _BD.EjecutarSelect(sql).Rows[0][0].ToString();
            return NombreSede;
        }

        /*Devuelve una tabla con el id de la tarifa, el id y nombre del tipo de entrada, 
        el id y nombre del tipo de visita, el monto y el monto adicional por guía */
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
            DataTable tablaTodasLasTarifas = _BD.EjecutarSelect(sqlTodasLasTarifas);

            //Recupero los nombres de columna que voy a usar sin datos
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

        //Devuelve la cantidad máxima de visitantes para la sede pasada por parámetro
        public int obtenerCantidadMaximaVisitantes(string id_sede) {
            string sql = "SELECT cant_max_visitantes FROM Sede WHERE id_sede =" + id_sede;
            int max = int.Parse(_BD.EjecutarSelect(sql).Rows[0][0].ToString());
            return max;
        }

        //Devuelve la cantidad de entradas vendidas en el día
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

        //Obtiene la duracion en horas:minutos:segundos de las exposiciones vigentes
        public int[] obtenerDuracionExposicionesVigentes(string id_sede, string fechaActual)
        {
            //Recupero los id de todas las exposiciones de la sede pasada por parámetro
            string sql = "SELECT id_exposicion FROM Exposiciones_X_Sede WHERE id_sede = " + id_sede;
            DataTable id_exposiciones = _BD.EjecutarSelect(sql);

            int[] contador = new int[3];
            int[] auxiliar = new int[3];
            //Itero la tabla que contiene todas las exposiciones de la sede
            for (int i = 0; i < id_exposiciones.Rows.Count; i++)
            {
                if (exposicion.esVigenteExposicion(id_exposiciones.Rows[i][0].ToString(), fechaActual) == true)
                {
                    auxiliar = exposicion.getExposicion(id_exposiciones.Rows[i][0].ToString());
                    contador[0] += auxiliar[0];
                    contador[1] += auxiliar[1];
                    contador[2] += auxiliar[2];
                }
            }
            return contador;
        }
    }
}
