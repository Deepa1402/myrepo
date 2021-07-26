using System;

//https://zetcode.com/lang/csharp/oopi/

namespace App1
{
    
    class Program
    {

        readonly int i;
        const int j = 90;
        static  Program()
        {

        }


       static void M(ref int x)
        {
            x++;
        }
        public Program()
        {
           
            i = 90;
        }
       static public void Main(string[] s)
        {
            int r= 90;
            M(ref r);
            var m = 90;
            dynamic n = "sdf";
            Console.WriteLine("hiiiiiiiiiiiiiiiiiiiii");
            Emp e1 = new Emp(101);
            Console.WriteLine(e1);

            Console.ReadLine();
            var p = new Person();
            p.Name = "Jane";

            Console.WriteLine(p.Name);

        }
    }

    class Program2
    {
        void main()
        {


            //cw tab
            Console.WriteLine("Hello World!");
            int x = 10;
            Console.WriteLine("{0} {1}", int.MaxValue, int.MinValue);
            const float pi = 6.7f;
            string s = "12";
            x = int.Parse(s);
            x = Convert.ToInt32(x);
            Mylib.A.greet();

            Console.WriteLine("enter percent");
            int a = int.Parse(Console.ReadLine());
            if (a > 75)
                Console.WriteLine("Distinction");
            else if (a >= 60)
                Console.WriteLine("FC");
            else
                Console.WriteLine("Fail");



        }
    }
        public class Emp
        {
            public int eid;
            public string ename;


        public override string ToString()
        {
            return "This is Being class";
        }
        public Emp()
            {
                eid = 101;
                ename = "deepa";
            }

            public Emp(int i):this()
            {
            Console.WriteLine("hi in para");
        }
        }


    class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    class Person1
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
