using API_proyecto_Final_PabloArias.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_proyecto_Final_PabloArias


{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // 1.Usuario Login
        [HttpGet("/api/Usuario/{usuario}/{contrasena}")]
        public Usuario Login(string usuario, string contrasena)
        {
            return ManejadorUsuario.Login(usuario, contrasena);
        }
        // 4 .Obtener Usuario por Nombre usuario
        [HttpGet("/api/Usuario/{NombreUsuario}")]
        public Usuario C_ObtenerUsuario(string NombreUsuario)
        {

            Usuario usuario = ManejadorUsuario.ObtenerUsuarioNombreUsuario(NombreUsuario);
            return usuario;

        }
        // 3. Update Usuario
        [HttpPut("/api/Usuario")]

        public void C_ActualizarUsuario(Usuario usuario)
        {
            ManejadorUsuario.UpdateUsuario(usuario);
        }
        // 2. Insertar Usuario
        [HttpPost("/api/Usuario")]
        public void C_InsertarUsuario(Usuario usuario)
        {
            ManejadorUsuario.InsertarUsuario(usuario);
        }
        // 5. Delete Usuario
        [HttpDelete("/api/Usuario/{id}")]

        public void C_Deleteusuario(int id)
        {
            ManejadorUsuario.EliminarUsuario(id);
        }
    }


}
