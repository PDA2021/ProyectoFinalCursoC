using API_proyecto_Final_PabloArias.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_proyecto_Final_PabloArias


{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        //12 . Obtener Ventas por nro usuario
        //
        [HttpGet("/api/Venta/{Idusuario}")]
        public List<Venta> C_ObtenerVentasUsu(int Idusuario)
        {
            List<Venta> Ventas = ManejadorVenta.ObtenerventasUsu(Idusuario);
            return Ventas;
        }
        // 6 .Insert Venta
        [HttpPost("/api/Venta/{Idusuario}")]

        public void C_InsertarVenta(Venta Venta,int stock,int idproducto)
        {
            int NroVenta = ManejadorVenta.Insertarventa(Venta);

            ManejadorProductoVendido.InsertarProductoVendido(NroVenta, stock, idproducto);
        }
    }

    }
