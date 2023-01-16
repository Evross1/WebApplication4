using Microsoft.EntityFrameworkCore;

namespace WebApplication4
{
    public class LinkDbContext : DbContext
    {
        public DbSet<ServiceRequset> ServiceRequsets { get; set; }
        public DbSet<Fault> Faults { get; set; }

        public DbSet<CacheObject> CacheObjects { get; set; }

        public DbSet<Requestor> Requestors { get; set; }

        public LinkDbContext(DbContextOptions<LinkDbContext> options) : base(options) { }



    }
}
//z jakiegoś powodu nie miałem tego templatu do bazy danych więc migracji nie zrobiłem