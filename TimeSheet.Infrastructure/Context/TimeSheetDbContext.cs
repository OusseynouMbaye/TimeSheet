using Microsoft.EntityFrameworkCore;
using TimeSheet.Domain.Entities;

namespace TimeSheet.Infrastructure.Context
{
    public class TimeSheetDbContext : DbContext
    {
        public TimeSheetDbContext(DbContextOptions<TimeSheetDbContext> options) : base(options)
        {
        }

        public DbSet<Domain.Entities.TimeSheet> TimeSheets { get; set; }
    }
   
}
