using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //sealed--method is to stop overriding
    class PPPP
    {

        public void m2()
        {

        }

        public  virtual void m1()
        {
            Console.WriteLine("in parent m1");
        }
    }

    class CC1 : PPPP
    {
        //method hiding   
        public void m2()
        {

        }

        public void greet()
        {
            Console.WriteLine("good morning");
        }
         public  override void m1()
        {

            Console.WriteLine("in child1 m1");
        }


    }

    class CC2:CC1
    {
        public override void m1()
        {
            Console.WriteLine("in child2222222 m1");
        }

        static void Main(string[] args)
        {
            CC1 c = new CC1();
            c.greet();

           PPPP ob = new CC1();
           
            ob.m1();
            ob.m2();
        }


    }

    class Bank
    {

    }

    class SBI:Bank
    {

    }
    class ICICI : Bank
    {

    }
    class Trainer
    {
        string name;
        int sal;
        Bank account;

        static void Main(string[] args)
        {
            Trainer t = new Trainer();
            t.name = "Deepa";
            t.sal = 40000;
            t.account = new SBI();
        }




    }

    class Stud
    {
        int sid;
        string name;
        int percent;

        public Stud(int sid, string name, int percent)
        {
            this.sid = sid;
            this.name = name;
            this.percent = percent;
        }

        public override string ToString()
        {
            // return "SId:" + sid + " Name=" + name + " Percentage:" + percent;
            return $"Sid:{sid} Name:{name} Percentage:{percent} ";
        }

        static void Main(string[] args)
        {
            var a =90;
            dynamic b;
            b = 90;
            b = "sfdsf";

            Console.WriteLine(a);
            Stud s1 = new Stud(1, "Omkar", 90);
            
            Console.WriteLine(s1);
            //Console.WriteLine(s1.percent);//internally it tries to call toString()
        }
    }

    //abstract class
    //partial class

    //concrete/complete
    class W
    {
        int id;
        string nm;


        public void disp()
        {
            Console.WriteLine("innnnnnnn");
        }

        

    }

    class WT
    {
        static void Main(string[] args)
        {
            W ob = new W();

        }
    }
  
    //abstract class object cant be created
  abstract class Teacher
    {
        string nmae;
        int exper;

        public Teacher(string nmae, int exper)
        {
            this.Nmae = nmae;
            this.Exper = exper;
        }
        abstract public void CalculateSalary();
        abstract public void m2();


        public Teacher()
        {

        }

        public void m3()
        {

        }

        

       
        public string Nmae { get => nmae; set => nmae = value; }
        public int Exper { get => exper; set => exper = value; }
    }

    abstract class PermanentTeacher:Teacher
    {
        int salary;
       public PermanentTeacher():base()
        {

        }
        
        public override void CalculateSalary()
        {
            Console.WriteLine("Salalry"+salary);
        }
        public abstract override void m2();
    }


    class VisitingTeacher:Teacher
    {
        int hrs, rate;

        
        public override void CalculateSalary()
        {
            Console.WriteLine("Salary="+hrs*rate);
        }

        public override void m2()
        {
            throw new NotImplementedException();
        }
    }

    class TTT
    {
        static void Main(string[] args)
        {
         
            
            
        }
    }

    class Pen
    {
        string brand;
        int cost;
        string color;
        static int c = 900;

        static Pen()
        {

        }
        public Pen(string brand, int cost, string color)
        {
            this.brand = brand;
            this.cost = cost;
            this.color = color;
        }
        public static void m1()
        {
           

        }

        public string Brand
        {
         
            get { return brand; }//readonly

        }


        private void validate()
        {

        }

        public Pen()
        {

        }
        
    }
    class Test
    {
        static void Main(string[] args)
        {
            Pen t = new Pen("Trimax",50,"black");
            Pen pp = new Pen();
            Pen.m1();

        }
    }

    class P
    {
       public P(int i)
        {
            Console.WriteLine("in parent");
        }

    }

    class C : P
    {
        public C(int k) : base(k)
        {
            Console.WriteLine("in child");
        }


        static void Main(int x)
        {

        }
        static void Main(string[] args)
        {

            C ob = new C(234);
        }
    }






    partial class Flat
    {
        int flatno;
        string ownername;

        public Flat(int flatno, string ownername)
        {
            this.flatno = flatno;
            this.ownername = ownername;
        }
    }




}
