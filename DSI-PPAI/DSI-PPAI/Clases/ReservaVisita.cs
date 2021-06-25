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
            string fechaActual = _bd.EjecutarSelect(sql).Rows[0][0].ToString();
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
            bool banderaInicio = false;
            bool banderaFin = true;

            string sqlFecha = "SELECT GETDATE()";
            string fechaActual = _bd.EjecutarSelect(sqlFecha).Rows[0][0].ToString();

            string[] subcadenaFechaYHoraActual = fechaActual.Split(' ');
            //Hora actual, o sea la hora inicio de la entrada
            string[] subcadenaHoraActual = subcadenaFechaYHoraActual[1].Split(':');

            int horaFinEntrada = int.Parse(subcadenaHoraActual[0]) + duracion[0];
            int minutoFinEntrada = int.Parse(subcadenaHoraActual[1]) + duracion[1];
            int segundoFinEntrada = int.Parse(subcadenaHoraActual[2]) + duracion[2];
            
            string fechaHoraReserva = fila[3].ToString();
            string[] subcadenaFechaYHoraReserva = fechaHoraReserva.Split(' ');
            string[] subcadenaHoraReserva = subcadenaFechaYHoraReserva[1].Split(':');

            string duracionEstimada = fila[2].ToString();
            //Hora inicio de reserva
            string[] subcadenaDuracionEstimada = duracionEstimada.Split(':');

            int horaFinReserva = int.Parse(subcadenaHoraReserva[0]) + int.Parse(subcadenaDuracionEstimada[0]);
            int minutoFinReserva = int.Parse(subcadenaHoraReserva[1]) + int.Parse(subcadenaDuracionEstimada[1]);
            int segundoFinReserva = int.Parse(subcadenaHoraReserva[2]) + int.Parse(subcadenaDuracionEstimada[2]);

            //Me fijo si la hora:minuto:segundo actual esta dentro de una reserva en transcurso
            //O sea que la hora actual esta entre la hora de inicio y de fin de una reserva
            if(int.Parse(subcadenaDuracionEstimada[0]) <= horaFinEntrada && horaFinEntrada <= horaFinReserva)
            {
                if(int.Parse(subcadenaDuracionEstimada[1]) <= minutoFinEntrada && minutoFinEntrada <= minutoFinReserva)
                {
                    if (int.Parse(subcadenaDuracionEstimada[2]) <= segundoFinEntrada && segundoFinEntrada <= segundoFinReserva)
                    {
                        banderaFin = true;
                    }
                }
            }

            if (int.Parse(subcadenaDuracionEstimada[0]) <= int.Parse(subcadenaHoraActual[0]) && int.Parse(subcadenaHoraActual[0]) <= horaFinReserva)
            {
                if (int.Parse(subcadenaDuracionEstimada[1]) <= int.Parse(subcadenaHoraActual[1]) && int.Parse(subcadenaHoraActual[1]) <= minutoFinReserva)
                {
                    if (int.Parse(subcadenaDuracionEstimada[2]) <= int.Parse(subcadenaHoraActual[2]) && int.Parse(subcadenaHoraActual[2]) <= segundoFinReserva)
                    {
                        banderaInicio = true;
                    }
                }
            }

            if(banderaInicio || banderaFin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Devuelve los alumnos confirmados de la fila pasada por parametro la cual esta en fecha actual y en rango de duracion
        //Chequear que este bien esto
        public int getAlumnosConfirmados(System.Data.DataRow fila) {
            return int.Parse(fila[1].ToString());
        }
    }
}
