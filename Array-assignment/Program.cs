using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, a, b;
            Console.Write("Enter the range of the prime numbers you want:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            Console.WriteLine();
            int[] arr = new int[num + 1];
            for (a = 2; a <= num; a++)
            {
                arr[a] = 1;

            }
            for (a = 2; a <= num; a++)
            {
                if (arr[a] == 1)
                {
                    for (b = 2; b * a <= num; b++)
                    {
                        arr[b * a] = 0;
                    }
                }
            }
            Console.Write("The prime numbers between 1 and your range are:");
            for (a = 2; a <= num; a++)
            {
                if (arr[a] == 1)
                {
                    Console.Write(a + " ");
                }
            }

        }
    }
}