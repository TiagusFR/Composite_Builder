using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Builder
{
    public class PersonAdressBuilder : PersonBuilder
    {
        public PersonAdressBuilder(Person person) : base(person) 
        {
            this.person = person;
        }

        public PersonAdressBuilder At(string streetAdress)
        {
            person.StreetAdress = streetAdress;
            return this;
        }

        public PersonAdressBuilder WithPostCode(string postCode)
        {
            person.Postcode = postCode;
            return this;
        }

        public PersonAdressBuilder In (string city)
        {
            person.City = city; 
            return this;
        }
    }
}
