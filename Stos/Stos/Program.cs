using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stos
{
    class Program
    {
        static void Main(string[] args)
        {
            //IStos<string> s = new StosWTablicy<string>(2);
            //s.Push("km");
            //s.Push("aa");
            //s.Push("xx");
            //foreach (var x in s.ToArray())
            //    Console.WriteLine(x);
            //Console.WriteLine();

            //foreach (var item in ((StosWTablicy<string>)s).TopToBottom)
            //    Console.WriteLine(item);
            //Console.WriteLine();

            IStos<int> stos = new StosWTablicy<int>(2);
            stos.Push(1);
            stos.Push(2);
            stos.Push(3);

            foreach (var item in stos.ToArray())
                Console.WriteLine(item);

            Console.WriteLine();

            foreach (var item in ((StosWTablicy<int>)stos).ToArrayReadOnly())
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
