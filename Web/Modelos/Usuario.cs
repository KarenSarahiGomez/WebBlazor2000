using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Usuario
    {
        [Required(ErrorMessage = "El código es requerido")]
        public string CodigoUsuario { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        [Required(ErrorMessage = "El rol es requerido")]
        public string Rol { get; set; }

        //Guardar fotografias del usuario
        public byte[] Foto { get; set; }

        public DateTime FechaCreación { get; set; }
        public bool EstaActivo { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigoUsuario, string nombre, string contrasena, string correo, string rol, byte[] foto, DateTime fechaCreación, bool estaActivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contrasena = contrasena;
            Correo = correo;
            Rol = rol;
            Foto = foto;
            FechaCreación = fechaCreación;
            EstaActivo = estaActivo;
        }
    }
}
