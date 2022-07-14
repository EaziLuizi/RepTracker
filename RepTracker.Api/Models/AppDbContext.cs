using System;
using RepTracker.Shared;
using Microsoft.EntityFrameworkCore;

namespace RepTracker.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 1, Name = "South Africa" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 2, Name = "Germany" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 3, Name = "Portugal" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 4, Name = "USA" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 5, Name = "Japan" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 6, Name = "China" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 7, Name = "UK" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 8, Name = "France" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 9, Name = "Brazil" });


            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                CountryId = 1,
                MaritalStatus = MaritalStatus.Married,
                BirthDate = new DateTime(1988, 12, 19),
                Email = "marco@repadmins.com",
                FirstName = "Marco",
                LastName = "Luizinho",
                Gender = Gender.Male,
                PhoneNumber = "0111237890",
                Comment = "...",
                EndDate = null,
                StartDate = new DateTime(2017, 1, 3),
                Latitude = -26.166622,
                Longitude = 28.309116,
                ImageName = "1.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                CountryId = 1,
                MaritalStatus = MaritalStatus.Married,
                BirthDate = new DateTime(1992, 1, 16),
                Email = "john@repadmins.com",
                FirstName = "John",
                LastName = "Smith",
                Gender = Gender.Male,
                PhoneNumber = "0123215432",
                Comment = "Very Good Employee",
                EndDate = null,
                StartDate = new DateTime(2019, 11, 1),
                Latitude = -26.169593,
                Longitude = 27.902952,
                ImageName = "2.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                CountryId = 5,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1985, 5, 22),
                Email = "Joanne@repadmins.com",
                FirstName = "Joanne",
                LastName = "Pinto",
                Gender = Gender.Female,
                PhoneNumber = "55523429803",
                Comment = "...",
                EndDate = null,
                StartDate = new DateTime(2019, 11, 1),
                Latitude = 50.8503,
                Longitude = 4.3517,
                ImageName = "3.jpg"
            });
        }
    }
}
