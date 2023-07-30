using Microsoft.EntityFrameworkCore;
using ProcessRUs.Entities;

namespace ProcessRUs.Data
{
    public class ProcessRUsContext : DbContext
    {
        public ProcessRUsContext(DbContextOptions<ProcessRUsContext> opt) : base(opt)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Fruit> Fruits { get; set; }

    }
}

