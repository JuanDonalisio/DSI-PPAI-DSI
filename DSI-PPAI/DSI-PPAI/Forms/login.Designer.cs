namespace DSI_PPAI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_ocultar_contrasena = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_ver_contrasena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(524, 273);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(183, 20);
            this.txt_password.TabIndex = 20;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(525, 216);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(182, 20);
            this.txt_usuario.TabIndex = 19;
            // 
            // btn_ocultar_contrasena
            // 
            this.btn_ocultar_contrasena.BackColor = System.Drawing.Color.Transparent;
            this.btn_ocultar_contrasena.BackgroundImage = global::DSI_PPAI.Properties.Resources.novistoo;
            this.btn_ocultar_contrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ocultar_contrasena.Location = new System.Drawing.Point(720, 271);
            this.btn_ocultar_contrasena.Name = "btn_ocultar_contrasena";
            this.btn_ocultar_contrasena.Size = new System.Drawing.Size(34, 26);
            this.btn_ocultar_contrasena.TabIndex = 18;
            this.btn_ocultar_contrasena.UseVisualStyleBackColor = false;
            this.btn_ocultar_contrasena.Click += new System.EventHandler(this.btn_ocultar_contrasena_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(524, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(525, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Usuario";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Transparent;
            this.btn_aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.BackgroundImage")));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_aceptar.Location = new System.Drawing.Point(524, 351);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(130, 45);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancelar.Location = new System.Drawing.Point(661, 351);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(130, 45);
            this.btn_cancelar.TabIndex = 22;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_ver_contrasena
            // 
            this.btn_ver_contrasena.BackColor = System.Drawing.Color.Transparent;
            this.btn_ver_contrasena.BackgroundImage = global::DSI_PPAI.Properties.Resources.vistoo;
            this.btn_ver_contrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ver_contrasena.Location = new System.Drawing.Point(720, 271);
            this.btn_ver_contrasena.Name = "btn_ver_contrasena";
            this.btn_ver_contrasena.Size = new System.Drawing.Size(34, 26);
            this.btn_ver_contrasena.TabIndex = 17;
            this.btn_ver_contrasena.UseVisualStyleBackColor = false;
            this.btn_ver_contrasena.Click += new System.EventHandler(this.btn_ver_contrasena_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_ver_contrasena);
            this.Controls.Add(this.btn_ocultar_contrasena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_ocultar_contrasena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_ver_contrasena;
    }
}

