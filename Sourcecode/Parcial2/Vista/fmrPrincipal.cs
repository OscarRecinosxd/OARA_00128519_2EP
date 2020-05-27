using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class fmrPrincipal : Form
    {
        private Usuario pUsuario;
        public fmrPrincipal(Usuario u)
        {
            InitializeComponent();
            pUsuario = u;
        }

        private void poblar()
        {
            cmbUsuarioEliminar.DataSource = null;
            cmbUsuarioEliminar.DataSource = UsuarioDAO.getUsuarios();
        }

        private void fmrPrincipal_Load(object sender, EventArgs e)
        {
            poblar();
            cargar();
        }


        private void AgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string fullname = txtNombreCompleto.Text;
                string user = txtUsuario.Text;
                bool admi = checkAdmi.Checked;
                string sql = $"INSERT INTO APPUSER(fullname,username,password,usertype)" +
                             $" VALUES('{fullname}','{user}','{user}',{admi})";
                
                Conexion.realizarAccion(sql);
                MessageBox.Show("Se agregó el usuario!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error!");
            }
            
            poblar();
            cargar();
            limpiar();
        }

        private void EliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = cmbUsuarioEliminar.Text;

                string sql = $"DELETE FROM APPUSER WHERE username = '{usuario}'";
                
                Conexion.realizarAccion(sql);
                MessageBox.Show("Se eliminó el usuario!");
                poblar();
                cargar();
                limpiar();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error!");
            }
        }
        
        private void cargar()
        {
            var dt = Conexion.realizarConsulta($"SELECT *FROM APPUSER");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }

        private void limpiar()
        {
            txtNombreCompleto.Text = "";
            txtUsuario.Text = "";
            checkAdmi.Checked = false;
        }
    }
}