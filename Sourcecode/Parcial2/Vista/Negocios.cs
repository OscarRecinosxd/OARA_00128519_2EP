using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Negocios : Form
    {
        public Negocios()
        {
            InitializeComponent();
        }

        private void Negocios_Load(object sender, EventArgs e)
        {
            poblar();
        }

        private void poblar()
        {
            comboNombreEliminar.DataSource = null;
            comboNombreEliminar.DataSource = Negocio.getNegocios();
        }

        private void limpiar()
        {
            txtDescripcionAgregar.Text = "";
            txtNombreAgregar.Text = "";
        }

        private void btnAgregarNegocio_Click(object sender, EventArgs e)
        {
            string name = txtNombreAgregar.Text;
            string descripcion = txtDescripcionAgregar.Text;

            if (name.Equals("") || descripcion.Equals(""))
            {
                MessageBox.Show("Ingrese datos válidos");
            }

            else
            {
                try
                {

                    string sql = $"INSERT INTO BUSINESS(name,description) VALUES(" +
                             $"'{name}'," +
                             $"'{descripcion}') ";
                    Conexion.realizarAccion(sql);
                    
                    MessageBox.Show("Negocio agregado correctamente!");
                    poblar();
                    limpiar();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error!");
                }
            }
            
            
            
        }

        private void btnEliminarNegocio_Click(object sender, EventArgs e)
        {
            try
            {
                string name = comboNombreEliminar.Text;
                string sql = $"DELETE FROM BUSINESS WHERE name = '{name}' ";
                Conexion.realizarAccion(sql);
                MessageBox.Show("Negocio eliminado correctamente!");
                limpiar();
                poblar();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error!");
            }
        }
    }
}