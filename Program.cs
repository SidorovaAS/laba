using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidorova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите информацию о печатном издании");
            Newspaper s = new Pech();
            Console.WriteLine("Введите информацию о газете");
            Newspaper r = new Newspaper();
            Console.WriteLine("Введите информацию о книге");
            Newspaper i = new Book();
            Console.WriteLine(s.printAll());
            Console.WriteLine(r.printAll());
            Console.WriteLine(i.printAll());
            Console.ReadKey();
        }
    }

    public class Newspaper
    {
        protected string name;
        protected int date;
        public Newspaper()
        {
            Console.Write("Название: ");
            this.name = Console.ReadLine();
            Console.Write("Дата: ");
            this.date = Convert.ToInt32(Console.ReadLine());
        }

        public virtual string getInfo()
        {
            return string.Format("  Название: {0}\n  Дата: {1}", name, date);
        }
        public virtual string printAll()
        {
            return "Газета:\n" + this.getInfo();
        }
    }
    public class Pech : Newspaper
    {
        protected int readers;
        public Pech()
        {
            Console.Write("Читатели: ");
            this.readers = Convert.ToInt32(Console.ReadLine());
        }

        public override string getInfo()
        {
            return string.Format("{0}\n  Читатели: {1}", base.getInfo(), readers);
        }
        public override string printAll()
        {
            return "Печатное издание:\n" + this.getInfo();
        }
    }
    public class Book : Pech
    {
        protected string ceh;
        public Book()
        {
            Console.Write("Завод: ");
            this.ceh = Console.ReadLine();
        }
        public override string getInfo()
        {
            return string.Format("{0}\n  Завод: {1}", base.getInfo(), zavod);
        }
        public override string printAll()
        {
            return "Книга:\n" + this.getInfo();
        }
    }
    public class Ingener : Pech
    {
        protected string spec;
        public Ingener()
        {
            Console.Write("Специальность: ");
            this.spec = Console.ReadLine();
        }
        public override string getInfo()
        {
            return string.Format("{0}\n  Специальность: {1}", base.getInfo(), spec);
        }
        public override string printAll()
        {
            return "Периодика:\n" + this.getInfo();
        }
    }



}
