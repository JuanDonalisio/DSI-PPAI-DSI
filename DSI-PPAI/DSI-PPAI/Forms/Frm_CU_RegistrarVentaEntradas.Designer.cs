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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CU_RegistrarVentaEntradas));
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.cargar_tarifa_seleccionada = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cb_guia = new System.Windows.Forms.CheckBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.grid_detalles = new DSI_PPAI.ClasesAuxiliares.Grid01();
            this.grid_tarifa_seleccionada = new DSI_PPAI.ClasesAuxiliares.Grid01();
            this.grid_tarifas = new DSI_PPAI.ClasesAuxiliares.Grid01();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tarifa_seleccionada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(368, 363);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(105, 29);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(226, 363);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(119, 29);
            this.txt_cantidad.TabIndex = 6;
            // 
            // cargar_tarifa_seleccionada
            // 
            this.cargar_tarifa_seleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargar_tarifa_seleccionada.Location = new System.Drawing.Point(368, 181);
            this.cargar_tarifa_seleccionada.Name = "cargar_tarifa_seleccionada";
            this.cargar_tarifa_seleccionada.Size = new System.Drawing.Size(146, 29);
            this.cargar_tarifa_seleccionada.TabIndex = 7;
            this.cargar_tarifa_seleccionada.Text = "Seleccionar tarifa";
            this.cargar_tarifa_seleccionada.UseVisualStyleBackColor = true;
            this.cargar_tarifa_seleccionada.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(129)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(223, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccionar tarifa vigente de la sede actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(129)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(223, 339);
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
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(129)))), ((int)(((byte)(244)))));
            this.label5.Location = new System.Drawing.Point(223, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Detalle de las entradas:";
            // 
            // Confirmar
            // 
            this.Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar.Location = new System.Drawing.Point(889, 431);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(99, 29);
            this.Confirmar.TabIndex = 12;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(889, 474);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 29);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cb_guia
            // 
            this.cb_guia.AutoSize = true;
            this.cb_guia.BackColor = System.Drawing.Color.Transparent;
            this.cb_guia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_guia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(129)))), ((int)(((byte)(244)))));
            this.cb_guia.Location = new System.Drawing.Point(226, 181);
            this.cb_guia.Name = "cb_guia";
            this.cb_guia.Size = new System.Drawing.Size(118, 20);
            this.cb_guia.TabIndex = 13;
            this.cb_guia.Text = "Visita guiada";
            this.cb_guia.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // grid_detalles
            // 
            this.grid_detalles.AllowUserToAddRows = false;
            this.grid_detalles.AllowUserToDeleteRows = false;
            this.grid_detalles.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_detalles.Location = new System.Drawing.Point(226, 431);
            this.grid_detalles.Name = "grid_detalles";
            this.grid_detalles.ReadOnly = true;
            this.grid_detalles.Size = new System.Drawing.Size(642, 72);
            this.grid_detalles.TabIndex = 11;
            // 
            // grid_tarifa_seleccionada
            // 
            this.grid_tarifa_seleccionada.AllowUserToAddRows = false;
            this.grid_tarifa_seleccionada.AllowUserToDeleteRows = false;
            this.grid_tarifa_seleccionada.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_tarifa_seleccionada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tarifa_seleccionada.Location = new System.Drawing.Point(226, 242);
            this.grid_tarifa_seleccionada.Name = "grid_tarifa_seleccionada";
            this.grid_tarifa_seleccionada.ReadOnly = true;
            this.grid_tarifa_seleccionada.Size = new System.Drawing.Size(750, 78);
            this.grid_tarifa_seleccionada.TabIndex = 3;
            this.grid_tarifa_seleccionada.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_tarifa_seleccionada_CellDoubleClick);
            // 
            // grid_tarifas
            // 
            this.grid_tarifas.AllowUserToAddRows = false;
            this.grid_tarifas.AllowUserToDeleteRows = false;
            this.grid_tarifas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_tarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tarifas.Location = new System.Drawing.Point(226, 38);
            this.grid_tarifas.Name = "grid_tarifas";
            this.grid_tarifas.ReadOnly = true;
            this.grid_tarifas.Size = new System.Drawing.Size(750, 128);
            this.grid_tarifas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(129)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(223, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tarifa seleccionada:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_CU_RegistrarVentaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_guia);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.grid_detalles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cargar_tarifa_seleccionada);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.grid_tarifa_seleccionada);
            this.Controls.Add(this.grid_tarifas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private ClasesAuxiliares.Grid01 grid_tarifas;
        private System.Windows.Forms.Button btn_agregar;
        private ClasesAuxiliares.Grid01 grid_tarifa_seleccionada;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button cargar_tarifa_seleccionada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ClasesAuxiliares.Grid01 grid_detalles;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.CheckBox cb_guia;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
    }
}