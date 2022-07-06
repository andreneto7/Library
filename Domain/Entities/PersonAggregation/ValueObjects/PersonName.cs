using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.PersonAggregation.ValueObjects
{
    public class PersonName
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public PersonName(string name, string lastName)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrEmpty(lastName)) throw new ArgumentNullException(nameof(lastName));

            Name = name;
            LastName = lastName;
        }
    }
}
