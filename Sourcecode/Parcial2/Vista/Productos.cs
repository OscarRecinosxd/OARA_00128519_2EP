using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Productos : Form
    {
        private NegocioDAO u; 
        public Productos()
        {
            InitializeComponent();
        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string name = txtNombreAgregar.Text;

            if (name.Equals(""))
            {
                MessageBox.Show("Ingrese datos válidos");
            }
            else
            {
                u = (NegocioDAO) comboNegocios.SelectedItem;
                try
                {
                    string sql = $"INSERT INTO PRODUCT(idbusiness,name) VALUES(" +
                                 $"{u.idbusiness}," +
                                 $"'{name}')";
                    
                    Conexion.realizarAccion(sql);
                    MessageBox.Show("Producto agregado correctamente");
                    poblar();
                    txtNombreAgregar.Text = "";
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error!");
                }
            }
            
            
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            poblar();
        }

        private void poblar()
        {
            comboNegocios.DataSource = null;
            comboNegocios.ValueMember = "idbusiness";
            comboNegocios.DisplayMember = "name";
            comboNegocios.DataSource = Negocio.getNegociosTabla();


            comboNombreProductos.DataSource = null;
            comboNombreProductos.DataSource = Producto.getProductos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string name = comboNombreProductos.Text;
                string sql = $"DELETE FROM PRODUCT WHERE name = '{name}'";
                Conexion.realizarAccion(sql);
                MessageBox.Show("Eliminado correctamente!");
                poblar();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error!");
            }
        }
    }
}