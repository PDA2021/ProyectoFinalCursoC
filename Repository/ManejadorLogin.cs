using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace API_proyecto_Final_PabloArias.Repository
{
    internal class ManejadorLogin
    {
        public static string cadenaConexion = "Data Source=H2687CC0001;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static Usuario ValidaUsuario(string NombreUsuario, string Contraseña)
        {
            Usuario usuario = new Usuario();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {

                SqlCommand comando = new SqlCommand($"select * from Usuario where NombreUsuario = '{NombreUsuario}' and Contraseña = '{Contraseña}'", conn);

                conn.Open();
                //Console.WriteLine(conn.Database);

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    usuario.Id = reader.GetInt64(0);
                    usuario.Nombre = reader.GetString(1);
                    usuario.Apellido = reader.GetString(2);
                    usuario.Mail = reader.GetString(3);
                    usuario.NombreUsuario = reader.GetString(4);
                    usuario.Contraseña = reader.GetString(5);

                }
            }
            return usuario;
        }
    }
}

