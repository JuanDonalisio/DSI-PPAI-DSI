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
        #region atributos

        private string id_sede { get; set; }
        public string Pp_legajo { get; set; }
        public string nombre_usuario { get; set; }
        public int[] duracion { get; set; }
        private int monto { get; set; }
        Acceso_Datos _BD = new Acceso_Datos();
        Login login = new Login();
        Sesion sesion = new Sesion();
        Empleado empleado = new Empleado();
        Sede sede = new Sede();
        private List<IObservadorActualizacionVisitantes> _observador;

        #endregion

        #region metodos
        //Devuelve una tabla con todas las tarifas vigentes
        public DataTable RegistrarVenta()
        {
            Pp_legajo = buscarUsuarioLogueado();
            id_sede = buscarSede();
            return buscarTarifasExistentes();
        }

        //Se obtiene el nombre de la sede a traves del legajo del empleado logueado
        private string buscarSede() 
        {
            return empleado.obtenerSedeDelEmpleado(Pp_legajo);
        }

        //Se obtiene el legajo del empleado que tiene usuario logueado
        public string buscarUsuarioLogueado()
        {
            return sesion.getUsuario(nombre_usuario);
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
            sede.id_sede = id_sede;
            return sede.obtenerTarifa(fechaActual, Pp_legajo);
        }

        //Calcula la duracion estimada de una visita completa 
        private int[] calcularDuracionAExposicionesVigentes() {
            return sede.obtenerDuracionExposicionesVigentes(id_sede, getFechaActual());
        }

        //Trae la cantidad maxima de visitantes que tiene la sede actual 
        public int validarLimiteVisitantes() {
            int limite = sede.obtenerCantidadMaximaVisitantes(id_sede);
            return limite;
        }

        //Trae la cantidad de entradas vendida en la fecha actual actual 
        public int contarEntradasVendidas() {
            return sede.validarFechaEntradas(id_sede, getFechaActual());
        }

        //Trae la cantidad de alumnos confirmados con reserva para la fecha actual
        public int contarEntradasDeReserva()
        {
            return sede.obtenerEntradasDeReserva(id_sede, duracion);
        }

        /*Devuelve un array con la duracion en formato hora:minuto:segundo 
        de la visita completa al museo*/
        public int[] tomarSeleccionTarifa() {

            duracion = calcularDuracionAExposicionesVigentes();
            return duracion;
        }

        /*Valida que la cantidad de entradas que se quiere vender no supera 
        la cantidad de entradas vendidas en el día sumado a la cantidad de personas
        que están o van a estar en el museo por una visita durante la duracion 
        de la entrada vendida*/
        public int[] tomarCantidadDeEntradas(int cantidad_entradas_a_comprar)
        {
            int cant_max = validarLimiteVisitantes();
            int entradas_vendidas = contarEntradasVendidas();
            int entradas_reserva = contarEntradasDeReserva();
            int total_actual = entradas_reserva + entradas_vendidas + cantidad_entradas_a_comprar;

            int[] array = new int[2];
            array[0] = cant_max;
            array[1] = total_actual;
            return array;
        }

        public int calcularTotalAPagar(int precioEntrada, int montoGuia, int cantidadEntradas) {
            int montoTotal = (precioEntrada + montoGuia) * cantidadEntradas;
            return montoTotal;
        }

        public int confirmarVenta(string tipo_entrada, string tipo_visita, string monto)
        {
            int nro_entrada = buscarUltimoNroEntrada();
            generarEntradas(nro_entrada.ToString(), tipo_entrada, tipo_visita, monto);
            return nro_entrada;
        }

        private int buscarUltimoNroEntrada()
        {
            Entrada entrada = new Entrada();
            return entrada.getNro(id_sede);
        }

        private void generarEntradas(string nro_entrada, string tipo_entrada, string tipo_visita, string monto)
        {
            string sqlTarifa = "SELECT t.id_tarifa FROM Tarifa t" +
                               " JOIN TipoDeEntrada te on t.id_tipo_entrada = te.id_tipo_entrada " +
                               " JOIN TipoDeVisita tv on t.id_tipo_visita = tv.id_tipo_visita" +
                               " WHERE te.nombre = '" + tipo_entrada + "' AND tv.nombre = '" + tipo_visita + "'";
            string id_tarifa = _BD.EjecutarSelect(sqlTarifa).Rows[0][0].ToString();
            string fechaActual = getFechaActual();
            string[] subcadenaFechaYHoraActual = fechaActual.Split(' ');
            string[] subcadenaFechaActual = subcadenaFechaYHoraActual[0].Split('/');
            string sqlEntrada = @"INSERT INTO Entrada (fechaVenta, horaVenta, monto, id_entrada, id_sede, id_tarifa) 
                         VALUES ('" + subcadenaFechaActual[2] + "/" + subcadenaFechaActual[1] + "/" + subcadenaFechaActual[0] + "', '" + subcadenaFechaYHoraActual[1] + "', " + monto + ", " + nro_entrada + ", " + id_sede + ", " + id_tarifa + ")";
            _BD.Insertar(sqlEntrada);
        }

        public void imprimirEntradas(DataTable tabla, bool guia, int i)
        {
            ImpresorEntradas impresor_entrada = new ImpresorEntradas();
            impresor_entrada.New(tabla, guia, i);

        }
        #endregion

        #region patron observer

        public void suscribir(IObservadorActualizacionVisitantes observador)
        {
            if (!_observador.Contains(observador))
            {
                _observador.Add(observador);
            }
            else
            {
                throw new Exception($"Ya existe una suscripción para este observador");
            }
        }

        public void notificar() { }

        public void quitar(IObservadorActualizacionVisitantes observador)
        {
            if (_observador.Contains(observador))
            {
                _observador.Remove(observador);
            }
            else
            {
                throw new Exception($"Na existe una suscripción para este observador");
            }
        }






        #endregion
    }

}
