using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.collection
{
    class Class5
    {
        static int add(int a, float b, long m)
        {
            Console.WriteLine("ADD:" + (a + b));
            return (int)(a + b);
        }

        static void greet(string nm)
        {
            Console.WriteLine("Good Afternoon, " + nm);
        }


        static bool isEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;

        }
        static void Main(string[] args)
        {
            Func<int, float, long, int> f1 = add;
            int ans = f1(10, 3.4f, 90l);
            Console.WriteLine(ans);
            Action<string> f2 = greet;
            f2("Naman");
            Predicate<int> f3 = isEven;
            Console.WriteLine(f3(67));


            //Func ---if ur method takes n input and return value back
            //Action--->when ur method takes n input and return type is void
            //predicate ->when ur method takes n input and returns compulsory bool value 


        }
    }

    //static void f1(int x,char d)
  


    class AA
    {
        static void Filter(List<int> lst,Predicate<int> p1)
        {

            foreach (int element in lst)
            {
                bool b=p1(element);
                if(b==true)
                    Console.WriteLine(element);
            }
        }

        static bool iseven(int a)
        {
            return a % 2 == 0;
        }
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 23, 45, 67, 88, 90, 2, 45, 66 };

            /* List<int> l2 = new List<int>();
             foreach(int d in l1)
             {
                 if (d % 2 == 0)
                     l2.Add(d);
             }
 */
            //callback function
            List<int> l3 = l1.FindAll((a)=>
            {
              for(int i=2;i<=a/2;i++)
                {
                    if (a % i == 0)
                        return false;
                }

                return true;
            });
        
    }
}
