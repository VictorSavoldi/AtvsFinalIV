using Microsoft.EntityFrameworkCore;
using webapicarros.Models;


namespace webapicarros.Persistence
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        {

        }

        public DbSet<Carro> Carros { get; set; }


    }
}