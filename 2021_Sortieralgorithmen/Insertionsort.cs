using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_Sortieralgorithmen
{
    class Insertionsort
    {
        public int[] insertionSort(int[] array)
        {
            int aktuellerWert; 
            int j;
            for (int i = 1; i < array.Length; i++)
            {
                aktuellerWert = array[i];
                j = i;
                while(j>0 && array[j-1] > aktuellerWert)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = aktuellerWert;


            }
            return array;
        }
    }
}
