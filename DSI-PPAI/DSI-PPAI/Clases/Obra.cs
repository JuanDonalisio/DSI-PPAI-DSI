using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Clases
{
    class Obra
    {
        public int getDuracionResumida(System.Data.DataTable id_obras) {
            int contador = 0;

            for (int i = 0; i < id_obras.Rows.Count; i++)
            {
                contador = contador + int.Parse(id_obras.Rows[i][2].ToString());
            }
            return contador;

        }
    }
}
