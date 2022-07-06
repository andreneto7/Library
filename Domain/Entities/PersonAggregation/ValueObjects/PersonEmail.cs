using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.PersonAggregation.ValueObjects
{
    public class PersonEmail
    {
        public string Email { get; private set; }

        public PersonEmail(string email)
        {
            if (email.IndexOf("@") == -1) throw new InvalidOperationException("Email invalido");
            Email = email;
        }
    }
}
