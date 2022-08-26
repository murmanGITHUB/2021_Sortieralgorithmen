using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_Sortieralgorithmen
{
    internal class QuickSortShort
    {
        public  int[] quickSort(int[] arr)
        {
            if (arr.Length <= 1){return arr;}
            Sort(arr, 0, arr.Length - 1);
            return arr;
        }
        private void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int splitPoint = SplitSwap(arr, start, end);//Pivot Element
                Sort(arr, start, splitPoint - 1);
                Sort(arr, splitPoint, end);
            }
        }
        private int SplitSwap(int[] arr, int start, int end)
        {
            int left = start + 1;
            int right = end;
            int pivot = arr[start];
            while (left < right)
            {           
                while (left < right && arr[left] < pivot) left++;   //Moving Left               
                while (left < right && arr[right] > pivot) right--; //Moving Right

                //if (left >= right) break;
                //swap items
                int temp = arr[left]; arr[left] = arr[right]; arr[right] = temp;
                left++; right--;
            }
            arr[start] = arr[left - 1];
            arr[left - 1] = pivot;
            return left;
        }
    }
}
