using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DBconection;
using DSI_PPAI.ClasesAuxiliares;
using DSI_PPAI.DBconection;
using System.Data;
using System.Windows.Forms;


namespace DSI_PPAI.Clases
{
    class Entrada
    {
        private string fechaVenta;
        private string horaVenta;
        private string monto;
        private string numero;
        Acceso_Datos _bd = new Acceso_Datos();

        public bool esTuFecha(string fechaEntrada,string fechaActual) {

            string[] subcadenasFechaYHoraActual = fechaActual.Split(' ');
            string[] subcadenasFechaActual = subcadenasFechaYHoraActual[0].Split('/');

            string[] subcadenasFechaYHoraEntrada = fechaEntrada.Split(' ');
            string[] subcadenasFechaEntrada = subcadenasFechaYHoraEntrada[0].Split('/');
            
            int anio = int.Parse(subcadenasFechaActual[2]);
            int bnio = Convert.ToInt32(subcadenasFechaEntrada[2]);

            int ames = Convert.ToInt32(subcadenasFechaActual[1]);
            int bmes = Convert.ToInt32(subcadenasFechaEntrada[1]);

            int adia = Convert.ToInt32(subcadenasFechaActual[0]);
            int bdia = Convert.ToInt32(subcadenasFechaEntrada[0]);


            if (anio == bnio)
            {
                if (ames == bmes)
                {
                    if (adia == bdia)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public int getNro(string id_sede)
        {
            string sql = "SELECT id_entrada FROM Entrada WHERE id_sede = " + id_sede;
            DataTable tabla = _bd.EjecutarSelect(sql);
            int maximo = 0;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if(maximo < int.Parse(tabla.Rows[i][0].ToString()))
                {
                    maximo = int.Parse(tabla.Rows[i][0].ToString());
                }
            }
            return maximo+1;
        }
    }
}
