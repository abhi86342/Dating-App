using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
namespace API.Data
{
    public class TemporaryDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        //////// 
        // public DataContext CreateDbContext(string[] args)
        // {
        //     var builder = new DbContextOptionsBuilder<DataContext>();
        //     var configuration = new ConfigurationBuilder()
        //       .SetBasePath(System.AppDomain.CurrentDomain.BaseDirectory)
        //       .AddJsonFile("appsettings.json")
        //       .Build();

        //     builder.UseSqlite(configuration.GetConnectionString("Defa‌​ultConnection"));
        //     return new DataContext(builder.Options);
        // }
        public DataContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DataContext>();
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
            builder.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            return new DataContext(builder.Options);
        }

    }
}