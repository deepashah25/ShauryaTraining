using System;
using System.Collections;
using System.Collections.Generic;
using Amazon;
namespace ConsoleApp6
{
    class Program:PPPP
    {
        public void m1()
        {
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Access ob = new Access();
            Console.WriteLine(ob.c);
        }





    }


    //SortedList


    //Generic


    class A
    {
        object ob;

        public object Ob { get => ob; set => ob = value; }
    }


    class TestA
    {
        static void Main(string[] args)
        {
            A a = new A();

            
            a.Ob = 90;
            int e =(int) a.Ob;


            B<string> b = new B<string>();
            b.Ob ="fsdf";
            string d = b.Ob;
            List<int> al = new List<int>();
            al.Add(90);
            al.Add(80);
            int s = al[0];


        }
    }



    class B<T>
    {
       T ob;

        public T Ob
        {
            get { return ob; }
            set { this.ob = value; }
        }

    }
}
