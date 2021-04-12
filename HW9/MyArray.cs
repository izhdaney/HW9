using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class MyArray
    {
        public int[] InsertElement(int[] arr, int insertValue)
        {
            Console.WriteLine($"Element {insertValue} is added to the end of the array.\n");

            int[] newArr = new int[arr.Length + 1];

            newArr[arr.Length] = insertValue;

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            return newArr;
        }

        public int[] DeleteElemnt(int[] arr)
        {
            Console.WriteLine("Deleting the last item\n");
            int[] newArr = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArr[i] = arr[i];
            }

            return newArr;
        }

        public int[] DeleteElemntForIndex(int[] arr, int insertValue)
        {
            Console.WriteLine("Deleting the last item\n");
            int[] newArr = new int[arr.Length - 1];

            for (int i = 0; i < insertValue; i++)
            {
                newArr[i] = arr[i];
            }

            int j = insertValue + 1;

            for (int i = insertValue; i < newArr.Length; i++)
            {
                newArr[i] = arr[j];
                j++;
            }

            return newArr;
        }




    }
}
