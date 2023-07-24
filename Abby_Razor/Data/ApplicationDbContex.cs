using Abby_Razor.Model;
using Microsoft.EntityFrameworkCore;

namespace Abby_Razor.Data
{
    public class ApplicationDbContex : DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options) : base(options)
        {
            
        }

        //   class name will be category table , Columns
        public DbSet<Category> Category { get; set; }
    }
}
