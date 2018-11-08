using ExampleDomain.Models.Example1;
using Microsoft.EntityFrameworkCore;

namespace Example.Data
{
    public class ExampleDbContext : DbContext
    {
        public ExampleDbContext(DbContextOptions<ExampleDbContext> options)
           : base(options)
        { }
        public DbSet<DomainModel> DomainModels { get; set; }


    }
}
