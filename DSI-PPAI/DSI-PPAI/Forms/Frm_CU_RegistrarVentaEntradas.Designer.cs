﻿namespace DSI_PPAI.Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.grid_tarifas = new DSI_PPAI.ClasesAuxiliares.Grid01();
            this.cmb_tipo_entrada = new DSI_PPAI.ClasesAuxiliares.ComboBox01();
            this.cmb_tipo_visita = new DSI_PPAI.ClasesAuxiliares.ComboBox01();
            this.grid_entradas = new DSI_PPAI.ClasesAuxiliares.Grid01();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_entradas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de visita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de entrada";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(126, 319);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 29);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // grid_tarifas
            // 
            this.grid_tarifas.AllowUserToAddRows = false;
            this.grid_tarifas.AllowUserToDeleteRows = false;
            this.grid_tarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tarifas.Location = new System.Drawing.Point(12, 66);
            this.grid_tarifas.Name = "grid_tarifas";
            this.grid_tarifas.ReadOnly = true;
            this.grid_tarifas.Size = new System.Drawing.Size(978, 231);
            this.grid_tarifas.TabIndex = 3;
            // 
            // cmb_tipo_entrada
            // 
            this.cmb_tipo_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_entrada.FormattingEnabled = true;
            this.cmb_tipo_entrada.Location = new System.Drawing.Point(171, 21);
            this.cmb_tipo_entrada.Name = "cmb_tipo_entrada";
            this.cmb_tipo_entrada.Pp_Conseleccion = false;
            this.cmb_tipo_entrada.Pp_MensajeError = null;
            this.cmb_tipo_entrada.Pp_NombreCampo = null;
            this.cmb_tipo_entrada.Pp_Validable = false;
            this.cmb_tipo_entrada.Size = new System.Drawing.Size(143, 28);
            this.cmb_tipo_entrada.TabIndex = 0;
            this.cmb_tipo_entrada.SelectionChangeCommitted += new System.EventHandler(this.cmb_tipo_entrada_SelectionChangeCommitted);
            // 
            // cmb_tipo_visita
            // 
            this.cmb_tipo_visita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_visita.FormattingEnabled = true;
            this.cmb_tipo_visita.Location = new System.Drawing.Point(504, 21);
            this.cmb_tipo_visita.Name = "cmb_tipo_visita";
            this.cmb_tipo_visita.Pp_Conseleccion = false;
            this.cmb_tipo_visita.Pp_MensajeError = null;
            this.cmb_tipo_visita.Pp_NombreCampo = null;
            this.cmb_tipo_visita.Pp_Validable = false;
            this.cmb_tipo_visita.Size = new System.Drawing.Size(143, 28);
            this.cmb_tipo_visita.TabIndex = 0;
            // 
            // grid_entradas
            // 
            this.grid_entradas.AllowUserToAddRows = false;
            this.grid_entradas.AllowUserToDeleteRows = false;
            this.grid_entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_entradas.Location = new System.Drawing.Point(12, 374);
            this.grid_entradas.Name = "grid_entradas";
            this.grid_entradas.ReadOnly = true;
            this.grid_entradas.Size = new System.Drawing.Size(978, 152);
            this.grid_entradas.TabIndex = 3;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(12, 319);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 29);
            this.txt_cantidad.TabIndex = 6;
            // 
            // Frm_CU_RegistrarVentaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 649);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_entradas);
            this.Controls.Add(this.grid_tarifas);
            this.Controls.Add(this.cmb_tipo_entrada);
            this.Controls.Add(this.cmb_tipo_visita);
            this.Name = "Frm_CU_RegistrarVentaEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Venta de Entradas";
            this.Load += new System.EventHandler(this.Frm_CU_RegistrarVentaEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_entradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClasesAuxiliares.ComboBox01 cmb_tipo_visita;
        private ClasesAuxiliares.ComboBox01 cmb_tipo_entrada;
        private ClasesAuxiliares.Grid01 grid_tarifas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agregar;
        private ClasesAuxiliares.Grid01 grid_entradas;
        private System.Windows.Forms.TextBox txt_cantidad;
    }
}