using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Builder
{
    public class PersonBuilder
    {
        protected Person person;

        public PersonBuilder() => person = new Person();
        protected PersonBuilder(Person person) => this.person = person;


        public PersonAdressBuilder Lives => new PersonAdressBuilder(person);
        public PersonJobBuilder Works => new PersonJobBuilder(person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }
    }
}
