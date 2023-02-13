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
        [HttpGet("/Producto/")]
        public List<Producto> C_ObtenerProducts()
        {
          List<Producto> producto = ManejadorProducto.ObtenerProductos ();
         return producto; 
        }
        //
        // Seleccionar un producto por descripción
        //
        [HttpGet("/Producto/{descripciones}")]
        public Producto C_ObtenerProductoBydesc(string descripciones)
        {
            Producto producto = ManejadorProducto.ObtenerProducto(descripciones);
            return producto;
        }
        // PRE ENTREGA  INSERT/UPDATE/DELETE Producto
        //
        // Insert Producto
        [HttpPost]

        public void C_Crearproducto(Producto Producto)
        {
            ManejadorProducto.InsertarProducto(Producto);
        }
        //
        // Update Producto
        //
        [HttpPut]

        public void C_Actualizarproducto(Producto Producto)
        {
            ManejadorProducto.UpdateProducto(Producto);
        }
        
        //
        // Delete Producto
        //
        [HttpDelete("/Producto/{id}")]

        public void C_Deleteproducto(int id)
        {
            ManejadorProducto.DeleteProducto(id);
        }

    }

    }
