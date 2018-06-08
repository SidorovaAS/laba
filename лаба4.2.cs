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
            Console.WriteLine("Значение поля a=" + NEWA.a);
            Console.WriteLine("Значение поля b=" + NEWA.b);
            Console.WriteLine("Значение свойства С=" + NEWA.C);
            Console.WriteLine();

            B NEWB = new B();
            Console.WriteLine("Значение поля a=" + NEWA.a);
            Console.WriteLine("Значение поля b=" + NEWA.b);
            Console.WriteLine("Значение поля d=" + NEWB.d);
            Console.WriteLine("Значение свойства c2=" + NEWB.c2);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    class A
    {
        public readonly int a = 5;
        public readonly int b = 2;
        public int c;

        public int C
        {
            get
            {
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
        public A()
        { }
        public A(int a, int b)
        { }

    }

    class B : A
    {
        public int d = 10;
        public int c2
        {
            get
            {
                return a - b + d;
            }
            set
            {
                c2 = value;
            }
        }

        public B(int a, int b, int d) : base(a, b)
        {
        }
        public B()
        { }
    }
}
