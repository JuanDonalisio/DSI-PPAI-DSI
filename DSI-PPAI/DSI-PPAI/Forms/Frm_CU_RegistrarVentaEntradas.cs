using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_PPAI.Clases;
using DSI_PPAI.ClasesAuxiliares;
using System.Collections.Generic;

namespace DSI_PPAI.Forms
{
    public partial class Frm_CU_RegistrarVentaEntradas : Form
    {
        public string nombre_usuario { get; set; }
        EstructuraComboBox estructuraTipoEntrada = new EstructuraComboBox();
        EstructuraComboBox estructuraTipoVisita = new EstructuraComboBox();
        public string id_usuario { get; set; }
        Tarifa tarifa = new Tarifa();
        GestorRegistrarVenta gestor = new GestorRegistrarVenta();
        public DataTable tablaDeTarifas;
        public DataTable tablaSinRepetidosEntrada;
        public Frm_CU_RegistrarVentaEntradas()
        {
            InitializeComponent();
        }

        private void Frm_CU_RegistrarVentaEntradas_Load(object sender, EventArgs e)
        {
            gestor.nombre_usuario = nombre_usuario;
            tablaDeTarifas = gestor.RegistrarVenta();
            TipoEntrada tipo_entrada = new TipoEntrada();
            TipoVisita tipo_visita = new TipoVisita();
            //tablaSinRepetidosEntrada = new DataTable();
            //tablaSinRepetidosEntrada.Columns.Add("id_tarifa", typeof(String));
            //tablaSinRepetidosEntrada.Columns.Add("id_tipo_entrada", typeof(String));
            //tablaSinRepetidosEntrada.Columns.Add("nombre_tipo_entrada", typeof(String));
            //tablaSinRepetidosEntrada.Columns.Add("id_tipo_visita", typeof(String));
            //tablaSinRepetidosEntrada.Columns.Add("nombre_tipo_visita", typeof(String));

            //List<string> tipo_entrada = new List<string>();

            //for (int i = 0; i < tablaDeTarifas.Rows.Count; i++)
            //{
            //    if (tipo_entrada.Any(x => x == tablaDeTarifas.Rows[i][1].ToString()))
            //    {

            //    }
            //    else
            //    {
            //        tipo_entrada.Add(tablaDeTarifas.Rows[i][1].ToString());
            //        tablaSinRepetidosEntrada.Rows.Add(tablaDeTarifas.Rows[i][0].ToString(), tablaDeTarifas.Rows[i][1].ToString(), tablaDeTarifas.Rows[i][2].ToString(), tablaDeTarifas.Rows[i][3].ToString(), tablaDeTarifas.Rows[i][4].ToString());
            //    }
            //}
            //cmb_tipo_entrada.CargarComboTipoEntrada(tablaSinRepetidosEntrada);
            cmb_tipo_entrada.CargarCombo(tipo_entrada.GetTipoEntrada());
            cmb_tipo_visita.CargarCombo(tipo_visita.GetTipoVisita());
            grid_tarifas.Formatear("Tipo de Entrada,200; Tipo de Visita,200; Monto,200; Monto Adicional por Guía,200");
            grid_tarifa_seleccionada.Formatear("Tipo de Entrada,200; Tipo de Visita,200; Monto,200; Monto Adicional por Guía,200");
            CargarGrilla(tablaDeTarifas);
        }

        private void CargarGrilla(DataTable tabla)
        {
            grid_tarifas.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_tarifas.Rows.Add();
                grid_tarifas.Rows[i].Cells[0].Value = tabla.Rows[i]["nombre_tipo_entrada"].ToString();
                grid_tarifas.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre_tipo_visita"].ToString();
                grid_tarifas.Rows[i].Cells[2].Value = tabla.Rows[i]["monto"].ToString();
                grid_tarifas.Rows[i].Cells[3].Value = tabla.Rows[i]["montoAdicional"].ToString();
            }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (gestor.tomarCantidadDeEntradas(int.Parse(txt_cantidad.Text)))
            {
                MessageBox.Show("Todo ok");
            }
            else {
                MessageBox.Show("Excede el numero de visitantes maximo de la sede!");
            }
        }

        private void cmb_tipo_entrada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //cmb_tipo_visita.Enabled = true;
            //cmb_tipo_visita.Items.Clear();
            //if (cmb_tipo_entrada.SelectedIndex != -1)
            //{
            //    //Itera tantas veces como tipos de entrada haya
            //    for (int i = 0; i < tablaDeTarifas.Rows.Count; i++)
            //    {
            //        //Pregunta si el tipo de entrada de la tabla con TODAS las tarifas vigentes es igual 
            //        //al tipo de entrada de la tabla con los tipos de entrada sin repetir
            //        //Por cada tipo de entrada igual y repetido si se da la ocasión agregue el tipo de visita
            //        //TablaDeTarifas tiene todas las tarifas vigentes
            //        //TablaSinRepetidosEntrada tiene todos los tipos de entrada de las entradas vigentes sin repetir
            //        if (tablaDeTarifas.Rows[i][1].ToString() == cmb_tipo_entrada.SelectedValue.ToString())
            //        {
            //            ComboboxItem item = new ComboboxItem();
            //            item.Text = tablaDeTarifas.Rows[i][4].ToString();
            //            item.Value = tablaDeTarifas.Rows[i][3].ToString();
            //            cmb_tipo_visita.Items.Add(item);
            //        }
            //    }
                
            //}
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        //Carga en la segunda grilla la tarifa que seleccionamos
        private void button1_Click(object sender, EventArgs e)
        {
            int i = grid_tarifas.CurrentRow.Index;
            grid_tarifa_seleccionada.Rows.Add();
            grid_tarifa_seleccionada.Rows[0].Cells[0].Value = grid_tarifas.Rows[i].Cells[0].Value;
            grid_tarifa_seleccionada.Rows[0].Cells[1].Value = grid_tarifas.Rows[i].Cells[1].Value;
            grid_tarifa_seleccionada.Rows[0].Cells[2].Value = grid_tarifas.Rows[i].Cells[2].Value;
            grid_tarifa_seleccionada.Rows[0].Cells[3].Value = grid_tarifas.Rows[i].Cells[3].Value;
            gestor.tomarSeleccionTarifa();
        }
    }
}
