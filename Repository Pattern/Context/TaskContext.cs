using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Repository_Pattern.Model;

namespace Repository_Pattern.Context
{
    public class TaskContext : DbContext
    {
       
        public TaskContext(DbContextOptions<TaskContext> options) 
            : base(options)
        {
        }

        public DbSet<Model.Task> Tasks { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }


    }
}
