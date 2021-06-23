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
        private string id_sede { get; set; }
        public string Pp_legajo { get; set; }
        public string nombre_usuario { get; set; }
        Acceso_Datos _BD = new Acceso_Datos();
        Login login = new Login();
        Sesion sesion = new Sesion();
        Empleado empleado = new Empleado();
        Sede sede = new Sede();

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

        //Calcula la duracion estimada de una visita completa <----- FALTA 
        private int calcularDuracionAExposicionesVigentes() {
            return sede.obtenerDuracionExposicionesVigentes(id_sede, getFechaActual());
        }

        //Trae la cantidad maxima de visitantes que tiene la sede actual <-----Cambiar
        public int validarLimiteVisitantes() {
            int limite = sede.obtenerCantidadMaximaVisitantes(id_sede);
            return limite;
        }

        //Trae la cantidad de entradas vendida en la fecha actual actual <-----Chequear
        public int contarEntradasVendidas() {
            return sede.validarFechaEntradas(id_sede, getFechaActual());
        }

        //Trae la cantidad de alumnos confirmados con reserva para la fecha actual <-----Chequear
        public int contarEntradasDeReserva()
        {
            return sede.obtenerEntradasDeReserva(id_sede);
        }

        public void tomarSeleccionTarifa() {
            calcularDuracionAExposicionesVigentes();
        }
    }
}
