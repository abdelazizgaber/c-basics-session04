
using System;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q01

            double[] pricesQ01 = { 25.5, 40.0, 33.75 };
            Console.WriteLine(pricesQ01[1]);

            // Q02

            int[,] shelfCopies = {
                { 3, 5 },
                { 1, 4 }
            };
            Console.WriteLine(shelfCopies[1, 0]);

            // Q03

            PrintWelcomeMessage();

            // Q04

            PrintBookTitle("Clean Code");

            // Q05

            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);

            // Q06

            double[] discountPrices = { 25.5, 40.0 };
            ApplyDiscount(discountPrices);
            Console.WriteLine(discountPrices[0]);

            // Q07

            int pagesByRef = 400;
            AddBonusPagesByRef(ref pagesByRef);
            Console.WriteLine(pagesByRef);

            // Q08

            double[] replacementPrices = { 25.5, 40.0 };
            ReplaceArray(ref replacementPrices);
            Console.WriteLine(replacementPrices.Length);

            // Q09

            double bookPrice;
            bool isFound = TryGetPrice("Clean Code", out bookPrice);
            if (isFound)
                Console.WriteLine(bookPrice);
            else
                Console.WriteLine("Book not found.");

            // Q10

            PrintBookInfo("Clean Code");
            PrintBookInfo("C# in Depth", 450);

            // Q11

            PrintBookInfo(pages: 500, title: "Effective C#");

            // Q12


            PrintAllTitles("Clean Code", "C# in Depth", "The Pragmatic Programmer");
        }

        // Q03

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        // Q04


        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        // Q05

        static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        // Q06

        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        // Q07

        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

        // Q08

        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

        // Q09

        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }


        // Q10 

        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Pages: " + pages);
        }

        // Q12

        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
