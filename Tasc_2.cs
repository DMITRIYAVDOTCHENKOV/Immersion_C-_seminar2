using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Написать программу, выводящую кол-во единиц в двоичном представлении числа .
namespace Immersion_C_
{
    public class Tasc_2
    {
        public static void Tasc2()
        {
            Console.WriteLine("Введите число");
            byte num = byte.Parse(Console.ReadLine());
            int count = 0;
            while (num != 0)
            {
                if (num % 2 == 1)
                {
                    count++;
                }
                num /= 2;
            }
            Console.WriteLine(count);
        }

    }
}
