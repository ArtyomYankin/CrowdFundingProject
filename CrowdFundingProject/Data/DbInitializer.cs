using CrowdFundingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdFundingProject.Data
{
    public class DbInitializer
    {
        public static void Seed(ApplicationDbContext Content)
        {

        //    if (!Content.Categories.Any())
        //    {
        //        Content.Categories.AddRange(Categories.Select(c => c.Value));
        //    }

        //    if (!Content.Companies.Any())
        //    {
        //        Content.AddRange
        //        (
        //            new Company
        //            {
        //                Name = "RaceSimulator3000",
        //                ShortDescription = "New race videogame",
        //                LongDescription = "Videogame with new cars and new roads",
        //                ImageLink = "https://www.maximonline.ru/images/th/100/18/99844-MTE3NjM1OTk1Yg.jpg",
        //                Category = Categories["VideoGames"]
        //            },
        //            new Company
        //            {
        //                Name = "Goat",
        //                ShortDescription = "New album",
        //                LongDescription = "Writing new album 'Goat'",
        //                ImageLink = "https://upload.wikimedia.org/wikipedia/ru/e/e6/Goat_Simulator_logo.png",
        //                Category = Categories["Music"]
        //            }
        //        );
        //    }
        //    Content.SaveChanges();
        //}
        //private static Dictionary<string, Category> Category;
        //public static Dictionary<string, Category> Categories
        //{
        //    get
        //    {
        //        if (Category == null)
        //        {
        //            var list = new Category[]
        //            {
        //                new Category {CategoryName = "Music", Description = "New albums, new instruments and so on"},
        //                new Category {CategoryName = "VideoGames", Description = "New videogames and so on"}
        //            };

        //            Category = new Dictionary<string, Category>();
        //            foreach (Category el in list)
        //            {
        //                Category.Add(el.CategoryName, el);
        //            }
        //        }
        //        return Category;
            }
        }
    }
//}
