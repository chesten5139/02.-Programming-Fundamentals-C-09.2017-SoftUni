using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class HandsOfCards
    {
        static void Main()
        {
            var people = new Dictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while (input != "JOKER")
            {
                var commandArgs = input.Split(':');
                var name = commandArgs[0];
                var cards = commandArgs[1]
                    .Trim()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (!people.ContainsKey(name))
                {
                    people.Add(name, new Dictionary<string, int>());
                    AddCardsToPerson(people[name], cards);
                }
                else
                {
                    AddCardsToPerson(people[name], cards);
                }

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key}: {person.Value.Values.Sum()}");
            }
        }

        private static void AddCardsToPerson(Dictionary<string, int> person, string[] cards)
        {
            foreach (var card in cards)
            {
                if (!person.ContainsKey(card))
                {
                    person.Add(card, GetCardValue(card));
                }
            }
        }

        private static int GetCardValue(string card)
        {
            int power = 0;

            switch (card[0])
            {
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    power += (int)card[0] - 48;
                    break;
                case '1':
                    power += 10;
                    break;
                case 'J':
                    power += 11;
                    break;
                case 'Q':
                    power += 12;
                    break;
                case 'K':
                    power += 13;
                    break;
                case 'A':
                    power += 14;
                    break;
            }
            switch (card[card.Length - 1])
            {
                case 'S':
                    power *= 4;
                    break;
                case 'H':
                    power *= 3;
                    break;
                case 'D':
                    power *= 2;
                    break;
                case 'C':
                    power *= 1;
                    break;
            }
            return power;
        }
    }
}
