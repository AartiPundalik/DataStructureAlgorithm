using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome\n" +
                     "Choose 3L For BUbble sorting");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BubbleSort.Sort();
                        break;
                    case 2:
                        flag = false;
                        break;

                }
                Console.ReadLine();
            }
        }
    }
}
