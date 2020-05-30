using EmployeeManagement.Models;
using EmployeeManagement.Models.CustomValidators;
using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Model
{
    public class EditEmployeeModel
    {

        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "FirstName is mandatory")]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain = "dell.com")]
        public string Email { get; set; }

        [CompareProperty("Email",
        ErrorMessage = "Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        [ValidateComplexType]
        public Department Department { get; set; } = new Department();

        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
    }
}
