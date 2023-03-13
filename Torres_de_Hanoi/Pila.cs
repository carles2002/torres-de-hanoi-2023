using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {

        public List<Disco> Discos = new List<Disco>();

        //Devuelve el tamaño de la pila
        public int Size(){
            int sol = Discos.Count();
            //Console.WriteLine("Tamaño Size"+sol);
            return sol;
        }

        //Devuelve el valor del disco que está arriba del todo
        public int Top()
        {
            if (this.Size() == 0) { 
                return 0;
            }
            else{
                return Discos.ElementAt(this.Size()-1).getValor();

            }
        }

        //Crea una pila con X discos (ini)
        public Pila(int tam){
            for (int i=0; i<tam; i++){
                this.Discos.Add(new Disco(i));  
            }
        }

        //Constructor de Pilas vacías (Aux, fin)
        public Pila(){
        }

        //Pone un disco dentro de una pila
        public void push(Disco d){
            this.Discos.Add(d);
        }

        //Quita un disco de la pila y lo devuelve
        public Disco pop(){
            
            Disco d1 = this.Discos[Size()-1];
            this.Discos.RemoveAt(Size() - 1);
            return d1;
        }                

        //Devuelve true si la pila está vacía y vincerversa
        public bool isEmpty(){
            if (this.Size()==0){
                return true;
            }
            return false;
        }

        //Muestra los elementos de una pila
        public void mostrar(String pila){
           Console.WriteLine("Los discos de la pila " + pila + " son:");
            for (int i = this.Size() - 1; i >= 0; i--){
                Console.WriteLine(Discos[i].getValor());
            }
        }

        //Muestra la situación de las 3 pilas
        public void mostrar3(Pila a, Pila f)
        {
            Console.WriteLine("Los objetos de las pilas son:");
            Console.WriteLine("INI");
            for (int i = 0; i <= this.Size()-1; i++)
            {
                for (int j = this.Discos[i].getValor(); j >= 0; j--)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            Console.WriteLine("AUX");
            for (int i = 0; i <= a.Size()-1; i++)
            {
                for (int j = a.Discos[i].getValor(); j >= 0; j--)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            Console.WriteLine("FIN");
            for (int i = 0; i <= f.Size()-1; i++)
            {
                for (int j = f.Discos[i].getValor(); j >= 0; j--)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }


    }
}
