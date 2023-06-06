using Microsoft.EntityFrameworkCore;

namespace CoreMVC1.Models
{
    public class GadgetContext : DbContext
    {
        public GadgetContext(DbContextOptions<GadgetContext> options) : base(options)
        {
        }

        public DbSet<Gadget> Gadgets { get; set; }
    }
}
