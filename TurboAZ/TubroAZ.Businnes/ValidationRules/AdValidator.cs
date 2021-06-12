using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;

namespace TubroAZ.Businnes.ValidationRules
{
    public class AdValidator: AbstractValidator<Ad>
    {
        public AdValidator()
        {
            RuleFor(e => e.Note).MaximumLength(500);           
        }

    }
  
}
