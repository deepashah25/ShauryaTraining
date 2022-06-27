using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //sealed keyword before class that class further cant have subclass or child
    //sealed keyword before method means that method cant further be overridden
    class AAAAAA
    {
        public  void add(int a,int b)
        {

        }


        public void add(int a,int b,int c)
        {

        }
    }
    class Parent //permission authority
    {
        string name;

        //instance method without virtual keyword 
        public void play()
        {
            Console.WriteLine("play on ground");
        }

        public virtual void study()
        {
            Console.WriteLine("Read books");

        }
        //method hiding
        public static void m1()
        {
            Console.WriteLine( "in parent");
        }
    }
    //polymorphism--one name but multiple forms
    //over loading //compile time polymorphism 
    //over riding //runtime polymorphism
    class Child:Parent
    {
        //method hiding
        public static void m1()
        {
            Console.WriteLine("in Child m1");
        }

        //To do method hiding we use new keyword 
        public new void play()
        {
            Console.WriteLine("Play videos games");
        }
        //method riding
        public override void study()
        {
            Console.WriteLine("Learn watching online videos");
           
        }
    }

    class TTest
    {

        //static method overload and override is possible
       static void Main(int a)
        {

        }
        static void Main(string[] args)
        {
            Main(10);
            Child.m1();
            Parent p = new Child();
            p.play();
           /* Parent p=new  Parent();
            p.study();
            p.play();
            Child c1 = new Child();
            c1.study();
            c1.play();
            //reference variable of parent type can hold object of child
            Parent p2 = new Child(); //compilation ->.exe.->executed
            p2.study();
            p2.play();*/
            //Overriding is an example of runtime polymorphism
            //overriding is possible in inheritance.
            //When you have exactly same method in parent with virtual keyword
            //and child overrides it then when we create object like
            //Parent p=new Child() here first compiler checks at compile time
            //reference variable is parent type 
            //So Are the methods present in parent if yes it compiles the code
            //and at runtime it checks on parent reference whose object is store 
            //if it is child object then childs method is called and accordingly
            //so the decision exactly whose method needs to be called is taken at runtime 
            //thats why its called runtime polymorphism




        }
    }
    class Overload
    {


       public static void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }


        public static void Add(int a,int b,int c)
        {
            Console.WriteLine(a+b+c);

        }


        static void Main(string[] args)
        {
            Overload.Add(1, 2);
            Overload.Add(1, 2,3);
        }
    }
}
