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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CU_RegistrarVentaEntradas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.cargar_tarifa_seleccionada = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grid_detalles = new DSI_PPAI.ClasesAuxiliares.Grid01();
            this.grid_tarifa_seleccionada = new DSI_PPAI.ClasesAuxiliares.Grid01();
            this.grid_tarifas = new DSI_PPAI.ClasesAuxiliares.Grid01();
            this.cmb_tipo_entrada = new DSI_PPAI.ClasesAuxiliares.ComboBox01();
            this.cmb_tipo_visita = new DSI_PPAI.ClasesAuxiliares.ComboBox01();
            this.Confirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tarifa_seleccionada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(310, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de visita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de entrada";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(126, 371);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 29);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(12, 371);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 29);
            this.txt_cantidad.TabIndex = 6;
            // 
            // cargar_tarifa_seleccionada
            // 
            this.cargar_tarifa_seleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargar_tarifa_seleccionada.Location = new System.Drawing.Point(656, 38);
            this.cargar_tarifa_seleccionada.Name = "cargar_tarifa_seleccionada";
            this.cargar_tarifa_seleccionada.Size = new System.Drawing.Size(120, 29);
            this.cargar_tarifa_seleccionada.TabIndex = 7;
            this.cargar_tarifa_seleccionada.Text = "Seleccionar";
            this.cargar_tarifa_seleccionada.UseVisualStyleBackColor = true;
            this.cargar_tarifa_seleccionada.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccionar tarifa vigentes de la sede actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Agregar cantidad de entradas para la tarifa seleccionada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Detalle de las entradas:";
            // 
            // grid_detalles
            // 
            this.grid_detalles.AllowUserToAddRows = false;
            this.grid_detalles.AllowUserToDeleteRows = false;
            this.grid_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_detalles.Location = new System.Drawing.Point(12, 535);
            this.grid_detalles.Name = "grid_detalles";
            this.grid_detalles.ReadOnly = true;
            this.grid_detalles.Size = new System.Drawing.Size(656, 61);
            this.grid_detalles.TabIndex = 11;
            this.grid_detalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_detalles_CellContentClick);
            // 
            // grid_tarifa_seleccionada
            // 
            this.grid_tarifa_seleccionada.AllowUserToAddRows = false;
            this.grid_tarifa_seleccionada.AllowUserToDeleteRows = false;
            this.grid_tarifa_seleccionada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tarifa_seleccionada.Location = new System.Drawing.Point(12, 406);
            this.grid_tarifa_seleccionada.Name = "grid_tarifa_seleccionada";
            this.grid_tarifa_seleccionada.ReadOnly = true;
            this.grid_tarifa_seleccionada.Size = new System.Drawing.Size(840, 64);
            this.grid_tarifa_seleccionada.TabIndex = 3;
            // 
            // grid_tarifas
            // 
            this.grid_tarifas.AllowUserToAddRows = false;
            this.grid_tarifas.AllowUserToDeleteRows = false;
            this.grid_tarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tarifas.Location = new System.Drawing.Point(12, 84);
            this.grid_tarifas.Name = "grid_tarifas";
            this.grid_tarifas.ReadOnly = true;
            this.grid_tarifas.Size = new System.Drawing.Size(840, 231);
            this.grid_tarifas.TabIndex = 3;
            // 
            // cmb_tipo_entrada
            // 
            this.cmb_tipo_entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(139)))), ((int)(((byte)(70)))));
            this.cmb_tipo_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_entrada.FormattingEnabled = true;
            this.cmb_tipo_entrada.Location = new System.Drawing.Point(138, 39);
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
            this.cmb_tipo_visita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(139)))), ((int)(((byte)(70)))));
            this.cmb_tipo_visita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_visita.FormattingEnabled = true;
            this.cmb_tipo_visita.Location = new System.Drawing.Point(416, 39);
            this.cmb_tipo_visita.Name = "cmb_tipo_visita";
            this.cmb_tipo_visita.Pp_Conseleccion = false;
            this.cmb_tipo_visita.Pp_MensajeError = null;
            this.cmb_tipo_visita.Pp_NombreCampo = null;
            this.cmb_tipo_visita.Pp_Validable = false;
            this.cmb_tipo_visita.Size = new System.Drawing.Size(143, 28);
            this.cmb_tipo_visita.TabIndex = 0;
            // 
            // Confirmar
            // 
            this.Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar.Location = new System.Drawing.Point(685, 552);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(99, 29);
            this.Confirmar.TabIndex = 12;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            // 
            // Frm_CU_RegistrarVentaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(108)))), ((int)(((byte)(44)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 647);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.grid_detalles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cargar_tarifa_seleccionada);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_tarifa_seleccionada);
            this.Controls.Add(this.grid_tarifas);
            this.Controls.Add(this.cmb_tipo_entrada);
            this.Controls.Add(this.cmb_tipo_visita);
            this.Name = "Frm_CU_RegistrarVentaEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Venta de Entradas";
            this.Load += new System.EventHandler(this.Frm_CU_RegistrarVentaEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_detalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tarifa_seleccionada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tarifas)).EndInit();
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
        private ClasesAuxiliares.Grid01 grid_tarifa_seleccionada;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button cargar_tarifa_seleccionada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ClasesAuxiliares.Grid01 grid_detalles;
        private System.Windows.Forms.Button Confirmar;
    }
}