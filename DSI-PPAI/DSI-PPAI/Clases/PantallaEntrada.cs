using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.Forms;

namespace DSI_PPAI.Clases
{
    class PantallaEntrada : IObservadorActualizacionVisitantes
    {
        public int cantVisitantes { get; set; }
        public int cantMaxVisitantesDeSede { get; set; }

        public void actualizarCantVisitantes(int cantVisitantes, int cantMaxVisitantesDeSede)
        {
            setCantVisitantes(cantVisitantes);
            setCantMaxVisitantesDeSede(cantMaxVisitantesDeSede);
            Frm_Pantalla_Entrada frm_entrada = new Frm_Pantalla_Entrada();
            frm_entrada.setDatos(cantVisitantes, cantMaxVisitantesDeSede);
            frm_entrada.ShowDialog();

        }

        public void setCantVisitantes(int cantVisitantes)
        {
            this.cantVisitantes = cantVisitantes;
        }

        public void setCantMaxVisitantesDeSede(int cantMaxVisitantesDeSede)
        {
            this.cantMaxVisitantesDeSede = cantMaxVisitantesDeSede;
        }
    }
}
