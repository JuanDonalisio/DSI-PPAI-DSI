using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace DSI_PPAI.Clases
{
    class ImpresorEntradas
    {
        public void New(DataTable Tabla, bool guia, int i)
        {
            string deviceInfo = "";
            string[] streamIds;
            Warning[] warnings;

            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;
            ReportViewer reporte_entrada = new ReportViewer();
            reporte_entrada.ProcessingMode = ProcessingMode.Local;
            //reporte_entrada.LocalReport.ReportPath = "DSI_PPAI\\Forms\\Entrada.rdlc";


            string restriccion = "";
            if (guia)
            {
                restriccion = "Si";
            }
            else
            {
                restriccion = "No";
            }

            ReportDataSource datos = new ReportDataSource("DataSet1", Tabla);

            reporte_entrada.LocalReport.ReportEmbeddedResource = "DSI_PPAI.Forms.Entrada.rdlc";
            reporte_entrada.LocalReport.DataSources.Clear();
            reporte_entrada.LocalReport.DataSources.Add(datos);
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RPRestriccion", restriccion);
            reporte_entrada.LocalReport.SetParameters(parametro);
            reporte_entrada.RefreshReport();

            var bytes = reporte_entrada.LocalReport.Render("PDF", deviceInfo, out mimeType, out encoding, out extension, out streamIds, out warnings);

            string fileName = @"Entrada" + i + ".pdf";
            File.WriteAllBytes(fileName, bytes);
            System.Diagnostics.Process.Start(fileName);

        }
    }
}
