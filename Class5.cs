using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //Exception
    class Class5
    {
        static string name;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(name.Length);
                Console.WriteLine(name.ToUpper());
                Console.WriteLine("om"[6]);
            }

            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (SystemException se) //universal 
            {
                Console.WriteLine(se.Message);
            }

            try
            {
                Console.WriteLine("enter number");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("try ends");
            }

            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            //error case ur catch block gets executed
            for (int i = 2; i <= 20; i = i + 2)
                Console.WriteLine(i);

            //ApplicationException  e = new FormatException();

        }
    }
    class Excep2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 number");

        
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                try
                {
                    Console.WriteLine("sum="+(a+b));
                    Console.WriteLine("Division="+a/b);
                    Console.WriteLine("Enter c");
                    int c = int.Parse(Console.ReadLine());
                }
                catch(DivideByZeroException d)
                {
                    Console.WriteLine(d.Message);
                }
                finally
                {

                }
                Console.WriteLine("outer try ends");
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
            Console.WriteLine("Main ends");

            //exception always propogate
        }
    }


    class Excep3
    {


        static void add()
        {
           
                Console.WriteLine("enter 2numbers");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Sum=" + (a + b));
           
        }
        static void m2()
        {

        }
        static void Main(string[] args)
        {
            try { 
                add();
                m2();
            }

            catch(FormatException e)
            {
                Console.WriteLine("Main "+e.Message);
            }
            finally
            {
                //irrespective of exception
                Console.WriteLine("in finally ");
                //resources close

            }




            //finally
            //throw
            //Custom exception
        }
    }

    class Empp

    {
        string nm;
        string pass;

        public Empp(string nm, string pass)
        {
            this.nm = nm;
            this.pass = pass;
        }

        public override string ToString()
        {
            return "Name="+nm + "Password:"+pass;
        }

        public string Passsword
        {
            set 
            {
                if (value.Length < 5)
                    throw new InvalidPasswordException();

                pass = value;
            }
        }

        static void Main(string[] args)
        {
            float f = 9.5f;
            int i =(int) f;

            Empp e1 = new Empp("deepa","abcdefgh");
            Console.WriteLine(e1);

            Object ob = new Object();
            
            //String s = (String)ob;
            //Console.WriteLine(s.Length);

          //  StringBuilder sb = (StringBuilder)ob;

            
        }
    }

    

}
