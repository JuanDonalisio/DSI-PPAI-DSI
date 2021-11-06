using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Clases
{
    public interface ISujeto
    {
        void suscribir(IObservadorActualizacionVisitantes observador);
        void quitar(IObservadorActualizacionVisitantes observador);
        void Notificar();
    }
}
