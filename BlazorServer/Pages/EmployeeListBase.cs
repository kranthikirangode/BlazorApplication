using BlazorServer.Services;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        //private void LoadEmployees()
        //{

        //    System.Threading.Thread.Sleep(5000);

        //    Employee e1 = new Employee {
        //        EmployeeId = 1,
        //        FirstName = "John",
        //        LastName = "Hastings",
        //        Email = "David@Dell.com",
        //        DateOfBirth = new DateTime(1980, 11, 5),
        //        Gender = Gender.Male,
        //        DepartmentId = 1,
        //        PhotoPath = "MyStaticFiles/TrainTrack.jpg"
        //    };

        //    Employee e2 = new Employee
        //    {
        //        EmployeeId = 2,
        //        FirstName = "Sam",
        //        LastName = "Ram",
        //        Email = "Sam@Dell.com",
        //        DateOfBirth = new DateTime(1990, 12, 5),
        //        Gender = Gender.Male,
        //        DepartmentId = 2,
        //        PhotoPath = "MyStaticFiles/Lukacross.jpg"
        //    };

        //    Employee e3 = new Employee
        //    {
        //        EmployeeId = 3,
        //        FirstName = "Kranthi",
        //        LastName = "Kiran",
        //        Email = "kranthi@Dell.com",
        //        DateOfBirth = new DateTime(1986, 10, 5),
        //        Gender = Gender.Male,
        //        DepartmentId = 3,
        //        PhotoPath = "MyStaticFiles/Lunavala.jpg"
        //    };

        //    Employee e4 = new Employee
        //    {
        //        EmployeeId = 4,
        //        FirstName = "Mary",
        //        LastName = "Rao",
        //        Email = "mary@Dell.com",
        //        DateOfBirth = new DateTime(1995, 10, 5),
        //        Gender = Gender.Female,
        //        DepartmentId = 4,
        //        PhotoPath = "MyStaticFiles/Mary.jpg"
        //    };

        //    Employee e5 = new Employee
        //    {
        //        EmployeeId = 5,
        //        FirstName = "Mounika",
        //        LastName = "Reddy",
        //        Email = "Mounica@Dell.com",
        //        DateOfBirth = new DateTime(1992, 10, 5),
        //        Gender = Gender.Female,
        //        DepartmentId = 5,
        //        PhotoPath = "MyStaticFiles/myFlowers.jpg"
        //    };

        //    Employee e6 = new Employee
        //    {
        //        EmployeeId = 6,
        //        FirstName = "Keerthi",
        //        LastName = "Reddy",
        //        Email = "Keerthi@Dell.com",
        //        DateOfBirth = new DateTime(1992, 10, 5),
        //        Gender = Gender.Female,
        //        DepartmentId = 6,
        //        PhotoPath = "MyStaticFiles/myLotus.jpg"
        //    };

        //    Employee e7 = new Employee
        //    {
        //        EmployeeId = 7,
        //        FirstName = "Puppy",
        //        LastName = "cute",
        //        Email = "Keerthi@Dell.com",
        //        DateOfBirth = new DateTime(1992, 10, 5),
        //        Gender = Gender.Female,
        //        DepartmentId = 7,
        //        PhotoPath = "MyStaticFiles/mypuppy.jpg"
        //    };

        //    Employee e8 = new Employee
        //    {
        //        EmployeeId = 8,
        //        FirstName = "John",
        //        LastName = "Hastings",
        //        Email = "David@Dell.com",
        //        DateOfBirth = new DateTime(1980, 11, 5),
        //        Gender = Gender.Male,
        //        DepartmentId = 8,
        //        PhotoPath = "MyStaticFiles/Lotusleaf.jpg"
        //    };

        //    Employee e9 = new Employee
        //    {
        //        EmployeeId = 9,
        //        FirstName = "John",
        //        LastName = "Hastings",
        //        Email = "David@Dell.com",
        //        DateOfBirth = new DateTime(1980, 11, 5),
        //        Gender = Gender.Male,
        //        DepartmentId =9,
        //        PhotoPath = "MyStaticFiles/tulip.jpg"
        //    };

        //    Employees = new List<Employee> { e1, e2, e3,e4, e5,e6};
        //}
    
    }
}
