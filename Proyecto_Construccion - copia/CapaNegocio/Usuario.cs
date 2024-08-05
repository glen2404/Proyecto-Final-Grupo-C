
namespace CapaNegocio
{
    public class Usuario:Persona
    {
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Rol { get; set; }
        public Usuario() { } 
        public Usuario(string cedula, string nombre, string apellido, string telefono, string email, string nombreUsuario, string contrasenia, string rol)
            : base(cedula, nombre, apellido, telefono, email)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
            Rol = rol;
        }
    }
}