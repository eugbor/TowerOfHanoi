using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Tower of Hanoi.
/// </summary>
namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int> {1, 2, 3, 4, 5, 6, 7, 8};
            List <int> b = new List<int>();
            List <int> c = new List<int>();
            Print(a, b, c);
            a.Reverse();
            Move(a.Count, a, b, c);
            b.Reverse();
            Print(a, b, c);
            Console.ReadLine();
        }

        static void Move(int num, List<int> a, List<int> b, List<int> c)
        {
            if (num == 1)
            {
                b.Add(a.Last());
                a.RemoveAt(a.Count - 1);
                return;
            }
            else
            {
                Move(num - 1, a, c, b);
                b.Add(a.Last());
                a.RemoveAt(a.Count - 1);
                Move(num - 1, c, b, a);
            }
        }

        static void Print(List<int> a, List<int> b, List<int> c)
        {
            List<int>[] arrLists = { a, b, c };
            char[] let = {'a', 'b', 'c'};
            for (int i = 0; i < arrLists.Length; i++)
            {
                Console.WriteLine("List<int> {0} :", let[i]);
                if (arrLists[i].Count != 0)
                {
                    for (int j = 0; j < arrLists[i].Count; j++)
                    {
                        Console.Write("{0} ", arrLists[i][j]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("List is empty");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
