using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frmProveedores : Form
    {
        CDProveedores objProveedor = new CDProveedores();
        string Operacion = "Insertar";
        string idprod;

        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            ListarCategorias();
            ListarMarcas();
            ListarProveedores();

        }
        private void ListarCategorias()
        {
            CDProveedores objProv = new CDProveedores();
            cbCategoria.DataSource = objProv.ListarCategorias();
            cbCategoria.DisplayMember = "categoria";
            cbCategoria.ValueMember = "Idcategoria";
        }
        private void ListarMarcas()
        {
            CDProveedores objProv = new CDProveedores();
            cbMarca.DataSource = objProv.ListarMarcas();
            cbMarca.DisplayMember = "marca";
            cbMarca.ValueMember = "Idmarca";
        }
        private void ListarProveedores()
        {
            CDProveedores objProv = new CDProveedores();
            dgvProveedores.DataSource = objProv.ListarProveedores();
        }

        private void LimpiarFormulario()
        {
            txtNombrePro.Clear();
            txtDireccion.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                objProveedor.InsertarProveedores(
                    Convert.ToInt32(cbCategoria.SelectedValue),
                    Convert.ToInt32(cbMarca.SelectedValue),
                    txtNombrePro.Text,
                    txtDireccion.Text
                    );
                MessageBox.Show("El dato se ha guardado correctamente");
                ListarProveedores();
            }
            else if (Operacion == "Editar")
            {
                objProveedor.EditarProveedores(Convert.ToInt32(idprod),
                    Convert.ToInt32(cbCategoria.SelectedValue),
                    Convert.ToInt32(cbMarca.SelectedValue),
                    txtNombrePro.Text,
                    txtDireccion.Text);

                MessageBox.Show("El dato se ha actualizado correctamente");
            }

            ListarProveedores();
            LimpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                Operacion = "Editar";
                cbCategoria.Text = dgvProveedores.CurrentRow.Cells["categoria"].Value.ToString();
                cbMarca.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();

                txtNombrePro.Text = dgvProveedores.CurrentRow.Cells["Nombre_prov"].Value.ToString();
                txtDireccion.Text = dgvProveedores.CurrentRow.Cells[4].Value.ToString();
                idprod = dgvProveedores.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
                MessageBox.Show("Debe seleccionar un dato");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                objProveedor.EliminarProducto(Convert.ToInt32(dgvProveedores.CurrentRow.Cells[0].Value));
                MessageBox.Show("El registro se ha eliminado satisfactoriamente");
                ListarProveedores();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
    }
}
