using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public static void Reversing()
        {
            int Number;
            int Remainder;
            int Reverse = 0;
            Console.WriteLine("Enter a number ");
            Number = Convert.ToInt32(Console.ReadLine());
            while (Number > 0)
            {
                Remainder = Number % 10;
                Reverse = (Reverse * 10) + Remainder;
                Number = Number / 10;
            }
            Console.WriteLine(" The Reverse Number is: " + Reverse);
        }
    }
}

    

