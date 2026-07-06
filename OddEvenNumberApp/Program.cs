using System;

namespace OddEvenNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };



            PrintNumbers("Numbers",numbers  );
            PrintNumbers("EvenNumvers",numbers.Where(x=> IsEven(x))  );
            PrintNumbers("OddNumvers",numbers.Where(x=> IsOdd(x))  );
            Console.ReadKey();

        }

        private static void PrintNumbers(string title, IEnumerable<int> ints)
        {
            Console.WriteLine();
            Console.Write($"{title} [ ");
            foreach (var item in ints)
            {
                Console.Write($" {item}");
            }
            Console.Write($" ]");
            Console.WriteLine();
        }

        static bool IsEven(int number) => number % 2 == 0;
      
        static bool IsOdd(int number) => number % 2 != 0;
        
    }
}