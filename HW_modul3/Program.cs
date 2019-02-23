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
            short t;
            while (true)
            {
                Console.Write("Выберите задание от 1 до 5, либо 0 для выхода: "); t = short.Parse(Console.ReadLine());
                if (t == 1) t1();
                else if (t == 2) t2();
                else if (t == 3) t3();
                else if (t == 4) t4();
                else if (t == 5) t5();              
                else if (t == 0) break;
                else Console.WriteLine("Вы ввели не верное число. Повторите попытку");
            }
        }
        static void t1()
        {
            //•	Удалить элемент из массива по индексу.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Удалить элемент из массива по индексу.");
            Console.ForegroundColor = ConsoleColor.White;
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("• Удалить те элементы массива, которые встречаются в нем ровно два раза");
            Console.ForegroundColor = ConsoleColor.White;
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("• Удалить из строки слова, в которых есть буква 'a'");
            Console.ForegroundColor = ConsoleColor.White;
            string str = "Удалить из строки слова, в которых есть буква 'а'";
            string[] words = str.Split(new char[] { ' ' });
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].IndexOf('а') >= 0)
                    words[i] = null;
            }           
            str = String.Join(" ", words).TrimStart(new char[] { ' '}).TrimEnd(new char[] { ' ' });
            Console.WriteLine(str);
        }
        static void t4()
        {
            //•	Ввести с клавиатуры номер трамвайного билета (6 - значное число) и проверить 
            //является ли данный билет счастливым(если на билете напечатано шестизначное 
            //число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет 
            //считается счастливым).
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("• Ввести с клавиатуры номер трамвайного билета (6 - значное число) и проверить \nявляется ли данный билет счастливым(если на билете напечатано шестизначное \nчисло, и сумма первых трёх цифр равна сумме последних трёх, то этот билет \nсчитается счастливым).");
            Console.ForegroundColor = ConsoleColor.White;
            int[] bn = new int[6];
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < 6; i++)
            {
                bn[i] = Int16.Parse(Console.ReadKey().KeyChar.ToString());
            }
            for (int i = 0; i < 3; i++)
            {
                sum1 += bn[i];
            }
            for (int i = 3; i < 6; i++)
            {
                sum2 += bn[i];
            }
            if (sum1 == sum2)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Билет счастливый!");
                Console.ForegroundColor = ConsoleColor.White;
            }                
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Билет не является счастливым");
                Console.ForegroundColor = ConsoleColor.White;
            }                
        }
        static void t5()
        {
            //•	Дано целое число N (> 0), найти число, полученное при прочтении числа 
            //N справа налево.Например, если было введено число 345, то программа 
            //должна вывести число 543
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("• Дано целое число N (> 0), найти число, полученное при прочтении числа \nN справа налево.Например, если было введено число 345, то программа \nдолжна вывести число 543");
            Console.ForegroundColor = ConsoleColor.White;
            int n = 456;
            Console.WriteLine(n);
            Console.WriteLine(n.ToString().Reverse().ToArray());            
        }
    }
}
