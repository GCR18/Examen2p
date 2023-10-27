using Microsoft.EntityFrameworkCore;
using Practica_taller.Modelos;

namespace Practica_taller.context
{
    public class aplicacion_Context : DbContext
    {
        public aplicacion_Context
            (DbContextOptions<aplicacion_Context> options)
            : base(options) { }

        public DbSet<Musica> Musica { get; set; }
        public DbSet<Disco> Disco { get; set; }

    }
}
