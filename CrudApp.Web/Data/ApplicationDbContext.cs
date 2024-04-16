using CrudApp.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudApp.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        { 

        }

        public DbSet<Student> Students { get; set; }
    }
}
