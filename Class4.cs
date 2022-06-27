using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    class Stude
    {
        int id;
        string nm;

       public string Nm
        {
            set
            {

                for(int i=0;i<value.Length;i++)
                {
                    if(char.IsDigit(value[i]))
                    {
                        throw new InvalidPasswordException("Invalid Name");
                    }
                }

                nm = value;
               

            }
        }

       static void Main(string[] args)
        {
            Stude s1 = new Stude();
            s1.Nm = "om123";


        }
    }

    partial class Flat
    {
        string wingname;

        public string Wingname { get => wingname; set => wingname = value; }

        public void display()
        {

        }
    }
    class Class4
    {
        static void Main(string[] args)
        {
            Flat f = new Flat(101, "omkar");
            f.Wingname = "syz";
            f.display();
        }


    }
    //Custom imutable
    class KotakBank
    {
        //static compile time constant
       public const float pi = 3.14f;
        readonly int accno;

        public KotakBank(int accno)
        {
            this.accno = accno;
        }

        public int Accno
        {
            get { return accno; }
        }

        public void m1()
        {
            const int x = 900;
            
        }
        

        static void Main(string[] args)
        {
            KotakBank k = new KotakBank(1234);
           


            Console.WriteLine(KotakBank.pi);
        }


    }

    //readonly const


    //interface is where u specify what a class should do
    interface Mobile
    {
        public abstract void call();
        void sendsms();
        

    }

    interface SmartPhone :Mobile
    {
        void playgames();
    }

    class PP
    {

    }
    interface Musicplayer
    {
        void playsong();

      public  void increasevolume()
        {

        }
        
    }
    class Samsung : PP, SmartPhone, Musicplayer
    {
        public void call()
        {

        }

        public void playgames()
        {
            throw new NotImplementedException();
        }

        public void playsong()
        {
            throw new NotImplementedException();
        }

        public void sendsms()
        {

        }

        //var compile type
        //dynamic
    }
        class SSS
        {
            static void Main(string[] args)
            {
                int i = 90;
                var x ="sdfsdf";


                dynamic b;
                b = "sadsad";
                b = 90;




            }
        }
    abstract class R
    {
        

    }
}
