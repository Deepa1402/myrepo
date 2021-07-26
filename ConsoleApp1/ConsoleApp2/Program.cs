using System;

namespace ConsoleApp2
{
  
    public class Teacher
    {
        int tid;
        string tname;
      public Teacher(int tid, string t="deepa")
        {
            this.tid = tid;
            this.tname = t;
        }


        public override string ToString()
        {
            return "name " + tname;

        }

        public virtual void Salary(int a=5,int b=10)
        {
            Console.WriteLine("hi in parent");
        }
    }

   public class PermanentTeacher:Teacher
    {

        PermanentTeacher():this(1,"a")
        {
            Console.WriteLine("def of permanent");
        }
       public  PermanentTeacher(int id,string tnm):base(id,tnm)
        {
            Console.WriteLine();
        }
        //overiding and default parameter
        public override void Salary(int a=80, int b =90)
        {
            Console.WriteLine("in child");
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Teacher t1 = new PermanentTeacher(1, "deepa");
            //Named arguments
            t1.Salary(a:45);
            int a = 10, b = 20;
            (a,b)=(b,a);
            Emp e1 = new Emp();
            e1.Eid = 101;
            e1.Ename = "deepa";


        }
    }


    //by default private
   sealed public class Emp
    {
        int eid;
        
        int sal;

        public int Eid
            {
            get { return eid; }
            set { eid = value; }
            }

        public string Ename
        {
            get;
            set;
        }
    }
}
