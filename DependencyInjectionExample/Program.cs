using System.Security.Cryptography.X509Certificates;

namespace DependencyInjectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FrenchChef> list = new List<FrenchChef>
            {
                new FrenchChef { Name = "Chef Pierre" },
                new FrenchChef { Name = "Chef Marie" }
            };

            //this doesn't work because ItalianChef is not a FrenchChef
            //list.Add(new ItalianChef { Name = "Chef Luigi" });

            //using the interface IChef allows us to add both FrenchChef and ItalianChef to the same list
            List<IChef> chefList = new List<IChef>();

            chefList.Add(new FrenchChef { Name = "Chef Pierre" });
            chefList.Add(new ItalianChef { Name = "Chef Luigi" });

            Restaurant italianRestaurant = new Restaurant(new ItalianChef());

            //use Restaurant methods and creates type of restaurant based on object used
            italianRestaurant.TakeOrder("Pasta");


        }
    }
}
