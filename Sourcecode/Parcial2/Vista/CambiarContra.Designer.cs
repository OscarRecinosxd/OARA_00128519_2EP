using System.ComponentModel;

namespace Parcial2.Properties
{
    partial class CambiarContra
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
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.Nuevacontraseña = new System.Windows.Forms.Label();
            this.RepetirNuevaContraseña = new System.Windows.Forms.Label();
            this.txtRepetirNueva = new System.Windows.Forms.TextBox();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(252, 91);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = '*';
            this.txtNueva.Size = new System.Drawing.Size(150, 23);
            this.txtNueva.TabIndex = 0;
            // 
            // Nuevacontraseña
            // 
            this.Nuevacontraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Nuevacontraseña.ForeColor = System.Drawing.Color.White;
            this.Nuevacontraseña.Location = new System.Drawing.Point(59, 91);
            this.Nuevacontraseña.Name = "Nuevacontraseña";
            this.Nuevacontraseña.Size = new System.Drawing.Size(159, 21);
            this.Nuevacontraseña.TabIndex = 1;
            this.Nuevacontraseña.Text = "Nueva contraseña";
            // 
            // RepetirNuevaContraseña
            // 
            this.RepetirNuevaContraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.RepetirNuevaContraseña.ForeColor = System.Drawing.Color.White;
            this.RepetirNuevaContraseña.Location = new System.Drawing.Point(31, 148);
            this.RepetirNuevaContraseña.Name = "RepetirNuevaContraseña";
            this.RepetirNuevaContraseña.Size = new System.Drawing.Size(199, 21);
            this.RepetirNuevaContraseña.TabIndex = 3;
            this.RepetirNuevaContraseña.Text = "Repetir nueva contraseña";
            // 
            // txtRepetirNueva
            // 
            this.txtRepetirNueva.Location = new System.Drawing.Point(252, 147);
            this.txtRepetirNueva.Name = "txtRepetirNueva";
            this.txtRepetirNueva.PasswordChar = '*';
            this.txtRepetirNueva.Size = new System.Drawing.Size(150, 23);
            this.txtRepetirNueva.TabIndex = 2;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Location = new System.Drawing.Point(160, 198);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(147, 24);
            this.btnCambiarContraseña.TabIndex = 4;
            this.btnCambiarContraseña.Text = "Cambiar contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(129, 28);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(201, 23);
            this.cmbUsuario.TabIndex = 5;
            // 
            // CambiarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(450, 293);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.RepetirNuevaContraseña);
            this.Controls.Add(this.txtRepetirNueva);
            this.Controls.Add(this.Nuevacontraseña);
            this.Controls.Add(this.txtNueva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CambiarContra";
            this.Text = "CambiarContra";
            this.Load += new System.EventHandler(this.CambiarContra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Label RepetirNuevaContraseña;
        private System.Windows.Forms.Label Nuevacontraseña;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.TextBox txtRepetirNueva;
        private System.Windows.Forms.TextBox txtNueva;
    }
}