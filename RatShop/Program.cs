using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatShop
{
    class Program
    {
        // rat stuff
        static string[] ratTypes = { "dumbo", "rex", "hairless", "sewer" };
        static int ChoosenRatIndex;
        static int[] ratPrices = { 300, 200, 100, 0 };
        static int storeRatprice;

        //cage stuff
        static string[] cageTypes = { "small", "medium", "large" };
        static int[] cagePrices = { 400, 500, 600 };
        static int chooseCageIndex;
        static int storeCageprice;

        static int total;

        static void Main(string[] args)
        {
            Console.WriteLine("Please input the type of rat you want to purchase. Dumbo, Rex, Hairless or Sewer :)");

            //Choose a rat
            chooseRat();

            Console.WriteLine("Would you like to buy a cage to put your rat in?");

            //Choose a cage

            chooseCage();

            totalPrice(storeCageprice, storeRatprice);

        }

        static void chooseRat()
        {

            for (int i = 0; i < ratTypes.Length; i++)
            {
                Console.WriteLine(i + ". " + ratTypes[i]);
            }

            ChoosenRatIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("That rat costs: " + RatPrice(ChoosenRatIndex, ratPrices) + " Dollars" + ": " + "Please press return" );
            storeRatprice = RatPrice(ChoosenRatIndex, ratPrices);

            Console.ReadLine();
        }

        static int RatPrice(int ratType, int[] ratPriceArr)
        {
            var PriceSum = ratPriceArr[ratType];
            int storeRatprice = PriceSum;
            return PriceSum;
        }

        static void chooseCage()
        {
            for(int i = 0; i < cageTypes.Length; i++)
            {
                Console.WriteLine(i + ", " + cageTypes[i]);
            }

            chooseCageIndex = int.Parse(Console.ReadLine());
            storeCageprice = cagePrice(chooseCageIndex, cagePrices);
            Console.WriteLine("That cage costs: " + cagePrice(chooseCageIndex, cagePrices) + " Dollars");
        }
        static int cagePrice(int cageType, int [] cagePriceArr)
        {
            var TheSum = cagePriceArr[cageType];
            int storeCageprice = TheSum;
            return TheSum;

        }

        static int totalPrice(int storeCageprice, int storeRatprice)
        {
            total = storeCageprice + storeRatprice;
            Console.WriteLine("The Total is: " + (total) + " Dollars");
            return total;
        }
    }
}


        /*static void chooseRat()
        {
            input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "dumbo":
                    Console.WriteLine("You chose the Dumbo");
                    CageOptions();
                    totalCost();
                    break;

                case "rex":
                    Console.WriteLine("You picked the Rex");
                    
                    break;

                case "hairless":
                    Console.WriteLine("You really want that bold thing?!");                    
                    break;

                case "sewer":
                    Console.WriteLine("Eww really!");                    
                    break;

                default:
                    Console.WriteLine("I dont understand, please enter a type of rat");
                    break;
            }
        }

        static void CageOptions()
        {
            Console.WriteLine("Which cage would you like?:");

            string[] cageOptions = {"small", "medium", "large"};


            Console.WriteLine("1:" + cageOptions[0]);
            Console.WriteLine("2:" + cageOptions[1]);
            Console.WriteLine("3:" + cageOptions[2]);

            Console.WriteLine("Please enter a number between 1-3: ");

            string userInput = Console.ReadLine();
            Console.WriteLine("You have selected cage:" + userInput);

        }

        static void totalCost()
        {
            int[] ratPrices = { 300, 200, 100, 0 };
            int[] cagePrices = { 100, 200, 300 };

            if (input == "dumbo")
            {
                Console.WriteLine(ratPrices[0]);
                Console.WriteLine(cagePrices[0]);
            }

        }
    }
}
*/