using API_proyecto_Final_PabloArias.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_proyecto_Final_PabloArias


{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        //Devuelve Lista de Productos
        //
        //[HttpGet("/api/Producto/")]
        //public List<Producto> C_ObtenerProducts()
        //{
        //    List<Producto> producto = ManejadorProducto.ObtenerProductos();
        //    return producto;
        //}
        //
        // Seleccionar un producto por descripción
        //
        //[HttpGet("/api/Producto/Descripciones/{descripciones}")]
        //public Producto C_ObtenerProductoBydesc(string descripciones)
        //{
        //    Producto producto = ManejadorProducto.ObtenerProducto(descripciones);
        //    return producto;
        //}
        //10.Devuelve Productos ingresado por Usuario determinado(idUsuario)
        //
        [HttpGet("/api/Producto/{IdUsuario}")]
        public List<Producto> C_productoporIdusuario(int IdUsuario)
        {
            List<Producto> productosUs = ManejadorProducto.ObtenerProductosUsu(IdUsuario);
            return productosUs;

        }
        // 6 .Insert Producto
        [HttpPost("/api/Producto")]

        public void C_Crearproducto(Producto Producto)
        {
            ManejadorProducto.InsertarProducto(Producto);
        }
        //
        // 7. Update Producto
        //
        [HttpPut("/api/Producto")]

        public void C_Actualizarproducto(Producto Producto)
        {
            ManejadorProducto.UpdateProducto(Producto);
        }

        //
        // 8. Delete Producto
        //
        [HttpDelete("/api/Producto/{id}")]

        public void C_Deleteproducto(int id)
        {
            ManejadorProducto.EliminarProducto(id);
        }

    }

}
