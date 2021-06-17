using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_PPAI.Clases;

namespace DSI_PPAI.Forms
{
    public partial class Frm_CU_RegistrarVentaEntradas : Form
    {
        Tarifa tarifa = new Tarifa();
        public Frm_CU_RegistrarVentaEntradas()
        {
            InitializeComponent();
        }

        private void Frm_CU_RegistrarVentaEntradas_Load(object sender, EventArgs e)
        {
            cmb_tipo_entrada.CargarCombo(tarifa.GetNombreTipoEntrada());
            cmb_tipo_visita.CargarCombo(tarifa.GetNombreTipoVisita());
            grid_entradas.Formatear("Tipo de Entrada,150; Tipo de Visita,150; Precio,150; Guía,150; Precio adicional guía,150");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
