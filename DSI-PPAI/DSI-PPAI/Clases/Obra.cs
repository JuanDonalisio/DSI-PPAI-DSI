using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DBconection;

namespace DSI_PPAI.Clases
{
    class Obra
    {
        Acceso_Datos _BD = new Acceso_Datos();
        public int[] getDuracionResumida(System.Data.DataTable id_obras)
        {
            int[] contador = new int[3];
            contador[0] = 0;
            contador[1] = 0;
            contador[2] = 0;

            for (int i = 0; i < id_obras.Rows.Count; i++)
            {
                string sql = "SELECT duracionResumida FROM Obra WHERE id_obra = " + id_obras.Rows[i][0].ToString();
                string duracion = _BD.EjecutarSelect(sql).Rows[0][0].ToString();
                string[] subcadenaDuracion = duracion.Split(':');

                contador[0] += int.Parse(subcadenaDuracion[0]);
                contador[1] += int.Parse(subcadenaDuracion[1]);
                contador[2] += int.Parse(subcadenaDuracion[2]);
            }

            if(contador[2] >= 60)
            {
                int numero = (contador[2] / 60);
                contador[1] += numero;
                contador[2] = contador[2] % 60;
            }

            if(contador[1] >= 60)
            {
                int numero = (contador[1] / 60);
                contador[0] += numero;
                contador[1] = contador[1] % 60;
            }

            return contador;

        }
    }
}
