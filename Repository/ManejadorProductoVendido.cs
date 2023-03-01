using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace API_proyecto_Final_PabloArias.Repository
{
    internal class ManejadorProductoVendido
    {
        public static string cadenaConexion = "Data Source=H2687CC0001;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static List<ProductoVendido> ObtenerProductosVendidos()
        {
            List<ProductoVendido> productosVendidos = new List<ProductoVendido>();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM ProductoVendido", conn);
                conn.Open();

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        ProductoVendido productoVendidoTemporal = new ProductoVendido();
                        productoVendidoTemporal.Id = reader.GetInt64(0);
                        productoVendidoTemporal.Stock = reader.GetInt32(1);
                        productoVendidoTemporal.Idproducto = reader.GetInt64(2);
                        productoVendidoTemporal.Idventa = reader.GetInt64(3);

                        productosVendidos.Add(productoVendidoTemporal);
                    }
                }
                return productosVendidos;

            }

        }

        public static List<ProductoVendido> ObtenerProductosVendidosUsu(int id)
        {

            List<ProductoVendido> productosVendidos = new List<ProductoVendido>();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand($"Select * from ProductoVendido inner join Venta on ProductoVendido.IdVenta = Venta.Id where Venta.IdUsuario = {id}", conn);
                conn.Open();
                //Console.WriteLine(conn.Database);

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        ProductoVendido productoVendidoTemporal = new ProductoVendido();
                        productoVendidoTemporal.id = reader.GetInt64(0);
                        productoVendidoTemporal.Stock = reader.GetInt32(1);
                        productoVendidoTemporal.Idproducto = reader.GetInt64(2);
                        productoVendidoTemporal.Idventa = reader.GetInt64(3);

                        productosVendidos.Add(productoVendidoTemporal);
                    }
                }
                return productosVendidos;


            }
        }
                public static int InsertarProductoVendido(int Idventa,int stock,int Idproducto)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("INSERT INTO ProductoVendido(stock,idproducto,idventa)" +
                    "VALUES(@stock, @idproducto, @idventa)", conn);
                ProductoVendido Productovendido = new ProductoVendido();
                comando.Parameters.AddWithValue("@stock", Productovendido.stock);
                comando.Parameters.AddWithValue("@idproducto", Productovendido.Idproducto);
                comando.Parameters.AddWithValue("@idventa", Productovendido.Idventa);
            
                conn.Open();
                return comando.ExecuteNonQuery();

            }
        }



    }
}



