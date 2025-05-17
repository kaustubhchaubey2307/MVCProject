using Microsoft.EntityFrameworkCore;
using TableGrid.Models;

namespace TableGrid.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<mTableGrid> tbl_User { get; set; }
    }
}
