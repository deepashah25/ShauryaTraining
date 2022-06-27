using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.collection
{
    class Studd:IComparable<Studd>
    {
        int sid;
        string name;
        int percent;




        public override string ToString()
        {
            return "sid:"+sid+" Name:"+name+ " Percent"+percent;
        }

        public int CompareTo(Studd s2)
        {
           /* if (this.percent == s2.percent)
                return this.name.CompareTo(s2.name);
            else*/
            return s2.percent.CompareTo(this.percent);
        }

        public override bool Equals(object obj)
        {
            return obj is Studd studd &&
                   sid == studd.sid &&
                   name == studd.name &&
                   percent == studd.percent;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(sid, name, percent);
        }

        public Studd(int sid, string name, int percent)
        {   //this--current object
            this.Sid = sid;
            this.Name = name;
            this.Percent = percent;
        }


      
        public int Sid { get => sid; set => sid = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
    }
    class DemoListCustom
    {
        static void Main(string[] args)
        {
            List<Studd> lst = new List<Studd>();
            lst.Add(new Studd(101, "AAmit", 89));
            lst.Add(new Studd(102, "Adi", 79));
            lst.Add(new Studd(103, "Sujay", 99));
            lst.Add(new Studd(104, "Jaya", 69));
            Console.WriteLine(lst.Count);

           IEnumerator<Studd> ee =lst.GetEnumerator();

            while(ee.MoveNext())
            {
                Console.WriteLine("hii"+ee.Current);
            }


            

        }
    }
    class DemoSortedList
    {
        //IComparable IComparer
        static void Main(string[] args)
        {
            SortedList<string,int> ss = new SortedList<string,int>();
            ss.Add("Suraj", 90);
            ss.Add("Gaurav", 91);
            ss.Add("Priyanka", 90);
            ss.Add("Priya", 90);
            ss.Add("Ajinkya", 90);

            foreach(KeyValuePair<string,int> kv in ss)
                Console.WriteLine(kv.Key+"=====>"+kv.Value);







        }
    }


    class DemoSS2
    {
        static void Main(string[] args)
        {
             //Firstdata<second
            Console.WriteLine("Amit".CompareTo("Dinesh"));//-1
            Console.WriteLine("Dinesh".CompareTo("Amit"));//+1
            Console.WriteLine("Amit".CompareTo("Amit"));//0
            string[] a = { "yogeah", "snehal", "Priyanka", "Suraj" };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if(a[j].CompareTo(a[j+1])==1)
                    {
                        //swap
                    }
                }
            }
        }
    }

    class myStudsort : IComparer<Studd>
    {
        public int Compare(Studd x, Studd y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    class DSS3
    {
        static void Main(string[] args)
        {
            
            SortedList<Studd, string> ss = new SortedList<Studd, string>(new myStudsort());
            ss.Add(new Studd(1, "Ajinkya", 90), "C#");
            ss.Add(new Studd(2, "Riya", 80), "Java");
            ss.Add(new Studd(3, "Amey", 70), "C#");

            foreach(KeyValuePair<Studd,string> kv in ss)
            {
                Console.WriteLine(kv.Key+"===>"+kv.Value);
            }

        }
    }

    class mysorted:IComparer<StringBuilder>
    {
        public int Compare(StringBuilder s1,StringBuilder s2)
        {
            return s1.ToString().CompareTo(s2.ToString());
        }
    }

    class mysorted22
    {

    }

    //original class should implement IComparable
    class DSS4
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> ss = new SortedList<StringBuilder, int>(new mysorted());
            ss.Add(new StringBuilder("Siya"),90);
            ss.Add(new StringBuilder("Riya"), 90);

            ss.Add(new StringBuilder("Diya"), 90);


        }
    }
}
