using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    internal class Restaurant
    {
        //readonly because don't want to change anything that's been set
        private readonly IChef _chef;

        //default constructor but don't want to use this constructor because it doesn't have any parameters
        public Restaurant()
        {

        }

        //overloaded constructor overrides
        public Restaurant(IChef chef)
        {
            _chef = chef;
        }

        public void TakeOrder(string food)
        {
            _chef.PrepareFood(food);
            _chef.ServeFood(food);
        }
    }
}
