namespace Hey
{
    class Programm : Opt
    {
        static void Main()
        {
            Opt.Opti oper;
            Console.WriteLine("Введите три числа:");
            Console.Write("a: "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: "); double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: "); double c = Convert.ToDouble(Console.ReadLine());
            double[] arr = { a, b, c };
            Console.WriteLine();
            Console.Write("Максимальное: "); oper = Opt.Maxi; double res1 = oper(arr); Console.WriteLine(res1);
            Console.Write("Минимальное: "); oper = Opt.Mini; double res2 = oper(arr); Console.WriteLine(res2);
            Console.Write("Сумма: "); oper = Opt.Sumi; double res3 = oper(arr); Console.WriteLine(res3);
            Console.Write("Произведение: "); oper = Opt.Mult; double res4 = oper(arr); Console.WriteLine(res4);
            Console.Write("Среднее арифметическое: "); oper = Opt.Midl; double res5 = oper(arr); Console.WriteLine(res5);
        }
    }
    interface Opt
    {
        delegate double Opti(double[] arr);
        static double Maxi(double[] arr) => arr.Max();
        static double Mini(double[] arr) => arr.Min();
        static double Sumi(double[] arr) => arr.Sum();
        static double Mult(double[] arr) => arr[0] * arr[1] * arr[2];
        static double Midl(double[] arr) => arr.Sum()/3;
    }
}
