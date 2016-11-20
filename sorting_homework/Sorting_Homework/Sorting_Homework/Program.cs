using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Homework
{
    internal class Program
    {
        private static int[] sortArray;

        private static void Main(string[] args)
        {

            sortArray = new int[] {1, 2, 6, 4, 3, 5, 6, 5, 7, 0};
            //bubles();
            insertSort();
            Console.ReadLine();

        }

        static void bubles()
        {
            for (int i = 0; i < sortArray.Length - 1; i++)
            {
                bool swap = false;
                for (int j = 0; j < sortArray.Length - i - 1; j++)
                {
                    if (sortArray[j] > sortArray[j + 1])
                    {
                        Swap(j, j + 1);
                        swap = true;
                    }
                }
                if (!swap)
                {
                    break;
                }
            }
        }

        static void insertSort()
        {
            for (int i = 1; i < sortArray.Length; i++)
            {
               
                int j = i;
                while (j > 0 && sortArray[j]< sortArray[j - 1])
                {
                    Swap(j, j-1);
                    j--;
                }
                
            }
        }


        static void Swap(int a, int b)
        {
            int temp = 0;
            temp = sortArray[a];
            sortArray[a] = sortArray[b];
            sortArray[b] = temp;
        }

    }

}
