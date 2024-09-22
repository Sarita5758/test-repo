using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarita.Lab2
{
    class question6
    {
        int a, b;
        public question6()
        {
            a = 200;
            b = 300;
            Console.WriteLine("This is Default Constructor");
        }

        //parameterized constructor
        public question6(int x, int y)
        {
            a = x;
            b = y;
        }

        public question6(question6 cd)
        {
            a = cd.a;
            b = cd.b;
        }

        static question6()
        {
            Console.WriteLine("This is static constructor");
        }
        /*static void Main(string[] args)
        {
            //default
            question6 demo = new question6();
            Console.WriteLine(demo.a);
            Console.WriteLine(demo.b);

            //parameterized
            question6 cdemo = new question6(450, 120);
            Console.WriteLine(cdemo.a);
            Console.WriteLine(cdemo.b);
            //copy 
            question6 cpdemo = new question6(cdemo);
            Console.WriteLine(cpdemo.a);
            Console.WriteLine(cpdemo.b);

            Console.WriteLine("This is demo for constructor");
            Console.ReadKey();
            Console.Read();
        }*/
    }
}
