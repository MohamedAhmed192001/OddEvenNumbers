
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
        // function to print numbers from 1 to 9
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
        // function to get even numbers from 1 to 9
        static bool isEven(int number) => number % 2 == 0;
        // function to get odd numbers from 1 to 9
        static bool isOdd(int number) => !isEven(number);
    }
}






