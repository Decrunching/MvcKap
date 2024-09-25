using Microsoft.EntityFrameworkCore;

namespace MvcKap.Data
{
    public class MvcKapContext : DbContext
    {
        public MvcKapContext (DbContextOptions<MvcKapContext> options)
            : base(options)
        {
        }

        public DbSet<MvcKap.Models.Calculations> Calculations { get; set; } = default!;
        public DbSet<MvcKap.Models.Patient> Patient { get; set; } = default!;
    }
}
