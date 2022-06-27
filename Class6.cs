using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //custom exceptio 
    class InvalidPasswordException:ApplicationException
    {
        public InvalidPasswordException(string msg):base(msg)
        {

        }

        public InvalidPasswordException()
        {

        }

    }
 abstract class Teacherr
    {
        int id;
        string name;
        int exp;
        long mob;

        abstract public void calculateSalary();
        protected Teacherr(int id, string name, int exp, long mob)
        {
            this.id = id;
            this.name = name;
            this.exp = exp;
            this.mob = mob;
        }
        
    }

    class HourlyBasedTeacher:Teacherr
    {
        int hrs, rate;
        public HourlyBasedTeacher(int id,string nm,int e,long mb,int h,int r):base(id,nm,e,mb)
        {
            hrs = h;
            rate = r;


        }
        public override void calculateSalary()
        {
            
        }
    }
    }
