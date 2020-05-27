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

            string sql = $"SELECT C.idorder, A.fullname, B.adress , D.name , E.name " +
                         $"FROM APPUSER A, ADDRESS B, APPORDER C, PRODUCT D, BUSINESS E" +
                         $" WHERE A.iduser = B.idUser AND B.idaddress = C.idaddress " +
                         $"AND C.IDProduct = E.idBUSINESS AND E.idbusiness =D.idbusiness";
            
            var dt = Conexion.realizarConsulta(sql);
            
            dt.Columns[0].ColumnName = "Id de orden";
            dt.Columns[1].ColumnName = "Nombre completo";
            dt.Columns[2].ColumnName = "Dirección";
            dt.Columns[3].ColumnName = "Producto";
            dt.Columns[4].ColumnName = "Negocio";
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }
    }
}