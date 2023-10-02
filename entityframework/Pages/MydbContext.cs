using Microsoft.EntityFrameworkCore;
namespace entityframework.Pages
{
    public class MydbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public MydbContext(DbContextOptions<MydbContext>options)
            : base(options)
        {

        }
    }
}
