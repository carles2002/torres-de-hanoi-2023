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
            bool paso = false;
            Console.WriteLine("Bienvenido al juego de las torres de Hanoi");
            Console.WriteLine("¿Con cuantos discos quieres jugar?");
            int discos= int.Parse(Console.ReadLine());
            Console.WriteLine("Vas a jugar con " + discos + " discos");

            Console.WriteLine("Quieres jugar en modo iterativo o recursivo i/r");

            if (Console.ReadLine()=="i"){
                Console.WriteLine("Vas a jugar en el modo iterativo con "+discos+" discos");
                Console.WriteLine("¿Quieres activar el modo paso a paso? Se recomienda desactivar para discos mayores de 9 y/n");
                if (Console.ReadLine() == "y"){
                    paso = true;
                }else if (Console.ReadLine() == "n"){
                    paso = false;
                }

                Pila INI = new Pila(discos);
                Pila AUX = new Pila();
                Pila FIN = new Pila();

                Hanoi Hanoi = new Hanoi(paso);

                int sol = Hanoi.iterativo(discos, INI, AUX, FIN);
                Console.WriteLine("Los movimientos necesarios han sido: " + sol);

            }
            else if (Console.ReadLine() == "r"){
                Console.WriteLine("Aún no implementado");
            }

           

            // Keep the console window open in debug mode.
            Console.ReadKey();
        }
    }
}
