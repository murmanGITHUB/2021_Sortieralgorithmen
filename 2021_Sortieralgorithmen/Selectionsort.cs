using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_Sortieralgorithmen
{
    class Selectionsort
    {
        public int[] selectionSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {

                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {

                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                temp = array[i];
                array[i] = array[min];
                array[min] = temp;

            }
            return array;
        }
    }
}
