using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2.Properties;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        private Usuario u;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void poblarControles()
        {
            // Actualizar ComboBox
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "password";
            cmbUsuario.DisplayMember = "username";
            cmbUsuario.DataSource = UsuarioDAO.getLista();
            
        }
        
        
        private void btnCambiarContrasenia_Click(object sender, EventArgs e)
        {
            CambiarContra unaVentana = new CambiarContra(u);
            unaVentana.ShowDialog();
            poblarControles();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
           // if (e.KeyCode == Keys.Enter) button1_Click(sender, e);
            
        }

       // private void button1_Click(object sender, EventArgs e)
        //{
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            poblarControles();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedValue.Equals(txtPassword.Text))
            {
                u = (Usuario) cmbUsuario.SelectedItem;

                MessageBox.Show("¡Bienvenido!",
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (u.usertype)
                {
                    AdmiOpciones ventana = new AdmiOpciones(u);
                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    MenuUsuario ventana = new MenuUsuario(u);
                    ventana.Show();
                    this.Hide();

                }

            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "Hugo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}