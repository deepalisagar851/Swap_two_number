using System;

namespace Sum_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Enter first number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping First number="+n1+" Second Number="+n2);
            temp = n1;
            n1 = n2;
            n2 = n1;
            Console.WriteLine("After swapping First number=" + n1 + " Second Number=" + n2);

        }
    }
}
