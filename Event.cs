using static Hey.Opt;

namespace Hey
{
    class Programm : Opt 
    {
        static void Main()
        {
            Event eve = new Event();
            Console.WriteLine("Введите три числа:");
            Console.Write("a: "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: "); double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            eve.SomeEvent += Opt.Sum;
            eve.SomeEvent += Opt.Dif;
            eve.SomeEvent += Opt.Mult;
            eve.SomeEvent += Opt.Div;

            eve.OnSomeEvent(a,b);
        }
    }
    interface Opt
    {
        delegate void Opti(double x, double y);
        static void Sum(double x, double y)
        {
            Console.WriteLine($"Сумма: {x + y}");
        }
        static void Dif(double x, double y)
        {
            Console.WriteLine($"Разность: {x - y}");
        }
        static void Mult(double x, double y)
        {
            Console.WriteLine($"Произведение: {x * y}");
        }
        static void Div(double x, double y)
        {
            if(y != 0)
            {
                Console.WriteLine($"Деление: {x / y}");
            }
            else {Console.WriteLine("На ноль не делим"); }
        }

    }

     class Event
     {
        Opti[] evnt = new Opti[4];

        public event Opti SomeEvent
        {
            add
            {
                int i;
                for(i = 0; i < 4; i++)
                {
                    if (evnt[i] == null)
                    {
                        evnt[i] = value;
                        break;
                    }
                }
                if (i == 4) Console.WriteLine("Список событий заполнен.");
            }
            remove
            {
                int i;
                for (i = 0; i < 4; i++)
                {
                    if (evnt[i] == value)
                    {
                        evnt[i] = null;
                        break;
                    }
                }
                if (i == 4) Console.WriteLine("Обработчик событий не найден.");
            }
        }
        public void OnSomeEvent(double x, double y)
        {
            for (int i = 0; i < 4; i++)
                if (evnt[i] != null) evnt[i](x,y);
        }

     }
}
