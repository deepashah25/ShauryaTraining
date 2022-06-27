using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Class1
    {
        static void Main(string[] args)
        {
            //i=1 to 10 i++

            //i=10 to 1 i--
            /*
            A
            AB
            ABC
            ABCD
            ABCDE
            ABCDEF

            ABCDE
            ABCD
            ABC
            AB
            A
            */
            for(char r='E';r>='A';r--)
            {
                for(char c='A';c<=r;c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }

        }
    }
    class AAA
    {
        static void Main(string[] args)
        {
            /*
             1
             10
             101
             1010
             10101
            */
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c % 2);
                }
                Console.WriteLine();
            }


            /*
              0
              12
              345
              6789

             */

            int k = 0;
            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(k);
                    k++;
                }
                Console.WriteLine();
            }
        }
    }

    class T1
    {
        /*
             1
            12
           123
          1234
         12345
         

        */


            static void Main(string[] args)
            {

            int k = 4;
            for(int r=1;r<=5;r++)
            {

                for(int space=1;space<=5-r;space++)
                {
                    Console.Write(" ");
                }
                for(int c=1;c<=r;c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                k--;
            }
            }
     }
        
    class T2
    {
        static void Main(string[] args)
        {
            /*
             
              *
             ***
            *****
           *******
          *********
              
             */

            Console.WriteLine("enter number of lines");
            int line = int.Parse(Console.ReadLine());

            for(int r=1;r<=line;r++)
            {

                for(int sp=1;sp<=line-r;sp++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<2*r;j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }



        }
    }
    class T3
    {
        static void Main(string[] args)
        {
            /*
              1
             121
            12321
           1234321
          123454321
            */

            for(int r=1; r<=5;r++)
            {
                for(int space=r;space<=4;space++)
                {
                    Console.Write(" ");
                }
                for(int c=1;c<=r;c++)
                {
                    Console.Write(c);
                }

                for(int k=r-1;k>=1;k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
             
        }
    }
    /*
     
     */ 

    class Demodowhile
    {
        static void Main(string[] args)
        {
            for(int i=11;i<=10;i++)
                Console.WriteLine(i);



            int j = 11;
            while(j<=10)
            {
                Console.WriteLine(j);
                j++;
            }

            int k = 11;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k <= 10);


            //for,while ->entry ctrl loop
            //do while exit control loop once

        }
    }

    class do2
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("enter 2 number ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int sum = a + b;
                Console.WriteLine("sum=" + sum);
                Console.WriteLine("Do u want to perform addition once more yes/no");
                choice = Console.ReadLine().ToLower();

            } while (choice == "yes");



            for(int i=1;i<=10;i++)
            {
                //Console.WriteLine(i);
                if (i == 6)
                {
                    continue;
                }
                Console.WriteLine(i);
            }







        }
    }

    class DDDD
    {
        static void Main(string[] args)
        {
            int x;
            for ( x = 1; x <= 10; x++)
                ;
            {
                Console.WriteLine(x);
            }

           
        }
    }

    //increasing number
    //169
    //831
    //182-Bouncy
    class Increasing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            //n=1689
            
            bool isincreasing = true;
            bool isdecreasing = true;

            int last = n % 10;//9
            n = n / 10;//n=168

            while(n>0)
            {
                int prev = n % 10;//1
                if(prev>last)
                {
                    isincreasing = false;

                }

                if(prev<last)
                {
                    isdecreasing = false;
                }

                n = n / 10;//0
                last = prev;//last=1

            }

            //OOPS
            if(isdecreasing==true)
                Console.WriteLine("no is decreasing");
            else if(isincreasing==true)
                Console.WriteLine("increasing number");
            else
                Console.WriteLine("Bouncy");

        }
    }
}
