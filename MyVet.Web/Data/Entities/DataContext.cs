using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyVet.Web.Data.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Owner> Owners { get; set; }
    }

}
