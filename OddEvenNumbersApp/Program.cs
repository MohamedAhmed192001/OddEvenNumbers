
namespace OddEvenNumbers
{
    class prgram
    {

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            printNumbers("Numbers : ", numbers);
            printNumbers("Even No : ", numbers.Where(x => isEven(x)));
            printNumbers("Odd No : ", numbers.Where(x => isOdd(x)));

            Console.ReadKey();
        }

        static void printNumbers(string title, IEnumerable<int> numbers)
        {
            Console.WriteLine();
            Console.Write($"{title} [ ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");

            }
            Console.Write("]");
            Console.WriteLine();
        }
        static bool isEven(int number) => number % 2 == 0;
        static bool isOdd(int number) => !isEven(number);
    }
}






