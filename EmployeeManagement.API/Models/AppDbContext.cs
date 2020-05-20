using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>().HasData(
                new Department {  DepartmentId= 1, DepartmentName = "IT"});
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "John",
                    LastName = "Hasting",
                    Email = "David@Dell.com",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1990, 10, 5),
                    DepartmentId = 1,
                    PhotoPath = "MyStaticFiles/TrainTrack.jpg"
                });

            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   EmployeeId = 2,
                   FirstName = "John",
                   LastName = "Hasting",
                   Email = "David@Dell.com",
                   Gender = Gender.Male,
                   DateOfBirth = new DateTime(1990, 10, 5),
                   DepartmentId = 2,
                   PhotoPath = "MyStaticFiles/Lukacross.jpg"
               });

            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   EmployeeId = 3,
                   FirstName = "John",
                   LastName = "Hasting",
                   Email = "David@Dell.com",
                   Gender = Gender.Male,
                   DateOfBirth = new DateTime(1990, 10, 5),
                   DepartmentId = 3,
                   PhotoPath = "MyStaticFiles/Lunavala.jpg"
               });

            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   EmployeeId = 4,
                   FirstName = "John",
                   LastName = "Hasting",
                   Email = "David@Dell.com",
                   Gender = Gender.Male,
                   DateOfBirth = new DateTime(1990, 10, 5),
                   DepartmentId = 4,
                   PhotoPath = "MyStaticFiles/Mary.jpg"
               });

            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   EmployeeId = 5,
                   FirstName = "John",
                   LastName = "Hasting",
                   Email = "David@Dell.com",
                   Gender = Gender.Male,
                   DateOfBirth = new DateTime(1990, 10, 5),
                   DepartmentId = 3,
                   PhotoPath = "MyStaticFiles/myFlowers.jpg"
               });

            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   EmployeeId = 6,
                   FirstName = "John",
                   LastName = "Hasting",
                   Email = "David@Dell.com",
                   Gender = Gender.Male,
                   DateOfBirth = new DateTime(1990, 10, 5),
                   DepartmentId = 4,
                   PhotoPath = "MyStaticFiles/myLotus.jpg"
               });
        }
    }
}
