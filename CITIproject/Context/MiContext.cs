using CITIproject.Models;
using Microsoft.EntityFrameworkCore;

namespace CITIproject.Context
{
    public class MiContext: DbContext
    {
        public MiContext() { 
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ingeniero> Ingenieros { get; set; }
    }
}
