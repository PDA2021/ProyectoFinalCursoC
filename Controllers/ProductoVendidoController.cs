using API_proyecto_Final_PabloArias.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_proyecto_Final_PabloArias


{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        //Devuelve Lista de Productos Vendidos
        //
        //[HttpGet("/ProductoVendidos/")]
        //public List<ProductoVendido> C_productoVendidos()
        //{
        //    List<ProductoVendido> productoVendido = ManejadorProductoVendido.ObtenerProductosVendidos();
        //    return productoVendido;

        //}

        //11 .Devuelve Lista de Productos Vendidos por Usuario

        [HttpGet("/api/ProductoVendidos/Usuario/{IdUsuario}")]
        public List<ProductoVendido> C_productoVendidos(int IdUsuario)
        {
            List<ProductoVendido> productoVendidoUs = ManejadorProductoVendido.ObtenerProductosVendidosUsu(IdUsuario);
            return productoVendidoUs;

        }
    }
}


