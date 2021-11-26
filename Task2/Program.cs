using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            double Sum2 = Sum * 2;
            double P = 4;
            int year = 0;
            do
            {
                Sum += Sum * P / 100;
                year++;
            } while (i=0);
            Console.WriteLine(year);
            Console.ReadKey();
        }
    }
}
