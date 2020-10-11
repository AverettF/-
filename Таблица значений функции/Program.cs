using System;

namespace Таблица_значений_функции
{
    class Program
    {
        static double GetFunctionY(double x)
        {
            return Math.Round(x * x - 4 * x - 2, 2);
        }

        static int FindMaxLength(double step, double forRange, double toRange,string title)
        {
            int maxLength = 0;
            for (double x = forRange; x <= toRange; x += step)
            {
                x = Math.Round(x, 2);
                int intX = Convert.ToString(x).Length;
                if (intX > maxLength)
                    maxLength = intX;

                int intFuncL = Convert.ToString(GetFunctionY(x)).Length;
                if (intFuncL > maxLength)
                    maxLength = intFuncL;
            }

            if (title.Length > maxLength)
                maxLength = title.Length;

            return maxLength;
        }

        static double OutInt()
        {
            while (true)
            {
                try
                {
                    return Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Я вас не понял");
                }
            }
        }

        static void PrintBox(int maxLength, double step, double forRange, double toRange,string title)
        {
            Console.WriteLine(maxLength);
            PrintLine(maxLength, "╔", "═", "╗");                //╔═══════╗
            PrintTitle(title,maxLength) ;                       //║ Оглав ║
            PrintLine(maxLength, "╠", "╦", "╣");                //╠═══╦═══╣
            PrintXandYline(maxLength);                          //║ X ║ Y ║
            PrintLine(maxLength, "╠", "╬", "╣");                //╠═══╬═══╣
            PrintNumberLine(step, forRange, toRange, maxLength);//║...║...║
            PrintLine(maxLength, "╚", "╩", "╝");                //╚═══╩═══╝
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

        static void PrintTitle(string title,int length)
        {
            Console.Write("║");
            for (int i = 1; i <= (length + length + 1 - title.Length) / 2; i++) 
                Console.Write(" ");
            Console.Write(title);
            for (int i = 1; i <= (length + length + 1 - title.Length) / 2; i++) 
                Console.Write(" ");
            if ((length - title.Length) % 2 == 1)
                Console.Write(" ");
            Console.WriteLine("║");
        }

        static void PrintNumberLine(double step, double forRange, double toRange, int length)//║...║...║
        {
            for (double x = forRange; x <= toRange; x += step)
            {
                x = Math.Round(x, 2);
                string strX = Convert.ToString(x);
                string strY = Convert.ToString(GetFunctionY(x));

                int lengthNumberX =strX.Length;
                int lengthNumberY = strY.Length;

                Console.Write("║");
                PrintNumber(strX,length, lengthNumberX);
                Console.Write("║");
                PrintNumber(strY,length, lengthNumberY);
                Console.WriteLine("║");
            }
        }

        static void PrintXandYline( int length)//║ X ║ Y ║
        {
            Console.Write("║");
            PrintNumber("X",length,1);
            Console.Write("║");
            PrintNumber("Y",length,1);
            Console.WriteLine("║");
        }

        static void PrintNumber(string xy, int length, int numberLength)
        {
            for (int i = 1; i <= (length - numberLength) / 2; i++)
                Console.Write(" ");
            Console.Write(xy);
            for (int i = 1; i <= (length - numberLength) / 2; i++)
                Console.Write(" ");
            if ((length - numberLength) % 2 == 1)
                Console.Write(" ");
        }
        
        static void Main(string[] args)
        {
            string title = "x*x-4*x-2";

            Console.WriteLine("Введите шаг посторения:");
            double step = OutInt();                                    //TODO:Сделать проверку 

            Console.WriteLine("Введите диапозон значений.");

            Console.Write("От:");
            double forRange = OutInt();

            Console.Write("До:");
            double toRange = OutInt();


            int maxLength = FindMaxLength(step, forRange, toRange,title);
            PrintBox(maxLength, step, forRange, toRange,title);
        }
    }
}
