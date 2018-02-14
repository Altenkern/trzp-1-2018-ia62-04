using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_LAB1
{
    class SortetContainer
    {
        public static void QuickSort(int[] a)
        {
            QuickSort(a, 0, a.Length - 1);
        }

        static void QuickSort(int[] a, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int num = a[start];

            int i = start - 1;
            int j = end + 1;

            while (true)
            {
                do
                {
                    i++;
                } while (a[i] < num);

                do
                {
                    j--;
                } while (a[j] > num);

                if (i >= j)
                    break;

                Swap(a, i, j);
            }

            //a[i] = num;
            QuickSort(a, start, j);
            QuickSort(a, j + 1, end);
        }

        static void Swap(int[] a, int i, int j)
        {
            if (i == j)
                return;

            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
