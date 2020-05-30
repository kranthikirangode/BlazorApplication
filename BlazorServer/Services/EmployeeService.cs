using AutoMapper.Configuration.Conventions;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorServer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetJsonAsync<Employee[]>("api/employees");
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await httpClient.GetJsonAsync<Employee>($"api/employees/{id}");
        }

        public async Task<Employee> UpdateEmployee(Employee UpdateEmployee)
        {
           return await httpClient.PutJsonAsync<Employee>($"api/employees", UpdateEmployee);
        }

        public async Task<Employee> CreateEmployee(Employee CreateEmployee)
        {
            return await httpClient.SendJsonAsync<Employee>(HttpMethod.Post,$"api/employees/",Newtonsoft.Json.JsonConvert.SerializeObject(CreateEmployee));
        }

        public async Task DeleteEmployee(int id)
        {
            await httpClient.DeleteAsync($"api/employees/{id}");
        }
    }
}
