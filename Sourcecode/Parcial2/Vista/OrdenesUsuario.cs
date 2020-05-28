using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class OrdenesUsuario : Form
    {
        public OrdenesUsuario()
        {
            InitializeComponent();
        }


        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                var datetime = DateTime.Now.ToString("yyyy-MM-dd");
                int idproduct = Convert.ToInt32(numericIdProducto.Text);
                int idaddress = Convert.ToInt32(numericIdDireccion.Text);

                string sql = $"INSERT INTO APPORDER(createdate,idproduct,idaddress) VALUES(" +
                             $"'{datetime}'," +
                             $"{idproduct}," +
                             $"{idaddress})";

                Conexion.realizarAccion(sql);

                MessageBox.Show("Orden agregada!");
                poblar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }

        }

        private void btnEliminarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                int idOrden = Convert.ToInt32(numericIdOrdenEliminar.Text);
                string sql = $"DELETE FROM APPORDER WHERE idorder = {idOrden}";
                Conexion.realizarAccion(sql);
                MessageBox.Show("Orden eliminada!!");
                poblar();
            }
            catch (Exception )
            {
                MessageBox.Show("Error!");
            }
        }

        private void OrdenesUsuario_Load(object sender, EventArgs e)
        {
            poblar();
        }

        private void poblar()
        {
            string sql =
                $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                $"WHERE ao.idProduct = pr.idProduct " +
                $"AND ao.idAddress = ad.idAddress " +
                $"AND ad.idUser = au.idUser ";
                

            var dt = Conexion.realizarConsulta(sql);
            
            dt.Columns[0].ColumnName = "ID orden";
            dt.Columns[1].ColumnName = "Fecha";
            dt.Columns[2].ColumnName = "Negocio";
            dt.Columns[3].ColumnName = "Nombre completo";
            dt.Columns[4].ColumnName = "Dirección";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }
    }
}