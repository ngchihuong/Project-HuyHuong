using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.DBContext
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<BillInfo> BillInfos { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Employees> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {

            optionsBuilder.UseMySQL("server=localhost;userid=root;password=@2322004Hh;port=3306;database=PhoneStore");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employees>()
                .HasKey(e => e.Employee_ID);
            modelBuilder.Entity<Accounts>().HasKey(b => b.username);

            modelBuilder.Entity<Bill>().HasKey(b => b.Bill_ID);

            modelBuilder.Entity<BillInfo>().HasKey(b => b.Bill_Info_ID);

            modelBuilder.Entity<Categories>().HasKey(b => b.Cag_ID);

            modelBuilder.Entity<Customers>().HasKey(b => b.Cus_ID);

            modelBuilder.Entity<Products>().HasKey(b => b.Pro_ID);

            modelBuilder.Entity<Accounts>().HasOne(p => p.Employees).WithOne(b => b.Accounts).HasForeignKey<Accounts>(b => b.Employee_ID);

            modelBuilder.Entity<Bill>().HasOne(p => p.Account).WithMany(b => b.Bills).HasForeignKey(b => b.username);

            modelBuilder.Entity<Bill>().HasOne(p => p.Customer).WithMany(b => b.Bills_c).HasForeignKey(b => b.Cus_ID);

            modelBuilder.Entity<BillInfo>().HasOne(p => p.Bill).WithMany(b => b.billInfos).HasForeignKey(b => b.Bill_ID);

            modelBuilder.Entity<BillInfo>().HasOne(p => p.Product).WithMany(b => b.BillInfos).HasForeignKey(b => b.Pro_ID);

            modelBuilder.Entity<Products>().HasOne(p => p.Category).WithMany(b => b.products).HasForeignKey(b => b.Cag_ID);
        }
    }
}
