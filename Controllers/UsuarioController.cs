using API_proyecto_Final_PabloArias.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_proyecto_Final_PabloArias


{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
         //
        // PRE ENTREGA  Update Usuario
        //
       
        [HttpPut]

        public void C_ActualizarUsuario(Usuario usuario)
        {
            ManejadorUsuario.UpdateUsuario(usuario);
        }

    }


}
