using System.ComponentModel;

namespace Parcial2
{
    partial class OrdenesUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericIdProducto = new System.Windows.Forms.NumericUpDown();
            this.numericIdDireccion = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarOrden = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEliminarOrden = new System.Windows.Forms.Button();
            this.numericIdOrdenEliminar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericIdProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericIdDireccion)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericIdOrdenEliminar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Indigo;
            this.tabPage1.Controls.Add(this.numericIdProducto);
            this.tabPage1.Controls.Add(this.numericIdDireccion);
            this.tabPage1.Controls.Add(this.btnAgregarOrden);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(621, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear orden";
            // 
            // numericIdProducto
            // 
            this.numericIdProducto.Location = new System.Drawing.Point(324, 178);
            this.numericIdProducto.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.numericIdProducto.Name = "numericIdProducto";
            this.numericIdProducto.Size = new System.Drawing.Size(136, 23);
            this.numericIdProducto.TabIndex = 4;
            // 
            // numericIdDireccion
            // 
            this.numericIdDireccion.Location = new System.Drawing.Point(324, 87);
            this.numericIdDireccion.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.numericIdDireccion.Name = "numericIdDireccion";
            this.numericIdDireccion.Size = new System.Drawing.Size(136, 23);
            this.numericIdDireccion.TabIndex = 3;
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.Location = new System.Drawing.Point(247, 257);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(121, 52);
            this.btnAgregarOrden.TabIndex = 2;
            this.btnAgregarOrden.Text = "Agregar orden";
            this.btnAgregarOrden.UseVisualStyleBackColor = true;
            this.btnAgregarOrden.Click += new System.EventHandler(this.btnAgregarOrden_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Producto";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Direccion";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Indigo;
            this.tabPage2.Controls.Add(this.btnEliminarOrden);
            this.tabPage2.Controls.Add(this.numericIdOrdenEliminar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar orden";
            // 
            // btnEliminarOrden
            // 
            this.btnEliminarOrden.BackColor = System.Drawing.Color.White;
            this.btnEliminarOrden.Location = new System.Drawing.Point(230, 205);
            this.btnEliminarOrden.Name = "btnEliminarOrden";
            this.btnEliminarOrden.Size = new System.Drawing.Size(113, 68);
            this.btnEliminarOrden.TabIndex = 6;
            this.btnEliminarOrden.Text = "Eliminar orden";
            this.btnEliminarOrden.UseVisualStyleBackColor = false;
            this.btnEliminarOrden.Click += new System.EventHandler(this.btnEliminarOrden_Click);
            // 
            // numericIdOrdenEliminar
            // 
            this.numericIdOrdenEliminar.Location = new System.Drawing.Point(317, 85);
            this.numericIdOrdenEliminar.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.numericIdOrdenEliminar.Name = "numericIdOrdenEliminar";
            this.numericIdOrdenEliminar.Size = new System.Drawing.Size(136, 23);
            this.numericIdOrdenEliminar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id orden";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Indigo;
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(621, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ver ordenes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // OrdenesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(629, 402);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrdenesUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdenesUsuario";
            this.Load += new System.EventHandler(this.OrdenesUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.numericIdProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericIdDireccion)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.numericIdOrdenEliminar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarOrden;
        private System.Windows.Forms.NumericUpDown numericIdDireccion;
        private System.Windows.Forms.NumericUpDown numericIdProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarOrden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericIdOrdenEliminar;
    }
}