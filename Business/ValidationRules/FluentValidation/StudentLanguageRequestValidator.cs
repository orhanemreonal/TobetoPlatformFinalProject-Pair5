using Business.Dtos.Students.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class StudentLanguageRequestValidator : AbstractValidator<CreateStudentLanguageRequest>
    {
        public StudentLanguageRequestValidator()
        {
            RuleFor(p => p.LanguageLevel).NotEmpty();
           
        }
        
    }

   
}
