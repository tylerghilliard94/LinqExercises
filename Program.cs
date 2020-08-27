using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>()
            {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};
            IEnumerable<string> LFruits = from fruit in fruits
                                          where fruit.StartsWith("L")
                                          select fruit;

            foreach (string fruit in LFruits)
            {
                Console.WriteLine($"Fruit starting with L {fruit}");
            }

            List<int> numbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

            IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 && n % 6 == 0);
            Console.WriteLine(" ");
            foreach (int number in fourSixMultiples)
            {
                Console.WriteLine($"Multiples of 4 and 6 {number}");
            }

            List<string> names = new List<string>()
{
    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"
};
            Console.WriteLine(" ");
            IEnumerable<string> descend = names.OrderByDescending(n => n);
            Console.WriteLine($"Names in Descending Order");
            foreach (string name in descend)
            {

                Console.WriteLine($"{name}");
            }
            Console.WriteLine(" ");
            List<int> numbers2 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> numSort = numbers2.OrderBy(n => n);
            Console.WriteLine($"Numbers in ascending order");
            foreach (int num in numSort)
            {

                Console.WriteLine($"{num}");
            }

            Console.WriteLine(" ");
            List<int> numbers3 = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};
            Console.WriteLine("");
            Console.WriteLine($"Count of numbers in the array = {numbers3.Count}");

            List<double> purchases = new List<double>()
{
    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
};

            Console.WriteLine("");
            Console.WriteLine($"Sum of money = {purchases.Sum()}");

            List<double> prices = new List<double>()
{
    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
};

            Console.WriteLine("");
            Console.WriteLine($"Most expensive Item = {prices.Max()}");

            List<int> wheresSquaredo = new List<int>()
{
    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
};

            IEnumerable<int> rejects = wheresSquaredo.TakeWhile(n => Math.Sqrt(n) % 1 != 0);
            Console.WriteLine("");
            Console.WriteLine("Numbers before Squaredo: ");
            foreach (int num in rejects)
            {

                Console.WriteLine($"{num}");
            }


        }

    }
}
