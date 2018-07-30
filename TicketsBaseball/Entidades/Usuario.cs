using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketsDeportivos.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string ConfirmarContrasena { get; set; }
        public int Activo { get; set; }
        public string Foto { get; set; }

        public Usuario()
        {
            this.UsuarioId = 0;
            this.Nombres = string.Empty;
            this.Apellidos = string.Empty;
            this.Telefono = string.Empty;
            this.Email = string.Empty;
            this.Direccion = string.Empty;
            this.NombreUsuario = string.Empty;
            this.Contrasena = string.Empty;
            this.ConfirmarContrasena = string.Empty;
            this.Activo = 0;
            this.Foto = string.Empty;
        }

        public Usuario(int usuarioid, string nombres, string apellidos, string telefono, string email, string direccion, string nombreusuario, string contrasena, string confirmarcontrasena,int activo,string foto)
        {
            this.UsuarioId = usuarioid;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Email = email;
            this.Direccion = direccion;
            this.NombreUsuario = nombreusuario;
            this.Contrasena = contrasena;
            this.ConfirmarContrasena = confirmarcontrasena;
            this.Activo = activo;
            this.Foto = foto;
        }
    }
}
