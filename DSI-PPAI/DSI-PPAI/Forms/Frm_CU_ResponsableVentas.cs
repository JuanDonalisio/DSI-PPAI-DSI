using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI_PPAI.Forms
{
    public partial class Frm_CU_ResponsableVentas : Form
    {

        public Frm_CU_ResponsableVentas()
        {
            InitializeComponent();
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_registrar_venta_entradas_Click(object sender, EventArgs e)
        {
            Frm_CU_RegistrarVentaEntradas registrarVenta = new Frm_CU_RegistrarVentaEntradas();
            registrarVenta.ShowDialog();
        }
    }
}
