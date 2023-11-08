using CITIproject.Dtos;

namespace CITIproject.Models
{
    public class Ingeniero
    {
        public int Rni { get; set; }
        public string? Ci { get; set; }
        public string? NombreCompleto { get; set; }

        public DateTime FechaRegisto { get; set; }
        public EspecialidadEnum Especialidad { get; set; }
    }
}
