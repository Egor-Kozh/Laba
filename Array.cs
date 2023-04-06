namespace Hey
{
    class Programm
    {
        static void Main()
        {
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < n;i++)
            {
                array.SetValue(Convert.ToInt32(Console.ReadLine()), i);
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==Array==\n\n1)Длина\n2)Ранг массива\n3)Отсортировать массив\n4)Бинарный поиск\n5)Очистка\n6)Копировать\n" +
                    "7)Изменить размер массива\n8)Поменять порядок\n9)Поиск заданного объекта\n10)Значение по указанной позиции");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1) { D1(array); }
                if (key.Key == ConsoleKey.D2) { D2(array); }
                if (key.Key == ConsoleKey.D3) { D3(array); }
                if (key.Key == ConsoleKey.D4) { D4(array); }
                if (key.Key == ConsoleKey.D5) { D5(array); }
                if (key.Key == ConsoleKey.D6) { D6(array); }
                if (key.Key == ConsoleKey.D7) { D7(array); }
                if (key.Key == ConsoleKey.D8) { D8(array); }
                if (key.Key == ConsoleKey.D9) { D9(array); }
                if (key.Key == ConsoleKey.D0) { D10(array); }
                if (key.Key == ConsoleKey.Escape) { break; }
            }
        }
        static void myarr(int[] array)
        {
            Console.Write("[ ");
            for(int i = 0; i < array.Length;i++)
            {
                Console.Write(array.GetValue(i) + " ");
            }
            Console.WriteLine("]\n");
        }
        static void D1(int[] array)
        {
            Console.Clear();
            Console.WriteLine("==Длина==");
            Console.Write("Ваш массив "); myarr(array);
            Console.WriteLine($"Длина массива {array.Length}");
            Console.ReadKey();
        }

        static void D2(int[] array)
        {
            Console.Clear();
            Console.WriteLine("==Ранг массива==");
            Console.Write("Ваш массив "); myarr(array);
            Console.Write($"Ранг массива {array.Rank}");
            Console.ReadKey();
        }
        static void D3(int[] array)
        {
            Console.Clear();
            Console.WriteLine("==Отсортировать массив==");
            Console.Write("Ваш массив "); myarr(array);
            Array.Sort(array);
            Console.Write($"Отсортированный массив "); myarr(array);
            Console.ReadKey();
        }
        static void D4(int[] array)
        {
            Console.Clear();
            Console.WriteLine("==Бинарный поиск==");
            Console.Write("Ваш массив "); myarr(array);
            Console.Write($"Укажите элемент поиска: "); int val = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Индекс элемента {val}: "); 
            Console.WriteLine(Array.BinarySearch(array,val));
            Console.ReadKey();
        }
        static void D5(int[] array)
        {
            Console.Clear();
            Console.WriteLine("==Очистка==");
            Console.Write("Ваш массив "); myarr(array);
            Array.Clear(array);
            Console.Write($"Очищенный массив: "); myarr(array);
            Console.ReadKey();
        }
        static void D6(int[] array)
        {
            Console.Clear();
            Console.WriteLine("==Копировать==");
            Console.Write("Ваш массив "); myarr(array);
            int[] arrayCopy = new int[array.Length];
            Array.Copy(array, arrayCopy, array.Length);
            Console.WriteLine("Скопированный массив: "); myarr(arrayCopy);
            Console.ReadKey();
        }
        static void D7(int[] array)
        {
            Console.Clear();
            Console.WriteLine("==Изменить размер массива==");
            Console.Write("Ваш массив "); myarr(array);
            Console.Write("Укажите новый размер массива: ");
            int n = 0;
            n = Convert.ToInt32(Console.ReadLine());
            Array.Resize<int>(ref array, n);      
            Console.Write("Массив нового размера "); myarr(array);
            Console.ReadKey();
        }
        static void D8(int[] array)
        {
            Console.Clear();
            Console.WriteLine("==Поменять порядок==");
            Console.Write("Ваш массив "); myarr(array);
            Array.Reverse(array);
            myarr(array);
            Console.ReadKey();
        }
        static void D9(int[] array)
        {
            Console.Clear();
            Console.WriteLine("==Поиск заданного объекта==");
            Console.Write("Ваш массив "); myarr(array);
            Console.Write($"Укажите элемент поиска: "); int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Array.IndexOf(array, val));
            Console.ReadKey();
        }
        static void D10(int[] array)
        {
            Console.Clear();
            Console.WriteLine("==Значение по указанной позиции==");
            Console.Write("Ваш массив "); myarr(array);
            Console.Write($"Укажите элемент поиска: "); int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(array.GetValue(val));
            Console.ReadKey();
        }
    }
}
