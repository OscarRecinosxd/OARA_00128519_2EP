using System.Data;
using Npgsql;
using System.Data.SqlClient;
namespace Parcial2
{
    public class Conexion
    {
        
            public static string CadenaConexion = 
                "Server=localhost;Port=5432;User Id=postgres;Password=uca;Database=Parcial2;";

            /* private static string host = "ec2-34-200-101-236.compute-1.amazonaws.com",
                 database = "d4h1nnjo2mv1c9",
                 userID = "ahnmwopswzamyi",
                 password = "5e4e742f5715973aae25884e3c12e9930429ca929c8f93b6eee5058dcbb9b51c";
                 
             private static string CadenaConexion =
                 $"Host={host};Port=5432;User ID={userID};Password={password};Database={database};" +
                 "sslmode=Require;Trust Server Certificate=true";
             */
            
            public static DataTable realizarConsulta(string sql)
            {
                NpgsqlConnection conn = new NpgsqlConnection(CadenaConexion);
                DataSet ds = new DataSet();
            
                conn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                da.Fill(ds);
                conn.Close();
            
                return ds.Tables[0];
            }

            public static void realizarAccion(string sql)
            {
                NpgsqlConnection conn = new NpgsqlConnection(CadenaConexion);
                conn.Open();
                NpgsqlCommand nc = new NpgsqlCommand(sql, conn);
                nc.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
    
