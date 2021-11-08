using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DSI_PPAI.Clases;


namespace DSI_PPAI.Forms
{
    public partial class Frm_Pantalla_Cantidad_Personas : Form, IObservadorActualizacionVisitantes
    {
        public int total_actual { get; set; }
        public int cant_max { get; set; }
        public Frm_Pantalla_Cantidad_Personas()
        {
            InitializeComponent();
        }

        private void Frm_Entrada_Load(object sender, EventArgs e)
        {
            CargarReporte();
            this.reporte_entrada.RefreshReport();
        }

        private void CargarReporte()
        {
            string restriccion = "";

            restriccion = total_actual.ToString() + "/" + cant_max.ToString();

            reporte_entrada.LocalReport.ReportEmbeddedResource = "DSI_PPAI.Forms.Report1.rdlc";
            reporte_entrada.LocalReport.DataSources.Clear();
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RPRestriccion", restriccion);
            reporte_entrada.LocalReport.SetParameters(parametro);
            reporte_entrada.RefreshReport();
            
        }

        public void actualizarCantVisitantes(int cantVisitantes, int cantMaxVisitantesDeSede)
        {
            this.total_actual = cantVisitantes;
            this.cant_max = cantMaxVisitantesDeSede;

            //throw new NotImplementedException();
        }
    }
}
