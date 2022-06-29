using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.collection
{
    public delegate int del5(int a, int b);

    //delegates generic
    //Func
    //Action

    class Class4
    {
       /* static int add(int a,int b)
        {
            return a + b;
        }
*/

        static void Main(string[] args)
        {
           
            del5 ob2 = (a, b) => a + b;

            Console.WriteLine("Answer=" + ob2(8, 9));
           
        }
    }
}
