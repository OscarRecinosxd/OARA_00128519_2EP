using System.Collections.Generic;
using System.Data;

namespace Parcial2
{
    public static class Direcciones
    {
        public static List<string> getDireccion()
        {
            string sql = "SELECT ADRESS FROM ADDRESS";
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