using System.ComponentModel;

namespace Parcial2
{
    partial class fmrPrincipalUsuario
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
            this.btnAgregarDireccion = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEditarDireccion = new System.Windows.Forms.Button();
            this.comboDireccion = new System.Windows.Forms.ComboBox();
            this.txtNuevaDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnEliminarDireccion = new System.Windows.Forms.Button();
            this.comboEliminarDireccion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Indigo;
            this.tabPage1.Controls.Add(this.btnAgregarDireccion);
            this.tabPage1.Controls.Add(this.txtDireccion);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(534, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar dirección";
            // 
            // btnAgregarDireccion
            // 
            this.btnAgregarDireccion.BackColor = System.Drawing.Color.White;
            this.btnAgregarDireccion.Location = new System.Drawing.Point(213, 177);
            this.btnAgregarDireccion.Name = "btnAgregarDireccion";
            this.btnAgregarDireccion.Size = new System.Drawing.Size(115, 43);
            this.btnAgregarDireccion.TabIndex = 2;
            this.btnAgregarDireccion.Text = "Agregar direccion";
            this.btnAgregarDireccion.UseVisualStyleBackColor = false;
            this.btnAgregarDireccion.Click += new System.EventHandler(this.btnAgregarDireccion_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(173, 81);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(342, 23);
            this.txtDireccion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Indigo;
            this.tabPage3.Controls.Add(this.btnEditarDireccion);
            this.tabPage3.Controls.Add(this.comboDireccion);
            this.tabPage3.Controls.Add(this.txtNuevaDireccion);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(534, 321);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Editar dirección";
            // 
            // btnEditarDireccion
            // 
            this.btnEditarDireccion.BackColor = System.Drawing.Color.White;
            this.btnEditarDireccion.Location = new System.Drawing.Point(213, 192);
            this.btnEditarDireccion.Name = "btnEditarDireccion";
            this.btnEditarDireccion.Size = new System.Drawing.Size(105, 43);
            this.btnEditarDireccion.TabIndex = 4;
            this.btnEditarDireccion.Text = "Editar dirección";
            this.btnEditarDireccion.UseVisualStyleBackColor = false;
            this.btnEditarDireccion.Click += new System.EventHandler(this.btnEditarDireccion_Click);
            // 
            // comboDireccion
            // 
            this.comboDireccion.FormattingEnabled = true;
            this.comboDireccion.Location = new System.Drawing.Point(213, 65);
            this.comboDireccion.Name = "comboDireccion";
            this.comboDireccion.Size = new System.Drawing.Size(262, 23);
            this.comboDireccion.TabIndex = 3;
            // 
            // txtNuevaDireccion
            // 
            this.txtNuevaDireccion.Location = new System.Drawing.Point(213, 125);
            this.txtNuevaDireccion.Name = "txtNuevaDireccion";
            this.txtNuevaDireccion.Size = new System.Drawing.Size(262, 23);
            this.txtNuevaDireccion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nueva dirección";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Direccion";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Indigo;
            this.tabPage4.Controls.Add(this.btnEliminarDireccion);
            this.tabPage4.Controls.Add(this.comboEliminarDireccion);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(534, 321);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Eliminar dirección";
            // 
            // btnEliminarDireccion
            // 
            this.btnEliminarDireccion.BackColor = System.Drawing.Color.White;
            this.btnEliminarDireccion.Location = new System.Drawing.Point(208, 172);
            this.btnEliminarDireccion.Name = "btnEliminarDireccion";
            this.btnEliminarDireccion.Size = new System.Drawing.Size(118, 48);
            this.btnEliminarDireccion.TabIndex = 6;
            this.btnEliminarDireccion.Text = "Eliminar dirección";
            this.btnEliminarDireccion.UseVisualStyleBackColor = false;
            this.btnEliminarDireccion.Click += new System.EventHandler(this.btnEliminarDireccion_Click);
            // 
            // comboEliminarDireccion
            // 
            this.comboEliminarDireccion.FormattingEnabled = true;
            this.comboEliminarDireccion.Location = new System.Drawing.Point(208, 75);
            this.comboEliminarDireccion.Name = "comboEliminarDireccion";
            this.comboEliminarDireccion.Size = new System.Drawing.Size(262, 23);
            this.comboEliminarDireccion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Direccion";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Indigo;
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(533, 319);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Ver direcciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // fmrPrincipalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(541, 347);
            this.Controls.Add(this.tabControl1);
            this.Name = "fmrPrincipalUsuario";
            this.Text = "fmrPrincipalUsuario";
            this.Load += new System.EventHandler(this.fmrPrincipalUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnAgregarDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditarDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboEliminarDireccion;
        private System.Windows.Forms.Button btnEliminarDireccion;
        private System.Windows.Forms.TextBox txtNuevaDireccion;
        private System.Windows.Forms.ComboBox comboDireccion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}