using System;

namespace Таблица_значений_функции
{
    class Program
    {
        static int Function(int x)
        {
            return 10*x;//x * x - 4 * x - 2;
        }

        static int FindMaxLength(int step, int forRange, int toRange)
        {
            int maxLength = 0;
            for (int i = forRange; i <= toRange; i += step)
            {
                int intFuncL = Convert.ToString(Function(i)).Length;
                if (intFuncL > maxLength)
                    maxLength = intFuncL;
            }
            return maxLength;
        }

        static int OutInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void PrintBox(int maxLength)
        {
            Console.WriteLine(maxLength);                                                                       //Console.WriteLine("╔═════╗");
                                                                                    //Console.WriteLine("║     ║");
            PrintLine(maxLength, "╠", "╦", "╣");//Console.WriteLine("╠══╦══╣");
            PrintForYandX(maxLength);           //Console.WriteLine("║  ║  ║");
            PrintLine(maxLength, "╠", "╬", "╣");//Console.WriteLine("╠══╬══╣");
            PrintBigPlan(                                    //Console.WriteLine("║  ║  ║");
            PrintLine(maxLength, "╚", "╩", "╝");//Console.WriteLine("╚══╩══╝");
        }

        static void PrintLine(int maxLength, string lineLeft, string lineMiddle,  string lineRight)
        {
            Console.Write(lineLeft);
            for (int i = 0; i != maxLength; i++)
                Console.Write("═");
            Console.Write(lineMiddle);
            for (int i = 0; i != maxLength; i++)
                Console.Write("═");
            Console.WriteLine(lineRight);
        }

        static void PrintForYandX(int maxLength)
        {
            Console.Write("║");
            for (int i = 0; i <= (maxLength / 2 - 1); i++)
                Console.Write(" ");
            Console.Write("Y");
            for (int i = 0; i <= (maxLength / 2 - 1); i++)
                Console.Write(" ");
            Console.Write("║");
            for (int i = 0; i <= (maxLength / 2 - 1); i++)
                Console.Write(" ");
            Console.Write("X");
            for (int i = 0; i <= (maxLength / 2 - 1); i++)
                Console.Write(" ");
            Console.WriteLine("║");
        }     

        static void Main(string[] args)
        {

            Console.WriteLine("Введите шаг посторения:");
            int step = OutInt();                                    //TODO:Сделать проверку 

            Console.WriteLine("Введите диапозон значений.");

            Console.WriteLine("От:");
            int forRange = OutInt();

            Console.WriteLine("До:");
            int toRange = OutInt();


            int maxLength = FindMaxLength(step, forRange, toRange);
            PrintBox(maxLength);

        }
    }
}
