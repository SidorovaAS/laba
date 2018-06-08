using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            A NEWA = new A();
            Console.WriteLine(NEWA.C);
            Console.ReadKey();
        }
    }
    class A
    {
        private int a;
        private int b;
        private int c;


        public int C
        {
            get
            {
                a = 5;
                b = 2;
                if (a > b)
                    c = a * b;
                else c = a + b;

                return c;
            }
            set
            {
                c = value;
            }
        }

    }
}
