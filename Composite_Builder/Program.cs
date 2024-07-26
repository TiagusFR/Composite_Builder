using System;

namespace Composite_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb
                .Lives
                .At("123 Cotia Road")
                .In("São Paulo")
                .WithPostCode("123456789")
                .Works
                .At("Employless")
                .As("Nothing")
                .Earns(0);

            Console.WriteLine(person);
        }
    }
}