using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
//    №2
//შექმენით გაფართოებული მეთოდი მთელ რიცხვთა მასივისთვის, რომელიც მოახდენს მასივის დალაგებას
    internal static class ExtendSort
    {
        public static void Sort(this int[] arr){
            MergeSortArray(arr, 0, arr.Length - 1);
        }

        static void MergeSortArray(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSortArray(arr, left, mid); 
                MergeSortArray(arr, mid + 1, right); 

                Merge(arr, left, mid, right); 
            }
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            
            for (int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = arr[mid + 1 + j];

            int p = 0; 
            int q = 0; 
            int k = left; 

           
            while (p < n1 && q < n2)
            {
                if (leftArray[p] <= rightArray[q])
                {
                    arr[k] = leftArray[p];
                    p++;
                }
                else
                {
                    arr[k] = rightArray[q];
                    q++;
                }
                k++;
            }

            
            while (p < n1)
            {
                arr[k] = leftArray[p];
                p++;
                k++;
            }

            
            while (q < n2)
            {
                arr[k] = rightArray[q];
                q++;
                k++;
            }
        }

    }

}
