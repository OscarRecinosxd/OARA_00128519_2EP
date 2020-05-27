using System;
using System.Windows.Forms;

namespace Parcial2.Properties
{
    public partial class CambiarContra : Form
    {
        public CambiarContra(Usuario u)
        {
            InitializeComponent();

        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            bool nuevaIgual = txtNueva.Text.Equals(txtRepetirNueva.Text);
            bool nuevaValida = txtNueva.Text.Length > 0;

            if (  nuevaIgual && nuevaValida)
            {
                try
                {
                    UsuarioDAO.actualizarContra(cmbUsuario.Text, txtNueva.Text);
                    
                    MessageBox.Show("¡Contraseña actualizada exitosamente!", 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Contraseña no actualizada! Favor intente mas tarde.", 
                        "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("¡¡Favor verifique que los datos sean correctos!", 
                    "HUGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        
        private void CambiarContra_Load(object sender, EventArgs e)
        {
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "password";
            cmbUsuario.DisplayMember = "username";
            cmbUsuario.DataSource = UsuarioDAO.getLista();
        }
    }
}