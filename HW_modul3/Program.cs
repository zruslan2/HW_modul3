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

        }
        void t1()
        {
            //•	Удалить те элементы массива, которые встречаются в нем ровно два раза
            int[] arr = new int[] { 1, 6, 5, 4, 1, 6, 8, 8, 8 };
            int c=1;
            int[] ind = new int[2];
            for (int i = 0; i < arr.Length-1; i++)
            {
                ind[0] = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        c++;
                        ind[1] = j;
                    }
                    if(c==2)
                    {
                        
                    }
                }
            }
        }

    }
}
