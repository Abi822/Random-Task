using System;

namespace The_Elements
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Helllo pick from 1-8: ");
            int pick = int.Parse(Console.ReadLine());
            if (pick == 1) { One(); }
            if (pick == 2) { Two(); }
            if (pick == 3) { Three(); }
            if (pick == 4) { Four(); }
            if (pick == 5) { Five(); }
            if (pick == 6) { Six(); }
            if (pick == 7) { Seven(); }
            if (pick == 8) { Eight(); }
            else if (pick <= 0 && pick >= 9) {Console.Write("Out of boundarys!"); Main();}
        }
        static void One()
        {           
            Console.WriteLine("Hello");
            Console.WriteLine("Hamiora Taurima\n");

            Main();
            Console.Read();        
        }
        static void Two()
        {
            int answer = (74 + 36);
            Console.Write("74+36={0}\n", answer);

            int answer2 = (50 / 3);
            Console.Write("50/3={0}\n", answer2);

            Main();
            Console.Read();
        }
        static void Three()
        {
            int answer2 = (50 / 3);
            Console.Write("50/3={0}\n", answer2);

            Main();
            Console.Read();
        }
        static void Four()
        {
            Console.Write("Input first number: ");
            int fristnum = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int secondnum = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}x{1}={2}\n", fristnum, secondnum, fristnum / secondnum);

            Main();
            Console.Read();
        }
        static void Five()
        {
            Console.Write("Input first number: ");
            int fristnum = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int secondnum = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}x{1}={2}\n", fristnum, secondnum, fristnum * secondnum);

            Main();
            Console.Read();
        }
        static void Six()
        {
            Console.WriteLine("Radius to Area and Perimeter");
            Console.Write("Input a number: ");
            double radius = double.Parse(Console.ReadLine());
            double Perimeter = 2 * Math.PI * radius;
            double Area = (Math.PI * radius * radius);
            Console.WriteLine("Perimeter:{0}\nArea:{1}\n", Perimeter, Area);

            Main();
            Console.Read();
        }
        static void Seven()
        { 
            Console.WriteLine("Swaps!");
            Console.Write("A= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B= ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nBefore swap: A={0} B={1}", a, b);
            Console.WriteLine("\n    --Now its--");
            int c = a;
            a = b;
            b = a;
            Console.Write("After swap: A={0} B={1}\n", a, c);

            Main();
            Console.Read();
        }
        static void Eight()
        {
            Console.Write("\n--100 random 4 digit numbers--\n");
            for (int i = 0; i <= 100; i++)
            {
                Random rnd = new Random();
                int onerandom = rnd.Next(1000, 9999);
                Console.Write(" {0}\n", onerandom);
            }

            Main();
            Console.Read();
        }
    }
}
