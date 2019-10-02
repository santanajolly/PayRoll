using Microsoft.EntityFrameworkCore;
using PayRoll.Models;


namespace PayRoll.Data
{
    public class PayrollContext : DbContext
    {
        public PayrollContext(DbContextOptions<PayrollContext> options)
           : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
    }
}
