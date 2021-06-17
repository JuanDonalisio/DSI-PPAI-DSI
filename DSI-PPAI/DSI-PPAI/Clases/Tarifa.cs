using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DSI_PPAI.ClasesAuxiliares;

namespace DSI_PPAI.Clases
{
    class Tarifa
    {
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
    }
}
