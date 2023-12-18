using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 34;
            int num2 = 13;
            int num3 = 54;

            int count = 0;

            if(num1>0 && num1 % 2 == 0)
            {
                count++;
            }

            if (num2 > 0 && num2 % 2 == 0)
            {
                count++;
            }

            if(num3>0 && num3 % 2 == 0)
            {
                count++;
            }

            Console.WriteLine(count);

        }
    }
}
