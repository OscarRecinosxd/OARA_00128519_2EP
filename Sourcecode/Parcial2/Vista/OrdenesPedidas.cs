using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class OrdenesPedidas : Form
    {
        public OrdenesPedidas()
        {
            InitializeComponent();
        }

        private void OrdenesPedidas_Load(object sender, EventArgs e)
        {
            poblar();
        }

        private void poblar()
        {
            
            string sql = $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
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