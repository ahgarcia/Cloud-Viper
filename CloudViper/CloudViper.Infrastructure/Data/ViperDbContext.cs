using CloudViper.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudViper.Infrastructure.Data
{
    public class ViperDbContext : DbContext
    {
        public ViperDbContext(DbContextOptions<ViperDbContext> options)
            : base(options)
        {
        }

        public DbSet<CountryRegion> CountriesRegion { get; set; }
        public DbSet<StateProvince> StatesProvince { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<RoadType> RoadsType { get; set; }
        public DbSet<AddressType> AddressesType { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<MaritalStatus> MaritalsStatus { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<JobTitle> JobsTitle { get; set; }
        public DbSet<RegimenFiscal> RegimenesFiscales { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressSAT> AddressesSAT { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDepartmentHistory> EmployeesDepartmentHistory { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductCategory> ProductsCategory { get; set; }
        public DbSet<ProductSubCategory> ProductsSubCategory { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInventory> ProductsInventory { get; set; }
        public DbSet<ProductCostHistory> ProductsCostHistory { get; set; }
        public DbSet<ProductListPriceHistory> ProductsListPriceHistory { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 
                optionsBuilder.UseMySql(@"Server=localhost;Port=3306;Database=viper_developments;Uid=root;Pwd=;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.DisplayName();
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
