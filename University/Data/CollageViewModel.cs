using Microsoft.EntityFrameworkCore;
using University.Models.Entities;

namespace University.Data
{
    public class CollageViewModel:DbContext
    {

        public CollageViewModel(DbContextOptions<CollageViewModel> options):base (options)
        {
            
        }
        public DbSet<Collage> Collage { get; set; }
    }
}
