using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region single-dimension array
            Console.Write("single-dimensional array \n");

            ////create and initialise single-dimensional array
            int[] intArray = new int[] { 5, 10, 15, 20, 25 };

            //traversing the array
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + "\n");
            }
            Console.ReadLine();
            #endregion single-dimension array


            #region 2-D array
            Console.Write("Two-dimensional array \n");

            //create and initialise 2D array
            int[,] Two_array = new int[,] { { 5, 15 ,25}, { 10, 20 ,30}};

            //getlength return the length of column if we pass 0.
            //getlength return the length of row if we pass 1.
            for (int i = 0; i < Two_array.GetLength(0); i++)
            {
                for (int j = 0; j < Two_array.GetLength(1); j++)
                {
                    Console.Write(Two_array[i, j] + "\n");
                }
                Console.ReadLine();
            }
            #endregion 2-D array


            #region jagged array
            Console.Write("Jagged array \n");

            //create and initialise jagged array
            int[][] jArray = new int[2][]{ new int[3]{5, 10, 15}, new int[4]{20, 25, 30, 35}};

            //traversing the array
            for (int i = 0; i < jArray.Length; i++)
            {
                for (int j = 0; j < (jArray[i]).Length; j++)
                    Console.WriteLine(jArray[i][j]);
            }
            Console.ReadLine();
                #endregion jagged array
            }
        }
}
