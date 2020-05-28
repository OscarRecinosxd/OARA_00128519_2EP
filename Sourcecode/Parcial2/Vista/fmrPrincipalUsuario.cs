using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class fmrPrincipalUsuario : Form
    {
        private Usuario pUsuario;

        public fmrPrincipalUsuario(Usuario u)
        {
            InitializeComponent();
            pUsuario = u;
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            string direccion = txtDireccion.Text;
            if (direccion.Equals(""))
            {
                MessageBox.Show("Llene los espacios en blanco");
            }
            else
            {
                try
                {

                    string sql = $"INSERT INTO ADDRESS(iduser,address) VALUES(" +
                                 $"'{pUsuario.iduser}'," +
                                 $"'{direccion}')";
                    Conexion.realizarAccion(sql);
                    MessageBox.Show("Dirección agregada!");
                    poblar();
                    Limpiar();
                    cargarUsuarios();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void Limpiar()
        {
            txtDireccion.Text = "";
            txtNuevaDireccion.Text = "";
        }

        private void btnEliminarDireccion_Click(object sender, EventArgs e)
        {
            string direccion = comboEliminarDireccion.Text;
            try
            {

                string sql = $"DELETE FROM ADDRESS WHERE ADDRESS = '{direccion}' ";
                Conexion.realizarAccion(sql);
                MessageBox.Show("Dirección eliminada!");
                poblar();
                Limpiar();
                cargarUsuarios();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error!");
            }
        }

        private void poblar()
        {
            comboDireccion.DataSource = null;
            comboDireccion.DataSource = Direcciones.getDireccion();

            comboEliminarDireccion.DataSource = null;
            comboEliminarDireccion.DataSource = Direcciones.getDireccion();

        }

        private void btnEditarDireccion_Click(object sender, EventArgs e)
        {
            string direccion = comboDireccion.Text;
            string nuevaDireccion = txtNuevaDireccion.Text;
            if (nuevaDireccion.Equals(""))
            {
                MessageBox.Show("Llene los espacios en blanco");
            }
            else
            {
                try
                {

                    string sql = $"UPDATE ADDRESS SET address = '{nuevaDireccion}' " +
                                 $"WHERE address ='{direccion}' ";
                    Conexion.realizarAccion(sql);
                    MessageBox.Show("Dirección editada!");
                    poblar();
                    Limpiar();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error!");
                }
            }

            poblar();
            Limpiar();
            cargarUsuarios();
        }

        private void fmrPrincipalUsuario_Load(object sender, EventArgs e)
        {
            poblar();
            cargarUsuarios();

        }

        private void cargarUsuarios()
        {
            var dt = Conexion.realizarConsulta($"SELECT *FROM ADDRESS");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }
    }
}