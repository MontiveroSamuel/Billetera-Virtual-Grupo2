using Common.Application.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ESCMB.Domain.Enums;

namespace ESCMB.Application.UseCases.Client.Commands.UpdateClient
{
    internal class UpdateClientCommand: IRequestCommand
    {
        // Que vamos a necesitar si o si al actualizar datos?
        //[Required]
        //public int DummyIdProperty { get; set; }
        [Required]
        public string? email { get; set; }
        //public DummyValues DummyPropertyThree { get; set; }
        
        public UpdateClientCommand()
        {
        }
    }
}
