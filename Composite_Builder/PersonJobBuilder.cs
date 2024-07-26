using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Builder
{
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person) : base(person) 
        {
            this.person = person;
        }

        public PersonJobBuilder At (string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder As (string position)
        {
            person.Position = position;
            return this;
        }

        public PersonJobBuilder Earns (int income)
        {
            person.AnnualIncome = income;
            return this;
        }
    }
}
