using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AssetDistributionWebApp.Data.Static;
using AssetDistributionWebApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
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
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {



                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                if (!await roleManager.RoleExistsAsync(UserRoles.Sender))

                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Sender));

                if (!await roleManager.RoleExistsAsync(UserRoles.Reciever))

                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Reciever));
                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUsers>>();
                string senderuseremail = "Sender@gmail.com";
                var senderUser = await userManager.FindByEmailAsync(senderuseremail);
                if (senderUser == null)
                {
                    var NewSenderUser = new ApplicationUsers()
                    {
                        UserName = "sender",
                        Email = senderuseremail
                        //EmailConfirmed = true
                    };

                    await userManager.CreateAsync(NewSenderUser, "User@123");

                    await userManager.AddToRoleAsync(NewSenderUser, UserRoles.Sender);

                    if (senderUser == null)
                    {
                        Debug.WriteLine("abc");
                    }
                }
                var recieveruseremail = "reciever@gmail.com";
                var recieverUser = await userManager.FindByEmailAsync(recieveruseremail);

                if (recieverUser == null)
                {
                    var NewRecieverUser = new ApplicationUsers()
                    {
                        UserName = "reciever",
                        Email = recieveruseremail
                        //EmailConfirmed = true
                    };
                    await userManager.CreateAsync(NewRecieverUser, "User@123");
                    await userManager.AddToRoleAsync(NewRecieverUser, UserRoles.Reciever);
                }

            }
        }
    }
}
