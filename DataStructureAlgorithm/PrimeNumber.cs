using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class PrimeNumber
    {
        public static void DisplayPrimeNumbers()
        {
            Console.WriteLine("Enter Starting NUmber of Range ");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ending Number ");
            int lastnumber = Convert.ToInt32(Console.ReadLine());
            int value, i;
            for (i = firstnumber; i <= lastnumber; i++)
            {
                value = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        value++;
                        break;
                    }
                }
                if (value == 0 && i != 1)
                    Console.WriteLine("{0}", i);
            }

        }
    }
}
    

