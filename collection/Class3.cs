using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.collection
{
    //declare
    //set target function to delegate
    //invoke the delegate


    public delegate void mydele(string msg, string nm);



    class DemoDel
    {

        static void greet(string msg, string nm)
        {
            Console.WriteLine("Welcome " + nm + "," + msg);
        }

        static int factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;

        }
        static void Main(string[] args)
        {
            mydele d1 = DemoDel.greet;
            d1("Good evening", "Prasad");


        }
        //Delegate variable which can hold reference of function
        //Delelgate a pointer function

    }

    public delegate void del1(int a, int b);
  

    class Demo2
    {
        static void add(int a,int b)
        {
            Console.WriteLine("Sum="+(a+b));
        }


        static void subtract(int a, int b)
        {
            Console.WriteLine("Subtract=" + (a - b));
        }

        static void multiply(int a, int b)
        {
            Console.WriteLine("Product=" + (a * b));
        }
        static void Main(string[] args)
        {
            /*del1 d1 = delegate (int a, int b)
                  {
                      Console.WriteLine("anonyomous mehtod " + (a + b));
                  };
            d1(10, 2);*/

            //lambda expre

            del1 d2 = (p,q) =>Console.WriteLine("lambda " + (p + q));
            d2 += (x, y) => Console.WriteLine("Lambda2222 "+(x*y));
            d2(8, 4);

          /*        
            d1 += delegate (int a, int b)
              {
                  Console.WriteLine("anyno" + (a * b);
              };*/


            

            //Lambda 
           /* del1 d1 = add;
             d1+= multiply;
            d1 += subtract;

            d1(10, 2);
            d1 = d1 - subtract;
            d1(9, 9);*/

        }

        //an

    }
}
