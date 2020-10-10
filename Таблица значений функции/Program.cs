using System;

namespace Таблица_значений_функции
{
    class Program
    {
        static int GetFunctionY(int x)
        {
            return 10*x;//x * x - 4 * x - 2;
        }

        static int FindMaxLength(int step, int forRange, int toRange)
        {
            int maxLength = 0;
            for (int i = forRange; i <= toRange; i += step)
            {
                int intFuncL = Convert.ToString(GetFunctionY(i)).Length;
                if (intFuncL > maxLength)
                    maxLength = intFuncL;
            }
            return maxLength;
        }

        static int OutInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void PrintBox(int maxLength,int step, int forRange, int toRange)
        {
            Console.WriteLine(maxLength);
            PrintLine(maxLength, "╔", "═", "╗");//╔═══════╗
                                                //║ Оглав ║
            PrintLine(maxLength, "╠", "╦", "╣");//╠═══╦═══╣
            PrintXandYline(maxLength);          //║ X ║ Y ║
            PrintLine(maxLength, "╠", "╬", "╣");//╠═══╬═══╣
            PrintNumberLine(step, forRange, toRange, maxLength);              //║...║...║
            PrintLine(maxLength, "╚", "╩", "╝");//╚═══╩═══╝
        }

        static void PrintLine(int maxLength, string lineLeft, string lineMiddle,  string lineRight)
        {
            Console.Write(lineLeft);
            for (int i = 1; i <= maxLength; i++)
                Console.Write("═");
            Console.Write(lineMiddle);
            for (int i = 1; i <= maxLength; i++)
                Console.Write("═");
            Console.WriteLine(lineRight);
        }

        static void PrintNumberLine(int step, int forRange, int toRange, int length)
        {
            for (int x = forRange; x <= toRange; x += step)
            {
                int numberLengthX = Convert.ToString(x).Length;
                int numberLengthY = Convert.ToString(GetFunctionY(x)).Length;

                Console.Write("║");
                for (int i = 1; i <= (length - numberLengthX) / 2; i++)
                    Console.Write(" ");
                Console.Write(x);
                for (int i = 1; i <= (length - numberLengthX) / 2; i++)
                    Console.Write(" ");
                if ((length - numberLengthX) % 2 == 1)
                    Console.Write(" ");
                                Console.Write("║");

                for (int i = 1; i <= (length - numberLengthY) / 2; i++)
                    Console.Write(" ");
                Console.Write(GetFunctionY(x));
                for (int i = 1; i <= (length - numberLengthY) / 2; i++)
                    Console.Write(" ");
                if ((length - numberLengthY) % 2 == 1)
                    Console.Write(" ");
                Console.WriteLine("║");
            }
        }

        static void PrintXandYline( int length)
        {
            Console.Write("║");
            for (int i = 1; i <= (length - 1) / 2; i++)
                Console.Write(" ");
            Console.Write("x");
            for (int i = 1; i <= (length - 1) / 2; i++)
                Console.Write(" ");
            Console.Write("║");
            if ((length - 1) % 2 == 1)
                Console.Write(" ");

            for (int i = 1; i <= (length - 1) / 2; i++)
                Console.Write(" ");
            Console.Write("y");
            for (int i = 1; i <= (length - 1) / 2; i++)
                Console.Write(" ");
            if ((length - 1) % 2 == 1)
                Console.Write(" ");
            Console.WriteLine("║");
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
            PrintBox(maxLength, step, forRange, toRange);

        }
    }
}
