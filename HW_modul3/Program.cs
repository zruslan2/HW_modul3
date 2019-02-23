using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            t3();
        }
        static void t1()
        {
            //•	Удалить элемент из массива по индексу.
            int[] arr = new int[] { 1, 6, 8, 10 };
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            arr = delItemByInd(arr, 3);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static int[] delItemByInd(int[] arr, int ind)
        {
            int[] tmp = new int[arr.Length - 1];
            if (!(ind >= arr.Length))
            {
                Array.Copy(arr, 0, tmp, 0, ind);
                Array.Copy(arr, ind + 1, tmp, ind, arr.Length - ind - 1);
            }
            else if (ind == arr.Length)
            {
                Array.Copy(arr, 0, tmp, 0, ind);
            }
            else if (ind == 0)
            {
                Array.Copy(arr, ind + 1, tmp, ind, arr.Length - ind - 1);
            }
            else
            {
                return arr;
            }
            return tmp;
        }
        static void t2()
        {
            //•	Удалить те элементы массива, которые встречаются в нем ровно два раза
            int[] arr = new int[] { 1, 6, 5, 4, 1, 8, 8, 9, 10 };
            int c = 1;
            int[] ind = new int[2];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                ind[0] = i;
                c = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        c++;
                        ind[1] = j;
                    }
                }
                if (c == 2)
                {
                    for (int k = 1; k >= 0; k--)
                    {
                        arr = delItemByInd(arr, ind[k]);
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void t3()
        {
            //•	Удалить из строки слова, в которых есть буква 'a'
            string str = "Удалить из строки слова, в которых есть буква 'а'";
            string[] words = str.Split(new char[] { ' ' });
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].IndexOf('а') >= 0)
                    words[i] = null;
            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            str = String.Join(" ", words).TrimStart(new char[] { ' '}).TrimEnd(new char[] { ' ' });
            Console.WriteLine(str);
        }

    }
}
