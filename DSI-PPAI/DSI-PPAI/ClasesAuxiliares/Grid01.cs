using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DSI_PPAI.ClasesAuxiliares
{
    class Grid01 : DataGridView
    {
        /// <summary>
        /// Esta función permite darle a la grilla el siguiente formato
        /// dentro del parametro de entrada como texto:
        /// (textoCabecera, ancho; ...; textCabecera, ancho)
        /// </summary>
        /// <param name="formato"></param>
        public void Formatear(string formato) // para que el DataGridView tenga el formato, hago un estandar
        {
            string[] datos_Columna = formato.Split(';'); // dice que fraccione el ingreso en distintos indices (texto cabera+ancho)

            for (int i = 0; i < datos_Columna.Length; i++)
            {
                string[] datos = datos_Columna[i].Split(',');
                this.Columns.Add("columna" + i.ToString(), datos[0].ToString());
                // me obliga a poner el nombre de la columna y el texto del header
                this.Columns[i].Width = int.Parse(datos[1].ToString());
                // con esto se cual es el ancho de la columna porque esta en el segundo indice de la matriz datos
            }
        }

        public void Cargar(DataTable tabla)
        {
            this.Rows.Clear();
            for (int fila = 0; fila < tabla.Rows.Count; fila++)
            {
                this.Rows.Add();
                for (int columna = 0; columna < tabla.Columns.Count; columna++)
                {
                    this.Rows[fila].Cells[columna].Value = tabla.Rows[fila][columna];
                }
            }
        }
    }
}
