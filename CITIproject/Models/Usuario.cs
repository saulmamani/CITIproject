using CITIproject.Dtos;

namespace CITIproject.Models
{
    public class Usuario
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? NombreCompleto { get; set; }
        public RolEnum Rol { get; set; }
    }
}
