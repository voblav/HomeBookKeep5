using System;
using System.Collections.Generic;
using System.Text;
using HomeBookKeep5.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeBookKeep5
{
    public class ApplicationContext : DbContext
    {
        private string _databasePath;

        public DbSet<CostSubCat> CostSubCats { get; set; }
        public DbSet<CostCat> CostCats { get; set; }
        public DbSet<IncomeCat> IncomeCats { get; set; }
        public DbSet<IncomeSubCat> IncomeSubCats { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Purse> Purses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Partner> Partners { get; set; }

        public ApplicationContext(string databasePath)
        {
            _databasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}
