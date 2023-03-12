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
        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        /* TODO: Implementar métodos */

        public List<Disco> Discos = new List<Disco>();

        //Devuelve el tamaño de la pila
        public int Size(){
            int sol = Discos.Count;
            return sol;
        }

        //Devuelve el valor del disco que está arriba del todo
        public int Top()
        {
            return Discos.ElementAt(Size()-1).getValor();
        }

        //Crea una pila con X discos
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


        public Disco pop(){
            Disco d1 = new Disco(Top());
            this.Discos.RemoveAt(Top());
            return d1;
        }                

        public bool isEmpty(){
            if (Size()==0){
                return true;
            }
            return false;
        }

        //Muestra los elementos de la pila
        public void mostrar(String pila){
           Console.WriteLine("Los objetos de la pila " + pila + " son:");
            for (int i = this.Size() - 1; i >= 0; i--){
                Console.WriteLine(Discos[i].getValor());
            }
        }

    }
}
