using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= (2 * n - 1); i += 2)
            {
                Console.WriteLine("Текущее значение суммы: {0}", sum += i);
            }
            Console.ReadKey();
        }
    }
}
