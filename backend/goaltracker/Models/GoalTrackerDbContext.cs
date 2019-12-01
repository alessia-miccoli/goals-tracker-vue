using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace goaltracker.Models
{
    public class GoalTrackerDbContext:DbContext
    {
        public GoalTrackerDbContext(DbContextOptions<GoalTrackerDbContext> options) : base(options) { }

        public DbSet<Goal> Goals { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
