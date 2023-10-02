using Microsoft.EntityFrameworkCore;
namespace entityframework.Pages
{
    public class MydbContext : DbContext
    {
        public DbSet<EFPerson> People { get; set; }

        public MydbContext(DbContextOptions<MydbContext>options)
            : base(options)
        {

        }
    }
}
