using System;

namespace Hello
{
    class Hey
    {
        static void Main()
        {
            Massiv<string> n = new Massiv<string>();
            n.Add("a");
            n.Add("b");
            n.Add("c");

            n.Remove("d");
            n.Remove("a");


            for (int i = 0; i < n.Lenght(); i++)
            {
                Console.WriteLine(n.GetItem(i));
            }
        }
    }
    class Massiv<T>
    {
        T[] massiv;
        public Massiv()
        {
            massiv = new T[0];
        }

        public void Add(T item)
        {
            T[] new_massiv = new T[massiv.Length + 1];
            for (int i = 0; i < massiv.Length; i++)
            {
                new_massiv[i] = massiv[i];
            }
            new_massiv[massiv.Length] = item;
            massiv = new_massiv;
        }

        public void Remove(T it)
        {
            int ind = -1;
            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i].Equals(it))
                {
                    ind = i;
                    break;
                }

            }
            if (ind > -1)
            {
                T[] new_massiv = new T[massiv.Length + 1];
                for (int i = 0, j = 0; i < massiv.Length; i++)
                {
                    if (i == ind)
                    {
                        continue;
                    }
                    new_massiv[j] = massiv[i];
                    j++;
                }
                massiv = new_massiv;
            }
        }
        public T GetItem(int index)
        {
            if (index > -1 && index < massiv.Length)
            {
                return massiv[index];
            }
            else
                throw new IndexOutOfRangeException();
        }
        public int Lenght()
        {
            return massiv.Length;
        }
    }
}
