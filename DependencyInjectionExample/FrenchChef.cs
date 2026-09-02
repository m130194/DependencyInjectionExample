using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    internal class FrenchChef: IChef
    {
        public string Name { get; set; }
        public void PrepareFood(string food)
        {
            Console.WriteLine("Prepare French food");
        }
        public void ServeFood(string food)
        {
            Console.WriteLine("Serve French food");
        }
    }
}
