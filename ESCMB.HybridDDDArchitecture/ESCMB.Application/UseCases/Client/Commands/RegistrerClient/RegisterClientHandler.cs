using Common.Application.Commands;
using ESCMB.Application.UseCases.Client.Commands.RegistredClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCMB.Application.UseCases.Client.Commands.RegistrerClient
{
    internal class RegisterClientHandler : IRequestCommandHandler<RegisterClientCommand string>
    {
        private readonly IEventPublisher _eventPublisher;

        public RegisterClientHandler(IEventPublisher  eventPublisher )
        {
             _eventPublisher = eventPublisher ?? throw new ArgumentNullException(nameof(eventPublisher));
        }
        public Task<string> Handle(RegisterClientCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
