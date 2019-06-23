using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string[] split;
            int n, m, a, b, c, k;
            bool flag;
            s = Console.ReadLine();
            split = s.Split(new char[] { ' ' });
            int.TryParse(split[0], out m);
            int.TryParse(split[1], out n);
            int[,] mas = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = 0;
                }
            }
            s = Console.ReadLine();
            split = s.Split(new char[] { ' ' });
            int.TryParse(split[0], out k);
            Console.WriteLine("Операции:");
            Console.WriteLine("ADD - добавить элемент m в множество n");
            Console.WriteLine("LISTSET - вывести все элементы множества");
            Console.WriteLine("LISTSETSOF - вывести номера всех множеств, сожержащих элемент");
            Console.WriteLine("Введите операции:");
            for (int l = 0; l < k; l++)
            {
                s = Console.ReadLine();
                split = s.Split(new char[] { ' ' });
                if (split[0] == "ADD")
                {
                    int.TryParse(split[1], out b);
                    int.TryParse(split[2], out a);
                    mas[a - 1, b - 1] += 1;
                }
                if (split[0] == "LISTSET")
                {
                    int.TryParse(split[1], out a);
                    flag = true;
                    for (int i = 0; i < m; i++)
                    {
                        if (mas[a - 1, i] != 0)
                        {
                            flag = false;
                            Console.Write($"{i + 1} ");
                        }
                    }
                    if (flag) Console.Write("-1");
                    Console.WriteLine();
                }
                if (split[0] == "LISTSETSOF")
                {
                    int.TryParse(split[1], out a);
                    flag = true;
                    for (int i = 0; i < n; i++)
                    {
                        if (mas[i, a - 1] != 0)
                        {
                            flag = false;
                            Console.Write($"{i + 1} ");
                        }
                    }
                    if (flag) Console.Write("-1");
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}