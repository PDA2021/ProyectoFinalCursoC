using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace API_proyecto_Final_PabloArias.Repository
{
    internal class ManejadorUsuario
    {
        public static string cadenaConexion = "Data Source=H2687CC0001;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Usuario ", conn);
                conn.Open();
                //Console.WriteLine(conn.Database);

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Usuario usuarioTemporal = new Usuario();
                        usuarioTemporal.Id = reader.GetInt64(0);
                        usuarioTemporal.Nombre = reader.GetString(1);
                        usuarioTemporal.Apellido = reader.GetString(2);
                        usuarioTemporal.Mail = reader.GetString(3);
                        usuarioTemporal.NombreUsuario = reader.GetString(4);
                        usuarioTemporal.Contraseña = reader.GetString(5);

                        usuarios.Add(usuarioTemporal);
                    }
                }
                return usuarios;


            }

        }

        public static Usuario ObtenerUsuario(int id)
        {
            Usuario usuario = new Usuario();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {

                SqlCommand comando = new SqlCommand($"SELECT * FROM Usuario WHERE id = '{id}' ", conn);

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
        public static int InsertarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Usuario(Nombre, Apellido, NombreUsuario, Contraseña, Mail) " +
                    "VALUES (@nombre, @apellido, @nombreUsuario, @contrasena, @mail)", conn);
                SqlParameter nombreParam = new SqlParameter();
                nombreParam.ParameterName = "nombre";
                nombreParam.SqlDbType = SqlDbType.VarChar;
                nombreParam.Value = usuario.Nombre;

                SqlParameter apellidoParam = new SqlParameter("apellido", usuario.Apellido);
                SqlParameter nombreUsuParam = new SqlParameter("nombreUsuario", usuario.NombreUsuario);
                SqlParameter passwParam = new SqlParameter("contrasena", usuario.Contraseña);
                SqlParameter mailParam = new SqlParameter("mail", usuario.Mail);

                cmd.Parameters.Add(nombreParam);
                cmd.Parameters.Add(apellidoParam);
                cmd.Parameters.Add(nombreUsuParam);
                cmd.Parameters.Add(passwParam);
                cmd.Parameters.Add(mailParam);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }


        public static int UpdateUsuario(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("UPDATE Usuario " +
                    "SET Nombre=@nombre," +
                    "Apellido=@apellido, NombreUsuario=@nombreusuario," +
                    "Contraseña=@contraseña, Mail=@mail " +
                    "WHERE Id=@id", conn);
                comando.Parameters.AddWithValue("@id", usuario.Id);
                comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
                comando.Parameters.AddWithValue("@nombreusuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                comando.Parameters.AddWithValue("@mail", usuario.Mail);
                conn.Open();
                return comando.ExecuteNonQuery();
            }
        }
    }
}



