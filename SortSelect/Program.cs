using System;
using System.Threading.Tasks;

namespace SortSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 7, 6, 5, 4, 8, 2, 3 };
            int[] arr2 = new int[] { 6, 5, 8, 5, 5, 8, 4, 2, 3, 8, 7, 10, 25, 22, 15, 30 };

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter speed of sorting, In the range of 50-800 milliseconds։ ");
            speed = Convert.ToInt32(Console.ReadLine());

            //SelectionSort(arr);
            //BubbleSort(arr2);
            //InsertionSort(arr2);
            //MargeSort(arr2);
        }

        public static int speed;
        static int[] BubbleSort(int[] arrto)
        {
            bool t = true;
            while (t)
            {
                t = false;
                for (int j = 1; j < arrto.Length; j++)
                {
                    if (arrto[j - 1] > arrto[j])
                    {
                        (arrto[j - 1], arrto[j]) = (arrto[j], arrto[j - 1]);
                        t = true;
                    }
                    DateTime now = DateTime.Now;
                    while (DateTime.Now.Subtract(now).Milliseconds < speed) { }
                    Console.Clear();
                    Console.WriteLine("Bubble sort");

                    Console.WriteLine();
                    for (int s = 0; s < arrto.Length; s++)
                    {
                        if (j == s)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(new string('*', arrto[s]) + " Max");
                        }
                        else
                        {
                            if (j - 1 == s)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            Console.WriteLine(new string('*', arrto[s]));
                        }

                        Console.ForegroundColor = ConsoleColor.Gray;

                    }

                    foreach (var k in arrto)
                    {
                        Console.Write(k + " ");
                    }

                }
            }
            DateTime now2 = DateTime.Now;
            while (DateTime.Now.Subtract(now2).Milliseconds < speed) { }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bubble sort");

            Console.ForegroundColor = ConsoleColor.Green;

            for (int s = 0; s < arrto.Length; s++)
            {
                Console.WriteLine(new string('*', arrto[s]));
            }
            foreach (var i in arrto)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ResetColor();

            return arrto;
        }
        static int[] InsertionSort(int[] arrto)
        {
            int k;
            for (int i = 1; i < arrto.Length; i++)
            {
                k = i;
                while (k > 0)
                {
                    while (arrto[k - 1] > arrto[k])
                    {

                        (arrto[k - 1], arrto[k]) = (arrto[k], arrto[k - 1]);

                        DateTime now = DateTime.Now;
                        while (DateTime.Now.Subtract(now).Milliseconds < speed) { }
                        Console.Clear();
                        Console.WriteLine("Insertion sort");

                        Console.WriteLine();
                        for (int s = 0; s < arrto.Length; s++)
                        {
                            if (i == s)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            if (k - 1 == s)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(new string('*', arrto[s]) + " max");
                            }
                            else
                            {

                                Console.WriteLine(new string('*', arrto[s]));
                            }

                            Console.ForegroundColor = ConsoleColor.Gray;

                        }

                        foreach (var n in arrto)
                        {
                            Console.Write(n + " ");
                        }


                    }
                    k -= 1;
                }

            }
            DateTime now2 = DateTime.Now;
            while (DateTime.Now.Subtract(now2).Milliseconds < speed) { }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insertion sort");

            Console.ForegroundColor = ConsoleColor.Green;

            for (int s = 0; s < arrto.Length; s++)
            {
                Console.WriteLine(new string('*', arrto[s]));
            }
            foreach (var i in arrto)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ResetColor();
            return arrto;
        }
        static int[] SelectionSort(int[] arrto)
        {
            int min;

            for (int j = 0; j < arrto.Length - 1; j++)
            {
                min = j;
                for (int i = j; i < arrto.Length; i++)
                {
                    if (arrto[min] > arrto[i])
                    {
                        min = i;
                    }

                    DateTime now = DateTime.Now;
                    while (DateTime.Now.Subtract(now).Milliseconds < speed) { }
                    Console.Clear();
                    Console.WriteLine("Selection sort");

                    Console.WriteLine();
                    for (int s = 0; s < arrto.Length; s++)
                    {
                        if (i == s)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        if (min == s)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(new string('*', arrto[s]) + " Minimum");
                        }
                        else
                        {
                            if (j == s)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            Console.WriteLine(new string('*', arrto[s]));
                        }

                        Console.ForegroundColor = ConsoleColor.Gray;

                    }

                    foreach (var k in arrto)
                    {
                        Console.Write(k + " ");
                    }

                }
                (arrto[min], arrto[j]) = (arrto[j], arrto[min]);
            }
            DateTime now0 = DateTime.Now;
            while (DateTime.Now.Subtract(now0).Milliseconds > speed) { }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Selection sort");

            Console.ForegroundColor = ConsoleColor.Green;

            for (int s = 0; s < arrto.Length; s++)
            {
                Console.WriteLine(new string('*', arrto[s]));
            }
            foreach (var i in arrto)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ResetColor();
            return arrto;
        }
        static int[] MargeSort(int[] arrto)
        {

            if (arrto.Length < 2)
            {
                return arrto;
            }
            else
            {
                int mid = arrto.Length / 2;
                int[] arr1 = new int[arrto.Length / 2];
                int[] arr2 = new int[arrto.Length / 2];
                for (int i = 0; i < mid; i++)
                {
                    arr1[i] = arrto[i];
                    arr2[i] = arrto[i + mid];
                }
                arr1 = MargeSort(arr1);
                arr2 = MargeSort(arr2);
                return Sorting_ForMargeSort(arr1, arr2);

            }
            Console.WriteLine("\n Marge sort");
            for (int s = 0; s < arrto.Length; s++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(arrto[s] + " ");
            }
            return arrto;
        }
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
        static int[] Sorting_ForMargeSort(int[] arr1, int[] arr2)
        {
            DateTime now = DateTime.Now;
            while (DateTime.Now.Subtract(now).Milliseconds < speed) { }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Arr1");
            for (int s = 0; s < arr1.Length; s++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(arr1[s]  + new string('*', arr1[s]));
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Arr2");
            for (int s = 0; s < arr2.Length; s++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(arr2[s]  + new string('*', arr2[s]));
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            int[] array = new int[arr1.Length + arr2.Length];
            for (int i = 0, j = 0; i < arr1.Length || j < arr2.Length;)
            {

                if (arr1[i] < arr2[j])
                {
                    array[j + i] = arr1[i];
                    i++;
                }
                else
                {
                    array[i + j] = arr2[j];
                    j++;
                }
                if (i == arr1.Length)
                {
                    while (j < arr2.Length)
                    {
                        array[j + i] = arr2[j];
                        j++;
                    }
                }
                if (j == arr2.Length)
                {
                    while (i < arr1.Length)
                    {
                        array[j + i] = arr1[i];
                        i++;
                    }
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Marge sort");
            for (int s = 0; s < array.Length; s++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(array[s] + new string('*', array[s]));
            }


            Console.ResetColor();
            return array;
        }
    }
}
