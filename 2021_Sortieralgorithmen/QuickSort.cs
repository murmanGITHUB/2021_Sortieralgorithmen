using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_Sortieralgorithmen
{
    class QuickSort
    {
        public TextBox textbox;
        public int[] quickSort(int[] arr, TextBox textbox)
        {
            this.textbox = textbox;
            if (arr.Length <= 1)
            {
                return arr;
            }

            QuickSortArray(arr, 0, arr.Length - 1);
            return arr;
        }

        static int[] QuickSortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot) { i++; }
                while (array[j] > pivot) { j--; }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (leftIndex < j)
                QuickSortArray(array, leftIndex, j);
            if (i < rightIndex)
                QuickSortArray(array, i, rightIndex);
            return array;
        }
    }
}
