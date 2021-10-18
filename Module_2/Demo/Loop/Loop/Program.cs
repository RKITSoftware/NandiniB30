using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declaration
            int count = 0;
            int j = 1;
            int k = 1;
            string[] branches = { "computer", "mechanical", "civil", "automobile", "electric", "electronics"};
            #endregion declaration

            #region for loop
            for (int i = 1; i <= 5; i++)
            {
                //checking for even numbers
                if (i % 2 == 0)
                    //if true,incrementing variable 'count'
                    count++;
            }

            Console.WriteLine("Number of even inputs are {0}", count);
            Console.ReadLine();
            #endregion for loop

            #region foreach loop
            foreach (string branch in branches)
            {
                Console.WriteLine(branch);
            }
            Console.ReadLine();
            #endregion foreach loop

            #region while loop
            while(j<=5)
            {
                Console.WriteLine(j);
                //increment the variable j
                j=j+2;
            }
            Console.ReadLine();
            #endregion while loop

            #region do-while loop
            do
            {
                Console.WriteLine(k);
                //increment the variable k
                k++;
            } while (k <= 5);
            Console.ReadLine();
            #endregion do-while loop
        }
    }
}
