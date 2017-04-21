using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            /* local variable definition*/
            int a = 10;
            /* check the boolen condition using if statement */
            if (a < 20)
            {
                /* if condition is true then print the following */
                Console.WriteLine("A is less than 20");
            }
            Console.WriteLine("value of a is :{0}", a);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
