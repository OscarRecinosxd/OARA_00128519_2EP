using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class MenuUsuario : Form
    {
        private Usuario pUsuario;
        
        public MenuUsuario(Usuario u)
        {
            InitializeComponent();
            pUsuario = u;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmrPrincipalUsuario ventana = new fmrPrincipalUsuario(pUsuario);
            ventana.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}