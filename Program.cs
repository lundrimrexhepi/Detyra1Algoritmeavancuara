using System;

namespace Detyra1AA
{
    class Program
    {
       
        static int findMax(int[,] arr, int rows,
                           int mid, int max)
        {
            int max_index = 0;
            for (int i = 0; i < rows; i++)
            {
                if (max < arr[i, mid])
                {

                   
                    max = arr[i, mid];
                    max_index = i;
                }
            }
            return max_index;
        }

      
        static int Max(int[,] arr, int rows,
                       int mid, int max)
        {
            for (int i = 0; i < rows; i++)
            {
                if (max < arr[i, mid])
                {                 
                    max = arr[i, mid];
                }
            }
            return max;
        }        
        static int findPeakRec(int[,] arr, int rows,int columns, int mid)
        {

            
            int max = 0;
            int max_index = findMax(arr, rows, mid, max);
            max = Max(arr, rows, mid, max);            
            if (mid == 0 || mid == columns - 1)
                return max;

           
            if (max >= arr[max_index, mid - 1] &&
                max >= arr[max_index, mid + 1])
                return max;

            
            if (max < arr[max_index, mid - 1])
                return findPeakRec(arr, rows, columns,
                       (int)(mid - Math.Ceiling((double)mid / 2)));

            
            return findPeakRec(arr, rows, columns,
                   (int)(mid + Math.Ceiling((double)mid / 2)));
        }

        
        static int findPeak(int[,] arr,
                            int rows, int columns)
        {
            return findPeakRec(arr, rows, columns,columns / 2);
        }
        static void Main(string[] args)
        {
            var a = new int[,] {{ 10, 20, 15 },
                                { 21,30,14},
                                { 7,16,32} };          
            Console.Write(findPeak(a, a.GetLength(0), a.GetLength(1)));




        }
    }
}
