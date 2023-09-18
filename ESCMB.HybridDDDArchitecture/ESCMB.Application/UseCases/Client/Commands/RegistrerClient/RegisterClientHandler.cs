using Common.Application.Commands;
using ESCMB.Application.Repositories.Sql;
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
        private readonly IClientRepository _clientRepository;

        public RegisterClientHandler(IEventPublisher  eventPublisher, IClientRepository clientRepository )
        {
             _eventPublisher = eventPublisher ?? throw new ArgumentNullException(nameof(eventPublisher));
             _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
        }
        public Task<string> Handle(RegisterClientCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Logica para dar de alta cliente
        }

    }
}
