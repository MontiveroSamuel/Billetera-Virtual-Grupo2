using Common.Application.Commands;
using ESCMB.Application.UseCases.Client.Commands.RegistredClient;
using Microsoft.AspNetCore.Mvc;

namespace ESCMB.API.Controllers
{


    [ApiController]
    public class ClientsController : BaseController
    {
        private readonly IEventPublisher _commandQueryBus;

        public ClientsController(IEventPublisher commandQueryBus)
        {
            _commandQueryBus = commandQueryBus ?? throw new ArgumentNullException(nameof(commandQueryBus));
        }

        [HttpPost("api/v1/[controller]")]
        public async Task<IActionResult> RegisterClient(RegisterClientCommand command)
        {
            if (command is null) return BadRequest();

            var id = await _commandQueryBus.Send(command);

            return Created($"api/[Controller]/{id}", new { Id = id });
        }
    }
}
