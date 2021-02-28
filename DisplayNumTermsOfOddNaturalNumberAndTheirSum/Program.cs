using System;

namespace DisplayNumTermsOfOddNaturalNumberAndTheirSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, sum=0, j;
            Console.WriteLine("Input number of terms : ");
            num = int.Parse(Console.ReadLine());
            Console.Write("The odd numbers are : ");
            for (i = 1; i <= num; i++)
            {
                j = 2 * i - 1;
                Console.Write(j + " ");
                sum = sum + j;
            }
            //Console.Write("\n");
            Console.WriteLine("\nThe sum of odd natural numbers up to " + num + " terms : " + sum);
        }
    }
}
