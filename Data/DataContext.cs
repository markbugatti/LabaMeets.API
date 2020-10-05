using Microsoft.EntityFrameworkCore;
using LabaMeets.API.Models;

namespace LabaMeets.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Participant> Participants { get; set; }
    }
}