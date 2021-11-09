using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.Forms;

namespace DSI_PPAI.Clases
{
    class PantallaSala : IObservadorActualizacionVisitantes
    {
        public int cantVisitantes { get; set; }
        public int cantMaxVisitantesDeSede { get; set; }

        public void actualizarCantVisitantes(int cantVisitantes, int cantMaxVisitantesDeSede)
        {
            setCantVisitantes(cantVisitantes);
            setCantMaxVisitantesDeSede(cantMaxVisitantesDeSede);
            Frm_Pantalla_Sala frm_sala = new Frm_Pantalla_Sala();
            frm_sala.ShowDialog();

        }

        public void setCantVisitantes(int cantVisitantes) {
            this.cantVisitantes = cantVisitantes;
        }

        public void setCantMaxVisitantesDeSede(int cantMaxVisitantesDeSede)
        {
            this.cantMaxVisitantesDeSede = cantMaxVisitantesDeSede;
        }
    }
}
