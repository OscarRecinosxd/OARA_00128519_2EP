using System.Collections.Generic;
using System.Data;

namespace Parcial2
{
    public static class Producto
    {
        public static List<string> getProductos()
        {
            string sql = "SELECT NAME FROM PRODUCT";
            string u = "";
            DataTable dt = Conexion.realizarConsulta(sql);
            List<string> lista = new List<string>();
            foreach (DataRow fila in dt.Rows)
            {
                u = fila[0].ToString();
                lista.Add(u);
            }
            return lista;
        }
    }
}