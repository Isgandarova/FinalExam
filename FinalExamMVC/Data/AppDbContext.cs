using FinalExamMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalExamMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<OurPortifolio>ourPortifolio {  get; set; }

     
    }
}
