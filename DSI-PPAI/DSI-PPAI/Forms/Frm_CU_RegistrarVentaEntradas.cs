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
        public int[] cant_max_y_total { get; set; }
        public int nro_entrada { get; set; }
        public bool entrada_vendida { get; set; }
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
            //bandera que indica si si vendió alguna entrada
            entrada_vendida = false;

            gestor.nombre_usuario = nombre_usuario;
            tablaDeTarifas = gestor.RegistrarVenta();

            //Cargo los nombres de columna de los grid
            grid_tarifas.Formatear("Tipo de Entrada,200; Tipo de Visita,200; Monto,200; Monto Adicional por Guía,200");
            grid_tarifa_seleccionada.Formatear("Tipo de Entrada,200; Tipo de Visita,200; Monto,200; Monto Adicional por Guía,200");
            grid_detalles.Formatear("Monto total,200; Precio por unidad,200; Cantidad de entradas,200");
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
            if (grid_tarifa_seleccionada.Rows.Count != 0)
            {
                cant_max_y_total = gestor.tomarCantidadDeEntradas(int.Parse(txt_cantidad.Text));
                if (cant_max_y_total[1] <= cant_max_y_total[0])
                {
                    int montoGuia = int.Parse(grid_tarifa_seleccionada.Rows[0].Cells[3].Value.ToString());
                    int precioEntrada = int.Parse(grid_tarifa_seleccionada.Rows[0].Cells[2].Value.ToString());
                    int cantEntradas = int.Parse(txt_cantidad.Text);
                    int montoTotal = gestor.calcularTotalAPagar(precioEntrada,montoGuia,cantEntradas);
                    grid_detalles.Rows.Clear();
                    grid_detalles.Rows.Add();
                    grid_detalles.Rows[0].Cells[0].Value = montoTotal;
                    if(cb_guia.Checked == true)
                    {
                        grid_detalles.Rows[0].Cells[1].Value = precioEntrada + montoGuia;
                    }
                    else
                    {
                        grid_detalles.Rows[0].Cells[1].Value = precioEntrada;
                    }
                    
                    grid_detalles.Rows[0].Cells[2].Value = cantEntradas;

                }
                else
                {
                    MessageBox.Show("Excede el numero de visitantes maximo de la sede!");
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna tarifa");
            }
            
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
            grid_tarifa_seleccionada.Rows.Clear();
            int i = grid_tarifas.CurrentRow.Index;
            grid_tarifa_seleccionada.Rows.Add();
            grid_tarifa_seleccionada.Rows[0].Cells[0].Value = grid_tarifas.Rows[i].Cells[0].Value;
            grid_tarifa_seleccionada.Rows[0].Cells[1].Value = grid_tarifas.Rows[i].Cells[1].Value;
            grid_tarifa_seleccionada.Rows[0].Cells[2].Value = grid_tarifas.Rows[i].Cells[2].Value;
            grid_tarifa_seleccionada.Rows[0].Cells[3].Value = grid_tarifas.Rows[i].Cells[3].Value;
            gestor.tomarSeleccionTarifa();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que desea cancelar la venta?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void grid_tarifa_seleccionada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar la tarifa seleccionada?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_tarifa_seleccionada.Rows.Remove(grid_tarifa_seleccionada.CurrentRow);
                if(grid_detalles.Rows.Count != 0)
                {
                    grid_detalles.Rows.Clear();
                }
            }
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea confirmar la venta?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < int.Parse(txt_cantidad.Text); i++)
                {
                    nro_entrada = gestor.confirmarVenta(grid_tarifa_seleccionada.Rows[0].Cells[0].Value.ToString(), grid_tarifa_seleccionada.Rows[0].Cells[1].Value.ToString(), grid_detalles.Rows[0].Cells[1].Value.ToString());
                    DataTable tabla = new DataTable();
                    tabla.Columns.Add("id_entrada", typeof(Int64));
                    tabla.Columns.Add("nombre_tipo_entrada", typeof(String));
                    tabla.Columns.Add("nombre_tipo_visita", typeof(String));
                    tabla.Columns.Add("monto_unitario", typeof(Int64));
                    tabla.Rows.Add(nro_entrada, grid_tarifa_seleccionada.Rows[0].Cells[0].Value.ToString(), grid_tarifa_seleccionada.Rows[0].Cells[1].Value.ToString(), int.Parse(grid_detalles.Rows[0].Cells[1].Value.ToString()));
                    gestor.imprimirEntradas(tabla, cb_guia.Checked, i);
                }
                gestor.actVisitantesEnPantallas();
                this.Close();


                //habria que meter estos pasos de abajo en el metodo confirmarVenta?
                //PantallaEntrada pantalla = new PantallaEntrada();
                //PantallaSala pantallaSala = new PantallaSala();
                //pantalla.actualizarCantVisitantes(cant_max_y_total[1], cant_max_y_total[0]);
                //pantallaSala.actualizarCantVisitantes(cant_max_y_total[1], cant_max_y_total[0]);
                //pantalla.ShowDialog();
                //pantallaSala.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
