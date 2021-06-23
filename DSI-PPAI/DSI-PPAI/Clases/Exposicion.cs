using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DBconection;
using System.Data;


namespace DSI_PPAI.Clases
{
    class Exposicion
    {
        Acceso_Datos _BD = new Acceso_Datos();
        DetalleExposicion de = new DetalleExposicion();
        public bool esVigenteExposicion(string id_exposicion, string fechaActual) {
            string sql = "SELECT fechaInicio, fechaFin, fechaInicioReplanificada, fechaFinReplanificada, horaApertura, horaCierre" +
                         " WHERE id_exposicion = " + id_exposicion;
            DataTable tablaFechas = _BD.EjecutarSelect(sql);
            string fechaInicio = tablaFechas.Rows[0][1].ToString();
            string fechaFin = tablaFechas.Rows[0][2].ToString();
            string fechaInicioReplanificada = tablaFechas.Rows[0][3].ToString();
            string fechaFinReplanificada = tablaFechas.Rows[0][4].ToString();
            string hora_Inicio = tablaFechas.Rows[0][5].ToString();
            string hora_Cierre = tablaFechas.Rows[0][6].ToString();

            string[] subcadenaFechaYHora = fechaActual.Split(' ');
            string[] subcadenaFechaActual = subcadenaFechaYHora[0].Split('/');
            string[] subcadenaHoraActual = subcadenaFechaYHora[1].Split(':');

            bool banderaMayorInicio = false;
            bool banderaMenorFin = false;
            bool banderaMenorHoraFin = false;

            if (fechaInicioReplanificada != "")
            {
                fechaInicio = fechaInicioReplanificada;
            }

            if (fechaFinReplanificada != "")
            {
                fechaFin = fechaFinReplanificada;
            }

            //Verifico que el dia de la fecha este entre la fecha de inicio y la fecha de fin
            string[] subcadenaFechaYHoraInicio = fechaInicio.Split(' ');
            string[] subcadenaFechaInicio = subcadenaFechaYHoraInicio[0].Split('/');

            string[] subcadenaFechaYHoraFin = fechaFin.Split(' ');
            string[] subcadenaFechaFin = subcadenaFechaYHoraFin[0].Split('/');

            int anio = int.Parse(subcadenaFechaInicio[2]);
            int bnio = Convert.ToInt32(subcadenaFechaActual[2]);
            int cnio = Convert.ToInt32(subcadenaFechaFin[2]);

            int ames = Convert.ToInt32(subcadenaFechaInicio[1]);
            int bmes = Convert.ToInt32(subcadenaFechaActual[1]);
            int cmes = Convert.ToInt32(subcadenaFechaFin[1]);

            int adia = Convert.ToInt32(subcadenaFechaInicio[0]);
            int bdia = Convert.ToInt32(subcadenaFechaActual[0]);
            int cdia = Convert.ToInt32(subcadenaFechaFin[0]);

            if (anio <= bnio)
            {
                if (ames < bmes)
                {
                    banderaMayorInicio = true;
                }
                if (ames == bmes)
                {
                    if (adia <= bdia)
                    {
                        banderaMayorInicio = true;
                    }
                }
            }

            if (bnio <= cnio)
            {
                if (bmes < cmes)
                {
                    banderaMenorFin = true;
                }
                if (bmes == cmes)
                {
                    if (bdia <= cdia)
                    {
                        banderaMenorFin = true;
                    }
                }
            }


            string[] subhoraInicio = hora_Inicio.Split(':');
            string[] subhoraFin = hora_Cierre.Split(':');

            int horaActual = int.Parse(subcadenaHoraActual[0]);
            int minutoActual = int.Parse(subcadenaHoraActual[1]);
            int segundoActual = int.Parse(subcadenaHoraActual[2]);

            int horaFin = int.Parse(subhoraFin[0]);
            int minutoFin = int.Parse(subhoraFin[1]);
            int segundoFin = int.Parse(subhoraFin[2]);

            //Verifico que la exposición aun no haya terminado
            if (banderaMayorInicio && banderaMenorFin)
            {
                if (horaFin == horaActual)
                {
                    if (minutoFin == minutoActual)
                    {
                        if (segundoFin >= segundoActual)
                        {
                            banderaMenorHoraFin = true;
                        }
                    }
                    if (minutoFin > minutoActual)
                    {
                        banderaMenorHoraFin = true;
                    }
                }
                if (horaFin > horaActual)
                {
                    banderaMenorHoraFin = true;
                }
            }

            if (banderaMenorHoraFin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int[] getExposicion(string id_exposicion) {

            return de.getDetalleExposicion(id_exposicion);
        }

    }
}
