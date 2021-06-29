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
        public string nombre_usuario { get; set; }
        public Frm_CU_ResponsableVentas()
        {
            InitializeComponent();
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_registrar_venta_entradas_Click(object sender, EventArgs e)
        {
            Frm_CU_RegistrarVentaEntradas registrarVenta = new Frm_CU_RegistrarVentaEntradas();
            registrarVenta.nombre_usuario = nombre_usuario;
            registrarVenta.ShowDialog();
        }
    }
}
