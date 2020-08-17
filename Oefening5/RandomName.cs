using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening5
{
    class RandomName
    {
        private List<string> randomNames { get; }
        public RandomName()
        {
            randomNames = new List<string>()
        {
            "Jens",
            "Niels",
            "Nils",
            "Karel",
            "Merel",
            "Anna",
            "Bert",
            "David",
            "Emma",
            "Luk",
            "Els",
            "Kenneth",
            "Fred",
            "Henk",
            "Gerda",
            "Ilse",
            "Joke",
            "Kevin",
            "Pol",
            "Jan",
            "Zorro",
            "Juno",
            "Jannes",
            "Joren",
            "Stijn",
        };

        }
        public string GetRandomName()
        {
            Random rand = new Random();
            int index = rand.Next(0, randomNames.Count);

            string name = randomNames[index];
            randomNames.RemoveAt(index);
            return name;
        }
    }
}
