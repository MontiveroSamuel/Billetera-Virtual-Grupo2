using Common.Domain.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCMB.Domain.Validators
{
    public class ClientValidator: EntityValidator<Domain.Entities.Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.Email).NotNull().NotEmpty().WithMessage(Constants.NOTNULL_OR_EMPTY);
        }
    }
}
