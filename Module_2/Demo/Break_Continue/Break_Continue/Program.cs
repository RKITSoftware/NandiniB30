using System;

namespace Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Break 
            //Loop breaks when i Becomes 2
            for (int i = 0; i < 4; i++)
            {
                //check if i is 2
                if (i == 2)
                    //if true, break out of loop
                    break;

                Console.WriteLine("i = " + i);
            }
            Console.ReadLine();
            #endregion Break

            #region Continue
            // if the value of i becomes even then it will skip to next iteration, i.e, i+1 
            for (int i = 1; i <= 6; i++)
            {
                //check if i is even
                if (i %2 == 0)
                {
                    //if true, then continue to next iteration
                    continue;
                }
                Console.WriteLine("i = " + i);
            }
            Console.ReadLine();
            #endregion Continue

        }
    }
}
