
namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnProveedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.AccessibleName = "txtNombre";
            this.textNombre.Location = new System.Drawing.Point(886, 72);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 23);
            this.textNombre.TabIndex = 1;
            // 
            // textDesc
            // 
            this.textDesc.AccessibleName = "txtDesc";
            this.textDesc.Location = new System.Drawing.Point(886, 123);
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(100, 23);
            this.textDesc.TabIndex = 1;
            // 
            // textMarca
            // 
            this.textMarca.AccessibleName = "txtMarca";
            this.textMarca.Location = new System.Drawing.Point(886, 177);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(100, 23);
            this.textMarca.TabIndex = 1;
            // 
            // textPrecio
            // 
            this.textPrecio.AccessibleName = "txtPrecio";
            this.textPrecio.Location = new System.Drawing.Point(886, 232);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(100, 23);
            this.textPrecio.TabIndex = 1;
            // 
            // textStock
            // 
            this.textStock.AccessibleName = "txtStock";
            this.textStock.Location = new System.Drawing.Point(886, 280);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(100, 23);
            this.textStock.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(816, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(827, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(827, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Precio:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(831, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Stock:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleName = "btnGuardar";
            this.btnGuardar.Location = new System.Drawing.Point(831, 353);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(155, 27);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(24, 433);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 54);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(197, 433);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 54);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AccessibleName = "dgvDatos";
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(24, 21);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowTemplate.Height = 25;
            this.dgvDatos.Size = new System.Drawing.Size(768, 390);
            this.dgvDatos.TabIndex = 0;
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(834, 433);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(152, 33);
            this.btnProveedor.TabIndex = 6;
            this.btnProveedor.Text = "Lista de proveedores";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 493);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textDesc);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.dgvDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnProveedor;
    }
}

