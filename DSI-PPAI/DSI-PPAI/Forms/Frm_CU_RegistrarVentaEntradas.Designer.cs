namespace DSI_PPAI.Forms
{
    partial class Frm_CU_RegistrarVentaEntradas
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
            this.cmb_tipo_visita = new DSI_PPAI.ClasesAuxiliares.ComboBox01();
            this.cmb_tipo_entrada = new DSI_PPAI.ClasesAuxiliares.ComboBox01();
            this.txt_monto = new DSI_PPAI.ClasesAuxiliares.TextBox01();
            this.cb01 = new System.Windows.Forms.CheckBox();
            this.grid_entradas = new DSI_PPAI.ClasesAuxiliares.Grid01();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_entradas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tipo_visita
            // 
            this.cmb_tipo_visita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_visita.FormattingEnabled = true;
            this.cmb_tipo_visita.Location = new System.Drawing.Point(207, 51);
            this.cmb_tipo_visita.Name = "cmb_tipo_visita";
            this.cmb_tipo_visita.Pp_Conseleccion = false;
            this.cmb_tipo_visita.Pp_MensajeError = null;
            this.cmb_tipo_visita.Pp_NombreCampo = null;
            this.cmb_tipo_visita.Pp_Validable = false;
            this.cmb_tipo_visita.Size = new System.Drawing.Size(121, 28);
            this.cmb_tipo_visita.TabIndex = 0;
            // 
            // cmb_tipo_entrada
            // 
            this.cmb_tipo_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_entrada.FormattingEnabled = true;
            this.cmb_tipo_entrada.Location = new System.Drawing.Point(207, 90);
            this.cmb_tipo_entrada.Name = "cmb_tipo_entrada";
            this.cmb_tipo_entrada.Pp_Conseleccion = false;
            this.cmb_tipo_entrada.Pp_MensajeError = null;
            this.cmb_tipo_entrada.Pp_NombreCampo = null;
            this.cmb_tipo_entrada.Pp_Validable = false;
            this.cmb_tipo_entrada.Size = new System.Drawing.Size(121, 28);
            this.cmb_tipo_entrada.TabIndex = 0;
            // 
            // txt_monto
            // 
            this.txt_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(456, 90);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Pp_campo = null;
            this.txt_monto.Pp_MensajeError = null;
            this.txt_monto.Pp_Validable = false;
            this.txt_monto.ReadOnly = true;
            this.txt_monto.Size = new System.Drawing.Size(100, 26);
            this.txt_monto.TabIndex = 1;
            // 
            // cb01
            // 
            this.cb01.AutoSize = true;
            this.cb01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb01.Location = new System.Drawing.Point(456, 58);
            this.cb01.Name = "cb01";
            this.cb01.Size = new System.Drawing.Size(95, 24);
            this.cb01.TabIndex = 2;
            this.cb01.Text = "Con Guía";
            this.cb01.UseVisualStyleBackColor = true;
            // 
            // grid_entradas
            // 
            this.grid_entradas.AllowUserToAddRows = false;
            this.grid_entradas.AllowUserToDeleteRows = false;
            this.grid_entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_entradas.Location = new System.Drawing.Point(12, 137);
            this.grid_entradas.Name = "grid_entradas";
            this.grid_entradas.ReadOnly = true;
            this.grid_entradas.Size = new System.Drawing.Size(776, 231);
            this.grid_entradas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de visita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de entrada";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(713, 89);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 28);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Frm_CU_RegistrarVentaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_entradas);
            this.Controls.Add(this.cb01);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.cmb_tipo_entrada);
            this.Controls.Add(this.cmb_tipo_visita);
            this.Name = "Frm_CU_RegistrarVentaEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Venta de Entradas";
            this.Load += new System.EventHandler(this.Frm_CU_RegistrarVentaEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_entradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClasesAuxiliares.ComboBox01 cmb_tipo_visita;
        private ClasesAuxiliares.ComboBox01 cmb_tipo_entrada;
        private ClasesAuxiliares.TextBox01 txt_monto;
        private System.Windows.Forms.CheckBox cb01;
        private ClasesAuxiliares.Grid01 grid_entradas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agregar;
    }
}