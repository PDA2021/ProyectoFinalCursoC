using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace API_proyecto_Final_PabloArias.Repository
{
    internal class ManejadorVenta
    {
        public static string cadenaConexion = "Data Source=H2687CC0001;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static List<Venta> Obtenerventas()
        {
            List<Venta> Ventas = new List<Venta>();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM ProductoVendido", conn);
                conn.Open();

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Venta VentaTemporal = new Venta();
                        VentaTemporal.Id = reader.GetInt64(0);
                        VentaTemporal.comentarios = reader.GetString(1);
                        VentaTemporal.Idusuario = reader.GetInt64(2);

                        Ventas.Add(VentaTemporal);
                    }
                }
                return Ventas;

            }

        }

        public static List<Venta> ObtenerventasUsu(int id)
        {

            List<Venta> VentasUsu = new List<Venta>();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand($" select * from Venta where Venta.IdUsuario = {id}", conn);
                conn.Open();
                //Console.WriteLine(conn.Database);

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Venta VentaTemporalUsu = new Venta();
                        VentaTemporalUsu.id = reader.GetInt64(0);
                        VentaTemporalUsu.comentarios = reader.GetString(1);
                        VentaTemporalUsu.idusuario = reader.GetInt64(2);

                        VentasUsu.Add(VentaTemporalUsu);

                    }
                }
                return VentasUsu;


            }
        }
    }
}

