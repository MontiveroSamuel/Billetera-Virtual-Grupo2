using Common.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ESCMB.Domain.Entities
{
    public class Client : DomainEntity<Domain.Validators.ClientValidator>
    {
        public string IdClient { get; private set; }
        public string Apellido { get; private set; }
        public string Nombre { get; private set; }

        public string CuilCuit { get; private set; }
        public string Email { get; private  set; }

        public int Estado { get; set; }
        public Client()
        {
            
        }

        public Client(string id, string email)
        {
            IdClient = id;
            Email = email;
        }

        public string SetEmail( string value)
        {
            return Email = value ?? throw new ArgumentNullException (nameof(value));

        }
    }
}
