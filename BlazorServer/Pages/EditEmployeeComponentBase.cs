using AutoMapper;
using BlazorServer.Model;
using BlazorServer.Services;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Pages
{
    public class EditEmployeeComponentBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Inject]
        public IDepartmentService  DepartmentService { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();
        public string DepartmentId { get; set; }

        public Employee Employee { get; set; } = new Employee();

        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();
        
        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IMapper Mapper { get; set; }


        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            Departments = (await DepartmentService.GetDepartments()).ToList();
            Mapper.Map(Employee, EditEmployeeModel);
        }

        protected void HandleValidSubmit()
        { 
        
        }
    }
}
