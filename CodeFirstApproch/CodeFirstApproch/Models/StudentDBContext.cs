using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproch.Models
{
    public class StudentDBContext : DbContext
    {
        //ctor

        public StudentDBContext(DbContextOptions options) : base(options) 
        {
                
        }

        public DbSet<Student> Students   { get; set; }
    }
}
