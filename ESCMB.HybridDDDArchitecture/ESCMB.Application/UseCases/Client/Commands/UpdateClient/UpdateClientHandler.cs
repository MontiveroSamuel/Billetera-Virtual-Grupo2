using Common.Application.Commands;
using ESCMB.Application.Common;
using ESCMB.Application.DomainEvents;
using ESCMB.Application.Exceptions;
using ESCMB.Application.Repositories.Sql;
using ESCMB.Application.UseCases.DummyEntity.Commands.UpdateDummyEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCMB.Application.UseCases.Client.Commands.UpdateClient
{
    
    internal sealed class UpdateClientHandler : IRequestCommandHandler<UpdateClientCommand>
    {
        private readonly IEventPublisher _publisher;
        private readonly IClientRepository _clientRepository;

        public UpdateClientHandler(IEventPublisher eventPublisher, IClientRepository ClientRepository)
        {
            _publisher = eventPublisher ?? throw new ArgumentNullException(nameof(eventPublisher));
            _clientRepository = ClientRepository ?? throw new ArgumentNullException(nameof(ClientRepository));
        }

        public async Task<Unit> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Client entity = await _clientRepository.FindOneAsync(request.email);

            if (entity is null) throw new EntityDoesNotExistException();

            entity.SetEmail(request.email);

            try
            {
                _clientRepository.Update(entity);

                await _publisher.Publish(entity.To<DummyEntityUpdated>(), cancellationToken);

                return Unit.Value;
            }
            catch (Exception ex)
            {
                throw new BussinessException(Constants.PROCESS_EXECUTION_EXCEPTION, ex.InnerException);
            }
        }
    }
}
