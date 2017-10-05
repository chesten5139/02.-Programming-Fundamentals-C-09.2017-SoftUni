using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main()
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            string packageType = Console.ReadLine();
            double totalPrice = 1;
            string hallType = "";
            double pricePerPerson = 0;

            if (peopleNumber <= 50)
            {
                switch (packageType)
                {
                    case "Normal":
                        totalPrice = (2500 + 500) * 0.95;
                        hallType = "Small Hall";
                        pricePerPerson = (double)totalPrice / peopleNumber;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hallType, pricePerPerson);
                        break;

                    case "Gold":
                        totalPrice = (5000 + 750) * 0.90;
                        hallType = "Terrace";
                        pricePerPerson = (double)totalPrice / peopleNumber;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hallType, pricePerPerson);
                        break;

                    case "Platinum":
                        totalPrice = (7500 + 1000) * 0.85;
                        hallType = "Great Hall";
                        pricePerPerson = (double)totalPrice / peopleNumber;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hallType, pricePerPerson);

                        break;
                }
            }
            else if (peopleNumber >50 && peopleNumber <= 100)

                switch (packageType)
                {
                    case "Normal":
                        totalPrice = (2500 + 500) * 0.95;
                        hallType = "Small Hall";
                        pricePerPerson = (double)totalPrice / peopleNumber;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hallType, pricePerPerson);

                        break;

                    case "Gold":
                        totalPrice = (5000 + 750) * 0.90;
                        hallType = "Terrace";
                        pricePerPerson = (double)totalPrice / peopleNumber;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hallType, pricePerPerson);

                        break;

                    case "Platinum":
                        totalPrice = (7500 + 1000) * 0.85;
                        hallType = "Great Hall";
                        pricePerPerson = (double)totalPrice / peopleNumber;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hallType, pricePerPerson);

                        break;
                }

            else if (peopleNumber >100 && peopleNumber <= 120)
            {
                switch (packageType)
                {
                    case "Normal":
                        totalPrice = (2500 + 500) * 0.95;
                        hallType = "Small Hall";
                        pricePerPerson = (double)totalPrice / peopleNumber;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hallType, pricePerPerson);

                        break;

                    case "Gold":
                        totalPrice = (5000 + 750) * 0.90;
                        hallType = "Terrace";
                        pricePerPerson = (double)totalPrice / peopleNumber;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hallType, pricePerPerson);

                        break;

                    case "Platinum":
                        totalPrice = (7500 + 1000) * 0.85;
                        hallType = "Great Hall";
                        pricePerPerson = (double)totalPrice / peopleNumber;
                        Console.WriteLine("We can offer you the {0}\nThe price per person is {1:f2}$", hallType, pricePerPerson);

                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }
}
