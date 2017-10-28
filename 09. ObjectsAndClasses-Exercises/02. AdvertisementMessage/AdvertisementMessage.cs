using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main()
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            var phrases = new[] { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            var events = new[] { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };

            var authors = new[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            var cities = new[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {
                int phraseIndex = random.Next(0, phrases.Length);
                int eventsIndex = random.Next(0, events.Length);
                int authorsIndex = random.Next(0, authors.Length);
                int citiesIndex = random.Next(0, cities.Length);

                Console.WriteLine("{0} {1} {2} - {3}",phrases[phraseIndex],events[eventsIndex],
                    authors[authorsIndex],cities[citiesIndex]);
            }
        }
    }
}
