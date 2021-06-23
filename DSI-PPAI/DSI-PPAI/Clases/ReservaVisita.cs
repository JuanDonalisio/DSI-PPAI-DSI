using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DBconection;

namespace DSI_PPAI.Clases
{
    class ReservaVisita
    {

        Acceso_Datos _bd = new Acceso_Datos();

        //Si la fecha de la reserva es igual a la fecha actual devuelve true
        public bool estaEnFecha(System.Data.DataRow fila) {
            string sql = "SELECT getDate()";
            string fechaActual = _bd.EjecutarSelect(sql).ToString();
            string fechaReserva = fila[3].ToString();

            string[] subcadenaFechaYHoraActual = fechaActual.Split(' ');
            string[] subcadenaFechaYHoraReserva = fechaReserva.Split(' ');

            if (subcadenaFechaYHoraReserva[0] == subcadenaFechaYHoraActual[0] )
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //No se we
        public bool estaEnRangoDuracion(System.Data.DataRow fila, int[]duracion)
        {
            //La hora de inicio esta dentro de la fechaHoraReserva
            //La hora de fin es la hora de inicio + la duracionEstimada

            //Recuperar fecha actual para tener una hora de inicio de la visita
            //la hora de fin sería la hora de inicio de la visita + la duración que pasamos por parámetro
            return true;
        }

        //Devuelve los alumnos confirmados de la fila pasada por parametro la cual esta en fecha actual y en rango de duracion
        //Chequear que este bien esto
        public int getAlumnosConfirmados(System.Data.DataRow fila) {
            return int.Parse(fila[2].ToString());
        }
    }
}
