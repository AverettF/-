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

        static void PrintBox(int maxLength,int step, int forRange, int toRange, int length)
        {
            Console.WriteLine(maxLength);
            PrintLine(maxLength, "╔", "═", "╗");//╔═══════╗
                                                //║       ║
            PrintLine(maxLength, "╠", "╦", "╣");//╠═══╦═══╣
                                                //║ X ║ Y ║
            PrintLine(maxLength, "╠", "╬", "╣");//╠═══╬═══╣
                                                //║...║...║
            PrintLine(maxLength, "╚", "╩", "╝");//╚═══╩═══╝
        }

        static void PrintLine(int maxLength, string lineLeft, string lineMiddle,  string lineRight)
        {
            Console.Write(lineLeft);
            for (int i = 0; i <= maxLength; i++)
                Console.Write("═");
            Console.Write(lineMiddle);
            for (int i = 0; i <= maxLength; i++)
                Console.Write("═");
            Console.WriteLine(lineRight);
        }

        static void PrintNumberLine(int step, int forRange, int toRange, int length)
        {
            for (int x = forRange; x <= toRange; x += length)
            {
                int lengthX = Convert.ToString(x).Length;
                int y = Function(x);
                int lengthY = Convert.ToString(y).Length;


            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите шаг посторения:");
            int step = OutInt();                                    //TODO:Сделать проверку 

            Console.WriteLine("Введите диапозон значений.");

            Console.Write("От:");
            int forRange = OutInt();

            Console.Write("До:");
            int toRange = OutInt();


            int maxLength = FindMaxLength(step, forRange, toRange);
            PrintBox(maxLength, step, forRange, toRange, maxLength);

        }
    }
}
