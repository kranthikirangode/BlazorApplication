using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models.CustomValidators
{
    public class EmailDomainValidator : ValidationAttribute
    {
        public string AllowedDomain { get; set; }

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {      
            if (value.ToString().Contains('@'))
            {
                string[] strings = value.ToString().Split('@');
                if (strings[1].ToUpper() == AllowedDomain.ToUpper())
                {
                    return null;
                }
            }
           
            return new ValidationResult($"Domain must be {AllowedDomain}",
            new[] { validationContext.MemberName });
        }
    }
}
