using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_PPAI.DBconection;
using System.Data;

namespace DSI_PPAI.ClasesAuxiliares
{
    class ComboBox01 : ComboBox
    {
        //Creo que se pueden sacar las 3 primeras Pp
        //public string Pp_Pk { get; set; }
        //public string Pp_descripcion { get; set; }
        //public string Pp_tabla { get; set; }
        public bool Pp_Conseleccion { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }
        public string Pp_NombreCampo { get; set; }

        Acceso_Datos _BD = new Acceso_Datos();

        public void CargarCombo(EstructuraComboBox edc)
        {

            this.DisplayMember = edc.Display;
            this.ValueMember = edc.Value;
            this.DataSource = edc.Tabla;

            if (this.Pp_Conseleccion == true)
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedIndex = -1;
            }
        }

        public void CargarComboTipoEntrada(DataTable tabla)
        {
            this.ValueMember = "id_tipo_entrada";
            this.DisplayMember = "nombre_tipo_entrada";
            this.DataSource = tabla;

            if (this.Pp_Conseleccion == true)
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedIndex = -1;
                this.Text = "Haga una selección";
            }
        }

        public void CargarComboTipoVisita(DataTable tabla)
        {
            this.ValueMember = "id_tipo_visita";
            this.DisplayMember = "nombre_tipo_visita";
            this.DataSource = tabla;

            if (this.Pp_Conseleccion == true)
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedIndex = -1;
                this.Text = "Haga una selección";
            }
        }
    }
}
