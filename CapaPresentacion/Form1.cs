using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CNProducto objetoCN = new CNProducto();
        private bool Editar = false;
        private string idProducto = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void MostrarProductos()
        {
            CNProducto objeto = new CNProducto();
            dgvDatos.DataSource = objeto.MostrarProd();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarProd(textNombre.Text, textDesc.Text, textMarca.Text, textPrecio.Text, textStock.Text);
                    MessageBox.Show("El dato se guardo correctamente");
                    MostrarProductos();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar los datos por: " + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarProd(textNombre.Text, textDesc.Text, textMarca.Text, textPrecio.Text, textStock.Text, idProducto);
                    MessageBox.Show("El dato se actualizo correctamente");
                    MostrarProductos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar los datos por: " + ex);
                }
            }
            try
            {
                objetoCN.InsertarProd(textNombre.Text, textDesc.Text, textMarca.Text, textPrecio.Text, textStock.Text);
                MessageBox.Show("Se inserto correctamente");
                MostrarProductos();
                limpiarForm();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede insertar los datos por: " + ex);
            }
        }
        private void limpiarForm()
        {
            textDesc.Clear();
            textMarca.Text = "";
            textPrecio.Clear();
            textStock.Clear();
            textNombre.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                Editar = true;

                textNombre.Text = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                textMarca.Text = dgvDatos.CurrentRow.Cells["Marca"].Value.ToString();
                textDesc.Text = dgvDatos.CurrentRow.Cells["Descripcion"].Value.ToString();
                textPrecio.Text = dgvDatos.CurrentRow.Cells["Precio"].Value.ToString();
                textStock.Text = dgvDatos.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                idProducto = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarProd(idProducto);
                MessageBox.Show("El datos se ha eliminado correctamente");
                MostrarProductos();
            }
            else
                MessageBox.Show("Seleccione una fila para poder editar un registro");
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = new frmProveedores();
            frmProveedores.Show();
            this.Hide();
        }
    }
}
