using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestNumber
{
    //Program to find the largest of three numbers. 
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Input the 1st number :");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The first Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The third Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The second Number is the greatest among three \n\n");
            else
                Console.Write("The third Number is the greatest among three \n\n");
        
}
    }
}
