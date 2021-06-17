using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DBconection;
using DSI_PPAI.ClasesAuxiliares;

namespace DSI_PPAI.Clases
{
    class TipoEntrada
    {
        private string nombre;
        Acceso_Datos _BD = new Acceso_Datos();
        public EstructuraComboBox GetNombre()
        {
            EstructuraComboBox edc = new EstructuraComboBox();

            edc.Value = "id_tipo_entrada";
            edc.Display = "nombre";
            edc.Sql = "SELECT * FROM TipoDeEntrada";
            edc.Tabla = _BD.EjecutarSelect(edc.Sql);

            return edc;
        }

        public string getTipoEntrada() {
            return this.nombre;
        }

    }
}
