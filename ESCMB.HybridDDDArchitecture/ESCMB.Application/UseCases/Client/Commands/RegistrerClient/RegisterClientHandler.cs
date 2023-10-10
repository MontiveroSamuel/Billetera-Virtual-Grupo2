using Common.Application.Commands;
using ESCMB.Application.Common;
using ESCMB.Application.DomainEvents;
using ESCMB.Application.Repositories.Sql;
using ESCMB.Application.UseCases.Client.Commands.RegistredClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCMB.Application.UseCases.Client.Commands.RegistrerClient
{
    internal class RegisterClientHandler : IRequestCommandHandler<RegisterClientCommand, string>
    {
        private readonly IEventPublisher _eventPublisher;
        private readonly IClientRepository _clientRepository;

        public RegisterClientHandler(IEventPublisher eventPublisher, IClientRepository clientRepository)
        {
            _eventPublisher = eventPublisher ?? throw new ArgumentNullException(nameof(eventPublisher));
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
        }
        public async Task<string> Handle(RegisterClientCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Client client = new Domain.Entities.Client(request.Apellido, request.Nombre, request.CuilCuit, request.Email);

            if (!client.IsValid)
            {
                //TODO: AQUI VA UNA EXCEPCION
            }

            string clientId = await _clientRepository.AddOneAsync(client).ConfigureAwait(false);

            await _eventPublisher.Publish(client.To<ClientCreated>(), cancellationToken).ConfigureAwait(false);

            return clientId;
        }

    }
}
