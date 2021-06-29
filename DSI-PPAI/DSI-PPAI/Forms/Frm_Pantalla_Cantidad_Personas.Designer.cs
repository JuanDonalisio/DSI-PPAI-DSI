namespace DSI_PPAI.Forms
{
    partial class Frm_Pantalla_Cantidad_Personas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reporte_entrada = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporte_entrada
            // 
            this.reporte_entrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporte_entrada.LocalReport.ReportEmbeddedResource = "DSI_PPAI.Forms.Report1.rdlc";
            this.reporte_entrada.Location = new System.Drawing.Point(0, 0);
            this.reporte_entrada.Name = "reporte_entrada";
            this.reporte_entrada.ServerReport.BearerToken = null;
            this.reporte_entrada.Size = new System.Drawing.Size(574, 327);
            this.reporte_entrada.TabIndex = 0;
            // 
            // Frm_Pantalla_Cantidad_Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 327);
            this.ControlBox = false;
            this.Controls.Add(this.reporte_entrada);
            this.Name = "Frm_Pantalla_Cantidad_Personas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Entrada_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_entrada;
    }
}