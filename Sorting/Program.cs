using System;

namespace Sorting
{
    class Program
    {
        static int getIndex(int[] arr, int min, int max, int num)
        {
            if (arr[max] == num)
            { 
                return max;
            }
            if (arr[min] == num)
            {
                return min;
            }
            if (arr[(max + min) / 2] > num)
            {
                max = (max + min) / 2;
            }
            else
            {
                min = (max + min) / 2;
            }
            return getIndex(arr, min, max, num);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,3,4,5,6,7,8,9,10};
            Console.Write("Enter number :");
            int val = Convert.ToInt32(Console.ReadLine());
            bool valid = false;
            for (int i = 0; i < arr.Length; i++)
            {

                if (val == arr[i])
                {
                    valid = true;
                    Console.WriteLine(getIndex(arr, 0, arr.Length - 1, val));
                }
            }
            if (valid != true)
            {
                Console.WriteLine("There isn't this number in the Array!!!!!!!!");
            }
            

            
        }
    }
}
