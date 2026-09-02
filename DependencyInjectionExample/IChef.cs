using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    internal interface IChef
    {
        void PrepareFood(string food);

        void ServeFood(string food);

    }
}
