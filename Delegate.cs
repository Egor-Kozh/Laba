using System;

namespace hey
{
    class Programm : IMath
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = Convert.ToInt32(Console.ReadLine());
            IMath.Hello oper;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1)Сумма\n2)Умножение\n3)Разность\n4)Деление\n5)Выход");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1) { oper = IMath.Sum; double res = oper(a, b); Console.WriteLine("\n" + res); Console.ReadKey(); };
                if (key.Key == ConsoleKey.D2) { oper = IMath.Mul; double res = oper(a, b); Console.WriteLine("\n" + res); Console.ReadKey(); };
                if (key.Key == ConsoleKey.D3) { oper = IMath.Dif; double res = oper(a, b); Console.WriteLine("\n" + res); Console.ReadKey(); };
                if (key.Key == ConsoleKey.D4) { if (b == 0) { Console.WriteLine("\nНа ноль делить нельзя!"); Console.ReadKey(); } else { oper = IMath.Div; double res = oper(a, b); Console.WriteLine("\n" + res); Console.ReadKey(); } };
                if (key.Key == ConsoleKey.D5) { break; };
            }
        }

    }
    interface IMath
    {
        static double Sum(double x, double y)
        {
            return x + y;
        }
        static double Mul(double x, double y)
        {
            return x * y;
        }
        static double Dif(double x, double y)
        {
            return x - y;
        }
        static double Div(double x, double y)
        {
            return x / y;
        }

        delegate double Hello(double x, double y);
    }
}
