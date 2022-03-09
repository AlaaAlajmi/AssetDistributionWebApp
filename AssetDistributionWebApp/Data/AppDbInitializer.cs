using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetDistributionWebApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AssetDistributionWebApp.Data
{
    public class AppDbInitializer
    {
        //Seeding the account table (not permenant)
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Accounts
                if (!context.accounts.Any())
                {
                    context.accounts.AddRange(new List<Account>()
                    {
                        new Account()
                        {
                            username = "account1",
                            password = "123"
                        },
                         new Account()
                        {
                            username = "account2",
                            password = "123"
                        },
                          new Account()
                        {
                            username = "account3",
                            password = "123"
                        },

                    });
                    context.SaveChanges();
                }
            }


        }
    }
}
