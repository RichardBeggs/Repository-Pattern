using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Repository_Pattern.Context;
using Repository_Pattern.Model;
using System.Data.Entity;

namespace Repository_Pattern.Data.Seed
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {


            using (var context = new TaskContext(serviceProvider.GetRequiredService<DbContextOptions<TaskContext>>()))
            {

                context.Database.EnsureCreated();

                if (!context.Countries.Any())
                {
                    context.Countries.Add(new Country { Name = "Afghanistan" });
                    context.Countries.Add(new Country { Name = "Albania" });
                    context.Countries.Add(new Country { Name = "Algeria" });
                    context.Countries.Add(new Country { Name = "Andorra" });
                    context.Countries.Add(new Country { Name = "Angola" });
                    context.Countries.Add(new Country { Name = "Antigua and Barbuda" });
                    context.Countries.Add(new Country { Name = "Argentina" });
                    context.Countries.Add(new Country { Name = "Armenia" });
                    context.Countries.Add(new Country { Name = "Australia" });
                    context.Countries.Add(new Country {  Name = "Austria" });
                    context.Countries.Add(new Country {  Name = "Azerbaijan" });
                    context.SaveChanges();
                }

                if (!context.Tasks.Any())
                {
                    context.Tasks.Add(new Model.Task { Name = "Get up", IsVisible = true });
                    context.Tasks.Add(new Model.Task { Name = "Make bed", IsVisible = true });
                    context.Tasks.Add(new Model.Task { Name = "Wash face", IsVisible = true });
                    context.SaveChanges();
                }

            };
                
        }
        
    }
}
