using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //The if statement\\  
            /*
            int x = 7;
            int y = 8;

            
             if (x > y) 
            {
                Console.WriteLine("Az x nagyobb, mint az y");
            }
            else
            {
                Console.WriteLine("Az y nagyobb, mint az x");
            }
            */

            //Relational Operators\\
            /*
            if(7>=4)
            {
                Console.WriteLine("True");
            }

            if(7<=4)
            {
                Console.WriteLine("False");
            }

            if(7==4)
            {
                Console.WriteLine("False");
            }

            if(7!=4)
            {
                Console.WriteLine("True");
            }
            */

            //The else Clause\\
            /*
            int mark = 85;

            if(mark<50)
            {
                Console.WriteLine("You failed.");
            }
            else
            {
                Console.WriteLine("You passed.");
            }
            */

            //Nested if Statements 1.\\
            /*
            int mark = 100;

            if (mark >= 50)
            {
                Console.WriteLine("You passed.");
                if (mark == 100)
                {
                    Console.WriteLine("Perfect!");
                }
            }
            else
            {
                Console.WriteLine("You failed.");
            }
            */

            //Nested if Statements 2.\\
            /*
            int age = 10;
            if (age > 14)
            {
                if (age >18){
                    Console.WriteLine("Adult");
                }
                else
                {
                    Console.WriteLine("Teenager");
                }
            }
            else
            {
                if (age > 0)
                {
                    Console.WriteLine("Child");
                }
                else
                {
                    Console.WriteLine("Something wrong");
                }
            }
            */
            //What is the output of this code?\\ (The if-else Statement)
            /*
            int a = 8;
            int b = ++a;
            if (a > 5)
                b -= 3;
            else
                b = 9;
            Console.WriteLine(b);
            */

            //The if-else if Statement\\
            /*
            int x = 33;

            if (x == 8)
            {
                Console.WriteLine("Value of x is 8");
            }
            else if (x == 18)
            {
                Console.WriteLine("Value of x is 18");
            }
            else if(x==33) 
            {
                Console.WriteLine("Value of x is 33");
            }
            else
            {
                Console.WriteLine("No match");
            }
            */


            Console.ReadKey();
        }
    }
}
