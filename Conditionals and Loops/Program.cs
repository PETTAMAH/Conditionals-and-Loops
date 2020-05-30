using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            //switch 1.\\
            /*
            int num = 2;
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 4:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
            }
            */

            //switch 2.\\
            /*
            int x = 33;
            switch (x)
            {
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 18:
                    Console.WriteLine("Eighteen");
                    break;
                case 33:
                    Console.WriteLine("Thirdty three");
                    break;

            }
            */

            //The default Case\\
            /*
            int age = 88;
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young");
                    break;
                case 42:
                    Console.WriteLine("Adult");
                    break;
                case 70:
                    Console.WriteLine("Senior");
                    break;
                default:
                    Console.WriteLine("This is the cucumber egg");
                    break; 
            }
            */

            //while\\
            /*
            int num = 1;
            while (num < 6)
            {
                Console.WriteLine(num);
                num++;
            }
            */

            //Fill in the blanks to\\

            /*
            int x = 7;
            int num = 0;
            while (num < 8)                                         //Itt a X az, hogy mit írjon ki, ami az X-el egyenlő
                                                                    //A num pedig az, hogy ami (jelen esetben) 0 és 8 között van (8x) kíírja X-et
            {
                Console.WriteLine(x);
                num++;
            }
            */

            //The while Loop 1.\\
            /*
            int num = 1;
            while (num<=7)                                         //Itt az, hogy a num-nak megadunk egy értéket (1), ez ketteségvel ugrál fel jelen esetben 7-ig
            {
                Console.WriteLine(num);
                num += 2;
            }
            */

            //Fill in the blanks to\\
            /*
            int num = 0;
            while (num < 100)
            {
                Console.WriteLine(num);
                num += 2;
            }
            */
            //The while Loop 2.\\

            /*
            int num = 0;
            while (num++ < 10)                                      //Num++ és ++num között van különbség
            Console.WriteLine(num);
            */

            //How many times will the following loop execute?\\???

            /*
            int x = 1;
            while(x++<5)
            {
                if (x % 2 == 0) 
                x += 2;
                Console.WriteLine(x);
            }
            */

            Console.ReadKey();
            


        }
    }
}
