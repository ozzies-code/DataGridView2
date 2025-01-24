using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView2
{
    public partial class Form1 : Form
    {

        private double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataGridViewColumn codigo = new DataGridViewColumn();
            //codigo.HeaderText = "Codigo";
            //codigo.CellTemplate = new DataGridViewTextBoxCell();
            ////Platillas para Texto

            //codigo.ReadOnly = true;

            //DataGridViewColumn descripcion = new DataGridViewColumn();
            //descripcion.HeaderText = "Descripcion Producto";
            //descripcion.CellTemplate = new DataGridViewTextBoxCell();
            ////Platillas para Texto

            //codigo.ReadOnly = true;

            //dGVProductos.Columns.Add(codigo);
            //dGVProductos.Columns.Add(descripcion);
            ////Se agrega una columna
            ///
           lblTotalProductos.Text = "Cantidad de Productos:";
        }

        private void dGVProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            total = 0;

            dGVProductos.Rows.Add(txtCodigo.Text, txtDP.Text, txtPrecio.Text);

            for(int i = 0; i<dGVProductos.Rows.Count-1;i++)
            {
                total = total + double.Parse(dGVProductos.Rows[i].Cells[2].Value.ToString());
            }

            txtTotalCompra.Text = "" + total;
            lblTotalProductos.Text = "Cantidad de Productos:" + "" + (dGVProductos.Rows.Count - 1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dGVProductos.Rows.RemoveAt(dGVProductos.CurrentCell.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
            //Metodo de la coleccion Rows
            //Propiedad RowIndex: Devuelve el indice de la fila.
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtDP.Clear();
            txtPrecio.Clear();
            txtTotalCompra.Clear();
        }
    }
}
