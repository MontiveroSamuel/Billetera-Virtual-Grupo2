using Common.Application.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ESCMB.Domain.Enums;

namespace ESCMB.Application.UseCases.Client.Commands.RegistredClient
{
    public class RegisterClientCommand : IRequestCommand<string>
    {
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string CuilCuit { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
