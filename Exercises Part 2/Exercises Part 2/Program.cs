using System;

namespace Exercises_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n--Random digit numbers--\n");

            Console.Write("Enter a number: ");
            int arraylength = Int32.Parse(Console.ReadLine());
            int[]intArray = new int[arraylength];

            for (int i = 0; i <= arraylength; i++)
            {
                Random rnd = new Random();
                int onerandom = rnd.Next(1000, 9999);
                Console.Write("{0} ",onerandom);               
            }
            Console.WriteLine("\n");
            Console.ReadLine();


            Console.WriteLine("\n--Random sum of digit numbers--\n");

            int[] arraylength2 = new int[100];
            int sum = 0;
            Random rnd2 = new Random();
            for (int i = 0; i <= arraylength2.Length; i++)
            {
                arraylength2[i] = rnd2.Next(0, 100);
                Console.Write("{0} ", arraylength2[i]);
                sum += arraylength2[i];
                Console.WriteLine(sum);
            }

            Console.ReadLine();
        }
    }
}
