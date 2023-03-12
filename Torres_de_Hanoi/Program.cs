using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Bienvenido al juego de las torres de Hanoi");
            Console.WriteLine("¿Con cuantos discos quieres jugar?");
            int discos= int.Parse(Console.ReadLine());
            Console.WriteLine("Vas a jugar con " + discos + " discos");

            Pila INI = new Pila(discos);
            Pila AUX = new Pila();
            Pila FIN = new Pila();
            Console.WriteLine("INI TOP FORA ITERAT " + INI.Top());

            Console.WriteLine("AUX TOP FORA ITERAT "+ AUX.Top());

            Console.WriteLine("FIN TOP FORA ITERAT " + FIN.Top());

            Hanoi Hanoi= new Hanoi();

            Console.WriteLine(discos);

            /*Disco d =INI.pop();
            Console.WriteLine("Eliminado top con pop" + INI.Top());
            Console.WriteLine("Disco poped" + d.getValor()) ;*/

            int sol = Hanoi.iterativo(discos, INI, AUX, FIN);

            Console.WriteLine("Los movimientos necesarios han sido: "+ sol);

            // Keep the console window open in debug mode.
            Console.ReadKey();
        }
    }
}
