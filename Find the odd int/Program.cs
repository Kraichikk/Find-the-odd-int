using System;
using System.Linq;

namespace Find_the_odd_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 3, 3, 3, 3, 2, 2, 1 };
            Console.WriteLine(find_it(ints));
            Console.WriteLine(find_it_linq(ints));
            Console.ReadLine();

        }
        public static int find_it_linq(int[] seq)
        {
            return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        }
        public static int find_it(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (count % 2 != 0)
                {
                    return array[i];
                }
            }
            return -1;
        }
    }
}
