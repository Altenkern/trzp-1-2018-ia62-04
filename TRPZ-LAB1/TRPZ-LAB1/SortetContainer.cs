using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_LAB1
{
    class SortetContainer
    {
        internal static void stupidSort(int[] arr1)
        {
            int i = 0, tmp;
            while (i < arr1.Length - 1)
            {
                if (arr1[i + 1] < arr1[i])
                {
                    tmp = arr1[i];
                    arr1[i] = arr1[i + 1];
                    arr1[i + 1] = tmp;
                    i = 0;
                }
                else i++;
            }
        }
    }
}
