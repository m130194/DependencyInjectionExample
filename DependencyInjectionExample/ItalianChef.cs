using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    internal class ItalianChef : IChef
    {
        public string Name { get; set; }

        public void PrepareFood(string food)
        {
            Console.WriteLine("Prepare Italian food");
        }

        public void ServeFood(string food)
        {
            Console.WriteLine("Serve Italian food");
        }
    }
}
