using FinanceTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<SavingsGoal> SavingsGoals { get; set; }
        public DbSet<Saving> Savings { get; set; }
        public DbSet<BudgetCategoryMapper> BudgetCategoryMappers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<Saving>()
                .Property(x => x.Type)
                .HasConversion<int>();

            builder.Entity<BudgetCategoryMapper>().HasKey(x => new { x.BudgetId, x.CategoryId });

            builder.Entity<BudgetCategoryMapper>()
                .HasOne<Budget>(x => x.Budget)
                .WithMany(x => x.Mapper)
                .HasForeignKey(x => x.BudgetId);

            builder.Entity<BudgetCategoryMapper>()
                .HasOne<Category>(x => x.Category)
                .WithMany(x => x.Mapper)
                .HasForeignKey(x => x.CategoryId);

            base.OnModelCreating(builder);
        } 
    }
}
