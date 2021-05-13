﻿using CrowdFundingProject.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFundingProject.Data
{
    public class DbInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            string adminEmail = "admin@gmail.com";
            string password = "admin";
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                User admin = new User { Email = adminEmail, UserName = adminEmail };
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }

                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(Categories.Select(c => c.Value));
                }

                if (!context.Companies.Any())
                {
                    context.AddRange
                    (
                        new Company
                        {
                            Name = "RaceSimulator3000",
                            ShortDescription = "New race videogame",
                            LongDescription = "Videogame with new cars and new roads",
                            ImageLink = "https://www.maximonline.ru/images/th/100/18/99844-MTE3NjM1OTk1Yg.jpg",
                            Category = Categories["VideoGames"]
                        },
                        new Company
                        {
                            Name = "Goat",
                            ShortDescription = "New album",
                            LongDescription = "Writing new album 'Goat'",
                            ImageLink = "https://upload.wikimedia.org/wikipedia/ru/e/e6/Goat_Simulator_logo.png",
                            Category = Categories["Music"]
                        }
                    );
                }
                context.SaveChanges();
        }
        private static Dictionary<string, Category> Category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (Category == null)
                {
                    var list = new Category[]
                    {
                        new Category {CategoryName = "Music", Description = "New albums, new instruments and so on"},
                        new Category {CategoryName = "VideoGames", Description = "New videogames and so on"},
                        new Category {CategoryName = "Education", Description = "New studying curses"},
                        new Category {CategoryName = "Sport", Description="Sport academies"},
                        new Category {CategoryName = "StartUp", Description="New ideas, that can become popular and useful"}
                    };

                    Category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        Category.Add(el.CategoryName, el);
                   }
             }
                return Category;
            }
        }
    }
}
