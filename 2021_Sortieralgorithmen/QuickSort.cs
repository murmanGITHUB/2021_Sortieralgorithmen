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

            Sort(arr, 0, arr.Length - 1);

            return arr;
        }

        private void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                //Pivot Element
                int splitPoint = Split(arr, start, end);
                //Console.WriteLine("Pivo: " + arr[splitPoint] + "index: " + splitPoint + "\r\n");
                Sort(arr, start, splitPoint - 1);
                Sort(arr, splitPoint, end);
            }
        }

        private int Split(int[] arr, int start, int end)
        {
            int left = start + 1;
            int right = end;
            int pivot = arr[start];

            while (true)
            {
                //Moving Left
                while (left <= right && arr[left] < pivot)
                    left++;

                //Moving Right
                while (right > left && arr[right] > pivot)
                    right--;

               if (left >= right) break;

                //swap items
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }

            arr[start] = arr[left - 1];
            arr[left - 1] = pivot;
            return left;
        }
    }
}
