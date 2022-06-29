using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp6.collection
{
    //Collection-growable 
    //Array--fixed

    //Both are containers in  which store data

    //autoboxing auto unboxing 

    class Class1
    {
        static void Main(string[] args)
        {
            //array 4
            //Collections stores object
            ArrayList al = new ArrayList(100);
            al.Add(90);
            al.Add(100);
            al.Add("omkar");

            ArrayList al2 = new ArrayList(100);
            al2.Add("deepa");
            al2.Add(10.6f);
            al2.Add('a');

            al.AddRange(al2);

            for (int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
            foreach(dynamic ob in al)
            {
                Console.WriteLine(ob);
            }
           
            
          //  Boxing convert primitive to object 
            Object o = 90;

           int d = (int)o;

            
        }
    }



    class DemoList
    {
        static void Main(string[] args)
        {
            List<int> ll = new List<int>();
            ll.Add(90);
            ll.Add(12);
            ll.Add(234);
            ll.Insert(0, 1);
            ll[2] =11111;
            ll.Clear();



            ll.Sort();
            Console.WriteLine(ll.Contains(900));

            foreach(int data in ll)
                Console.WriteLine(data);

        }
    }
    class AA<E>
    {
        E obj;

        public E Obj
        {
            set { obj = value; }
            get { return obj; }
        }
    }

    class A
    {
        object obj;

        public object Obj { get => obj; set => obj = value; }
    }
    class Test
    {
        static void Main(string[] args)
        {
            //Object ob = new string("sf");
            A a = new A();
            a.Obj = new string("sdsad");
            a.Obj = 90;

            int x =(int) a.Obj;
            AA<string> a2 = new AA<string>();
            a2.Obj = "asdas";
            //a2.Obj = 90;
            string d = a2.Obj;




        }


    }


    class DemoStack
    {
        //LIFO last in first out


        static void Main(string[] args)
        {
            //array
            Stack<string> st = new Stack<string>();
            //Push //Add
            st.Push("A");
            st.Push("B");
            st.Push("C");
            st.Push("C");
            st.Push("C");
            st.Clear();

            foreach (string sd in st)
                Console.WriteLine(sd);

            string data = st.Pop();
            Console.WriteLine("Data Removed "+data);

            Console.WriteLine("_____________________________");
            foreach (string sd in st)
                Console.WriteLine(sd);

            ;
            string ss=st.Peek();
        }
    }

    class DemoQueue //FIFO
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("A");
            q.Enqueue("B");
            q.Enqueue("C");
            
            //SOLID principle
            //Collection


            foreach(string d in q)
                Console.WriteLine(d);

          string data= q.Dequeue(); //remove
            Console.WriteLine("Removed "+data);

            string front=q.Peek();
            Console.WriteLine("*******************************");
            foreach (string d in q)
                Console.WriteLine(d);

        }
    }


    class Demolst
    {
        static void Main(string[] args)
        {
            

            List<string> l1 = new List<string>() { "A", "B", "C" };

            List<string> l2 = new List<string>() { "A","B","C" };

            


            l1.AddRange(l2);

            foreach(string d in l1)
                Console.WriteLine(d);

            Console.WriteLine("*****************");


            foreach (string d in l2)
                Console.WriteLine(d);



        }
    }


    class DemoDict
    {
        static void Main(string[] args)
        {
            //key always should be unique,key cant be null,
            //Data retrieve dictionary u need know key
            //hashing -GETHASHCODE EQUALS

            //Collection -used as container

            //Non Generic-(heterogenous)->
            //ArrayList(array growable,duplicates allowed,insertion ,indexed)
            //Stack-LIFO 
            //Queue-FIFO
            //Hashtable(K<V)--array--->insert uses hashing (2 methods getHashcode and equals)
            //SortedList(K,V)--data sorted according to the keys

            //IComparable -compareTo(object s1) //original implement,one logic 
            //IComparer  Compare(Stud s2,stud s2)  ///multiple ,original not accessible



            //Generic-homogenous
            //List--array growable,duplicates allowed,insertion ,indexed
            //Stack<> LIFO
            //Queue -FIFO
            //Dictionary(k,V) array--->insert uses hashing (2 methods getHashcode and equals)
            //search --time required -O(1)
            //in Dictionary if u try to add custom then u should override getHashcode and equals

            //SortedList<k,v>-data sorted according to the keys

            //LinkedList<T>--double linked list
            //Hashset<T>





            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(101, "Kavita");
            d1.Add(102, "Om");
            d1.Add(103, "Om");

           

          


        }
    }

    //List -array
    //LinkedList
    class DemoLinkedList
    {
        static void Main(string[] args)
        {
            //
            //double linked list
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(90);
            ll.AddLast(67);
            ll.AddFirst(88);
            ll.AddLast(900);
            ll.AddLast(900);
            ll.AddLast(67);
            //88,90,67
            LinkedListNode<int> addr= ll.Find(90);
            ll.AddAfter(addr, 100);
            ll.Remove(67);

            foreach(int d in ll)
                Console.WriteLine(d);


        }
    }

   class DemoHashset
    {
        static void Main(string[] args)
        {
            //unique  hashing technique
            HashSet<string> ht = new HashSet<string>();
            ht.Add("om");
            ht.Add("piya");
            ht.Add("om");

            foreach(string d in ht)
                Console.WriteLine(d);

            HashSet<Studd> hs2 = new HashSet<Studd>();
            hs2.Add(new Studd(1, "Om", 90));
            hs2.Add(new Studd(1, "Om", 90));
            foreach (Studd d in hs2)
                Console.WriteLine(d);



        }
    }

    class DemoSortedSet
    {
        static void Main(string[] args)
        {
            //IComparable/IComparer
            SortedSet<Studd> ss = new SortedSet<Studd>();
            ss.Add(new Studd(1, "ommm", 90));
            
        }
    }
}
