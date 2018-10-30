using AppHealth.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AppHealth.Data
{
    public class SeedDatabase
    {

        public static async System.Threading.Tasks.Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            if (!context.Roles.Any())
            {
                await context.Roles.AddAsync(new Role { Id = 1, Name = "Admin" });
                await context.Roles.AddAsync(new Role { Id = 2, Name = "Operator" });

                context.Database.OpenConnection();
                try
                {
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT " + "[Role]" + " ON;");
                    context.SaveChanges();
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT " + "[Role]" + " OFF;");
                }
                catch (Exception)
                {

                }
                finally
                {
                    context.Database.CloseConnection();
                }

            }

            if (!context.Users.Any())
            {              
                await context.Users.AddAsync(new User
                {
                    Id = 1,
                    Name = "Admin",
                    Username = "admin",
                    Password = "admin",
                    RoleId = 1
                });

                context.Database.OpenConnection();
                try
                {
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT " + "[User]" + " ON;");
                    context.SaveChanges();
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT " + "[User]" + " OFF;");
                }
                catch(Exception)
                {

                }
                finally
                {
                    context.Database.CloseConnection();
                }


                
            }
        }


    }
}
