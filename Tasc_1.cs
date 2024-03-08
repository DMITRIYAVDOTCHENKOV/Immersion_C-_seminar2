using System;

namespace Immersion_C_
{
    internal class Tasc_1
    {
        public void CountNumbersDivisibleByThree()
        {
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
