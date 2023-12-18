using System;

namespace Lesson
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int n = 5;
            int num = 1;
            int sum = 0;

            //while (num < n)
            //{
            //    sum += num;
            //    num++;
            //}

            for (int i = 1; i < n; i++)
            {
                sum += i;
            }


            Console.WriteLine(sum);


            int start = 45;
            int end = 546;

            int result = 0;

            for (int i = start; i < end; i++)
            {
                if (i % 11 != 0)
                {
                    continue;
                }

                result += i;
            }

            Console.WriteLine(result);

            bool check = false;
            for (int i = start; i < end; i++)
            {
                if (i % 11 == 0)
                {
                    check = true;
                    break;
                }
            }

            if (check)
            {
                Console.WriteLine("var");
            }
        }
    }
}
