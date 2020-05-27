using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial2
{
    public static class Negocio
    {
        public static List<string> getNegocios()
        {
            string sql = "SELECT NAME FROM BUSINESS";
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
        
        public static List<NegocioDAO> getNegociosTabla()
        {
            string sql = "SELECT *FROM BUSINESS";

            DataTable dt = Conexion.realizarConsulta(sql);

            List<NegocioDAO> lista = new List<NegocioDAO>();
            foreach (DataRow fila in dt.Rows)
            {
                NegocioDAO u = new NegocioDAO();
                u.idbusiness = Convert.ToInt32(fila[0].ToString());
                u.name = fila[1].ToString();
                u.description = fila[2].ToString();
                lista.Add(u);
            }
            return lista;
        }
        
    }
}