using FinanceTracker.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Data
{
    public class Seed
    {
        public static void SeedAll(AppDbContext context) 
        {
            SeedCategories(context);
        }

        public static void SeedCategories(AppDbContext context) 
        {
            if (!context.Categories.Any())
            {
                var categoryData = System.IO.File.ReadAllText("Data/SeedCategories.json");

                var categories = JsonConvert.DeserializeObject<List<Category>>(categoryData);

                foreach (var category in categories)
                {
                    context.Categories.Add(category);
                }

                context.SaveChanges();
            }
        }
    }
}
