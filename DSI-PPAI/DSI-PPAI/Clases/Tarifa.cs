using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DSI_PPAI.ClasesAuxiliares;
using DSI_PPAI.Clases;
using DSI_PPAI.DBconection;

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

        public EstructuraComboBox GetNombreTipoEntrada()
        {
            return(tipo_entrada.GetNombre());
        }

        public EstructuraComboBox GetNombreTipoVisita()
        {
            return(tipo_visita.GetNombre());
        }

        //Si la fecha actual esta en rango de vigencia devuelve true
        public bool esVigente(string fechaActual, string fechaInicioVigencia, string fechaFinVigencia)
        {
            string[] subcadenaFechaYHora = fechaActual.Split(' ');
            string[] subcadenaFecha = subcadenaFechaYHora[0].Split('/');

            string[] subcadenaFechaInicioVigencia = fechaInicioVigencia.Split('/');

            string[] subcadenaFechaFinVigencia = fechaFinVigencia.Split('/');
            var anio = Convert.ToInt32(subcadenaFechaInicioVigencia[2]);
            var bnio = Convert.ToInt32(subcadenaFecha[2]);
            var cnio = Convert.ToInt32(subcadenaFechaFinVigencia[2]);

            var ames = Convert.ToInt32(subcadenaFechaInicioVigencia[1]);
            var bmes = Convert.ToInt32(subcadenaFecha[1]);
            var cmes = Convert.ToInt32(subcadenaFechaFinVigencia[1]);

            var adia = Convert.ToInt32(subcadenaFechaInicioVigencia[0]);
            var bdia = Convert.ToInt32(subcadenaFecha[0]);
            var cdia = Convert.ToInt32(subcadenaFechaFinVigencia[0]);

            if (anio <= bnio && bnio <= cnio) {
                if (ames <= bmes && bmes <= cmes)
                {
                    if (adia <= bdia && bdia <= cdia)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }


        public string getTarifa() {
            TipoEntrada tipoE = new TipoEntrada();
            TipoVisita tipoV = new TipoVisita();
            string nombreE= tipoE.getTipoEntrada();
            string nombreV = tipoV.getTipoVisita();
            return null;
            
           
        }
    }
}
