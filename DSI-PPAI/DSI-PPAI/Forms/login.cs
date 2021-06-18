using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_PPAI.Forms;
using DSI_PPAI.Clases;

namespace DSI_PPAI
{
    public partial class Login : Form
    {
        public string id_usuario { get; set; }
        NE_Login login = new NE_Login();
        public String Pp_usuario
        {
            get { return txt_usuario.Text; }
            set { txt_usuario.Text = value; }
        }


        public String Pp_password
        {
            get { return txt_password.Text; }
            set { txt_password.Text = value; }
        }


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btn_ver_contrasena.Hide();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                MessageBox.Show("La casilla de USUARIO se encuentra vacia");
                txt_usuario.Focus();
                return;
            }
            if (txt_password.Text == "")
            {
                MessageBox.Show("La casilla de PASSWORD se encuentra vacia");
                txt_password.Focus();
                return;
            }

            NE_Login.ResultadoValidacion resultado = login.Validar_Usuario(txt_usuario.Text, txt_password.Text);

            if (resultado == NE_Login.ResultadoValidacion.existe)
            {
                Frm_CU_ResponsableVentas RV = new Frm_CU_ResponsableVentas();
                //Empleado emp = new Empleado();
                //emp.legajo_empleado = int.Parse(id_usuario);
                GestorRegistrarVenta GV = new GestorRegistrarVenta();
                GV.nomUser = txt_usuario.Text;
                RV.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario y la password no coinciden con ninguno de nuestra Base Datos.");
                txt_usuario.Focus();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ver_contrasena_Click(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
            btn_ver_contrasena.Hide();
            btn_ocultar_contrasena.Show();
        }

        private void btn_ocultar_contrasena_Click(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '\0';
            btn_ocultar_contrasena.Hide();
            btn_ver_contrasena.Show();
        }

    }

}
