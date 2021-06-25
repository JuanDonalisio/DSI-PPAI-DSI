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

namespace DSI_PPAI.Forms
{
    public partial class Frm_Entrada : Form
    {
        public DataTable Tabla { get; set; }
        public bool guia { get; set; }
        public Frm_Entrada()
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
            if(guia)
            {
                restriccion = "Si";
            }
            else
            {
                restriccion = "No";
            }

            ReportDataSource datos = new ReportDataSource("DataSet1", Tabla);

            reporte_entrada.LocalReport.ReportEmbeddedResource = "DSI_PPAI.Forms.Report1.rdlc";
            reporte_entrada.LocalReport.DataSources.Clear();
            reporte_entrada.LocalReport.DataSources.Add(datos);
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RPRestriccion", restriccion);
            reporte_entrada.LocalReport.SetParameters(parametro);
            reporte_entrada.RefreshReport();
        }
    }
}
