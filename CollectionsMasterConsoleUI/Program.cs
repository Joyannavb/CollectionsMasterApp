using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
          
            #region Arrays
            
            int[] Numbers = new int[50];
            Populater(Numbers);

            Console.WriteLine(Numbers[0]);
            Console.WriteLine(Numbers[49]);

            Console.WriteLine("All Numbers Original");
                NumberPrinter(Numbers);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers Reversed:");
            Console.WriteLine("---------REVERSE CUSTOM------------");
                ReverseArray(Numbers);
            Console.WriteLine("-------------------");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
            Console.WriteLine("Multiple of three = 0: ");
                ThreeKiller(Numbers);
            Console.WriteLine("-------------------");

            Console.WriteLine("Sorted numbers:");
                Array.Sort(Numbers);
                NumberPrinter(Numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");
                var numberList = new List<int>();
                Console.WriteLine($"List capacity: {numberList.Capacity}");   
                Populater(numberList);
                Console.WriteLine($"New list capacity: {numberList.Capacity}");
            Console.WriteLine("---------------------");

            Console.WriteLine("What number will you search for in the number list?");
                int searchNumber;
                bool isNumber;

                do
                {
                isNumber = int.TryParse(Console.ReadLine(), out searchNumber);
                } while (isNumber == false);

                NumberChecker(numberList, searchNumber);
            Console.WriteLine("-------------------");
           
            Console.WriteLine("All Numbers:");
                NumberPrinter(numberList);
            Console.WriteLine("-------------------");

            Console.WriteLine("Evens Only!!");
                OddKiller(numberList);
            Console.WriteLine("------------------");

            Console.WriteLine("Sorted Evens!!");
                numberList.Sort();
                NumberPrinter(numberList);
            Console.WriteLine("------------------");

                int[] convertNumbers = numberList.ToArray();
                var randomNumbers = convertNumbers;
                numberList.Clear();


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%3 == 0)
                {
                    numbers[i] = 0;
                }
                NumberPrinter(numbers);
            }
            
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count -1; i>-1; i--)
            {
                if (numberList[i]%2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
                { Console.WriteLine($"Nice job! you guessed one of {numberList.Count} numbers."); }
            else
                { Console.WriteLine("Better luck next time. We don't have that number."); }
        }

        private static void Populater(List<int> numberList)
        {
            for (int i = 0; i < 50; i++)
            {
                Random rng = new Random();
                int number= rng.Next(0, 50);
                numberList.Add(number);
            }
        }

        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
              Random rng = new Random();
              numbers[i] = rng.Next(0, 50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
