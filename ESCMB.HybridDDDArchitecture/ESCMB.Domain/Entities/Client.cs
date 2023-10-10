using Common.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using static ESCMB.Domain.Enums;

namespace ESCMB.Domain.Entities
{
    public class Client : DomainEntity<Domain.Validators.ClientValidator>
    {
        [Key]
        public int Id { get; private set; }
        public string Apellido { get; private set; }
        public string Nombre { get; private set; }
        public string CuilCuit { get; private set; }
        public string Email { get; private set; }
        public ClientStatus Status { get; set; }
        public Client()
        {
        }

        public Client(string apellido, string nombre, string cuilCuit, string email)
        {
            Apellido = apellido;
            Nombre = nombre;
            CuilCuit = cuilCuit;
            Email = email;
            Status = ClientStatus.Pending;
        }

        public string SetEmail(string value)
        {
            return Email = value ?? throw new ArgumentNullException(nameof(value));

        }
    }
}
