using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DSI_PPAI.ClasesAuxiliares;
using DSI_PPAI.Clases;
using DSI_PPAI.DBconection;
using System.Windows.Forms;

namespace DSI_PPAI.Clases
{
    class Tarifa
    {
        
        private string fechaFinVigencia;
        private string fechaInicioVigencia;
        private int monto;
        private int montoAdicional;
        Acceso_Datos _bd = new Acceso_Datos();

        TipoEntrada tipo_entrada = new TipoEntrada();
        TipoVisita tipo_visita = new TipoVisita();

        //Si la fecha actual esta en rango de vigencia devuelve true
        public bool esVigente(string fechaActual, string fechaInicioVigencia, string fechaFinVigencia)
        {
            string[] subcadenaFechaYHora = fechaActual.Split(' ');
            string[] subcadenaFecha = subcadenaFechaYHora[0].Split('/');
            
            string[] subcadenaFechaYHoraInicioVigencia = fechaInicioVigencia.Split(' ');
            string[] subcadenaFechaInicioVigencia = subcadenaFechaYHoraInicioVigencia[0].Split('/');

            string[] subcadenaFechaYHoraFinVigencia = fechaFinVigencia.Split(' ');
            string[] subcadenaFechaFinVigencia = subcadenaFechaYHoraFinVigencia[0].Split('/');

            int anio = int.Parse(subcadenaFechaInicioVigencia[2]);
            int bnio = Convert.ToInt32(subcadenaFecha[2]);
            int cnio = Convert.ToInt32(subcadenaFechaFinVigencia[2]);

            int ames = Convert.ToInt32(subcadenaFechaInicioVigencia[1]);
            int bmes = Convert.ToInt32(subcadenaFecha[1]);
            int cmes = Convert.ToInt32(subcadenaFechaFinVigencia[1]);

            int adia = Convert.ToInt32(subcadenaFechaInicioVigencia[0]);
            int bdia = Convert.ToInt32(subcadenaFecha[0]);
            int cdia = Convert.ToInt32(subcadenaFechaFinVigencia[0]);

            bool banderaMayorInicio = false;
            bool banderaMenorFin = false;

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

            if (banderaMayorInicio && banderaMenorFin)
            {
                return true;
            }
            else
            {
                return false;
            }

            //if (anio <= bnio && bnio <= cnio)
            //{
            //    if (ames <= bmes && bmes <= cmes)
            //    {
            //        if (adia <= bdia && bdia <= cdia)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //else
            //{
            //    return false;
            //}
        }


        public string getTarifa(string id_tarifa)
        {
            TipoEntrada tipoEntrada = new TipoEntrada();
            TipoVisita tipoVisita = new TipoVisita();
            string sql = "SELECT monto, montoAdicional FROM Tarifa WHERE id_tarifa = " + id_tarifa;
            DataTable tabla = _bd.EjecutarSelect(sql);
            string tarifa = "";
            string nombreEntrada= tipoEntrada.getNombreTipoEntrada(id_tarifa);
            string nombreVisita = tipoVisita.getNombreTipoVisita(id_tarifa);
            tarifa = (id_tarifa + ", " + nombreEntrada + ", " + nombreVisita + ", " + tabla.Rows[0][0].ToString() + ", " + tabla.Rows[0][1].ToString());
            return tarifa;
            
           
        }
    }
}
