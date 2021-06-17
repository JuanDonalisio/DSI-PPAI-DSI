using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI_PPAI.ClasesAuxiliares
{
    class TextBox01 : TextBox
    {
        //Creo que se puede sacar Pp_tabla
        //public string Pp_tabla { get; set; }
        public string Pp_campo { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }
    }
}
