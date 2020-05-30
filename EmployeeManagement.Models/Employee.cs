﻿using EmployeeManagement.Models.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models
{
   public class Employee
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
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        public Department Department { get; set; }     
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }

    }
}
