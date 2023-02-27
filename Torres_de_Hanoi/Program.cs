using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Disco d1 = new Disco(1);

            Console.WriteLine(d1.getValor());

            Pila p1 = new Pila(3);
            Console.WriteLine("Tam"+p1.Size());
            Console.WriteLine("Top"+p1.Top());
            Disco d2= p1.pop();
            Console.WriteLine("menosh saber"+d2.getValor());
            Console.WriteLine("NewTam" + p1.Size());
            Console.WriteLine("isEmpty" + p1.isEmpty());
            Pila p2 = new Pila(0);
            Console.WriteLine("isEmpty" + p2.isEmpty());



            // Keep the console window open in debug mode.
            Console.ReadKey();
        }
    }
}
