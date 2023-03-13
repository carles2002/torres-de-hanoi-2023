using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        bool paso = false;
        //Constructor 
        public Hanoi(bool x) {
            paso = x;
        }

        //Mueve los discos de una pila a otra
        public void mover_disco(Pila a, Pila b){
            //Si b está vacía
            if (b.isEmpty() == true){
                
                Disco aux = a.pop();
                b.push(aux);
            }
            //Si a está vacía
            else if (a.isEmpty() == true){
             
                Disco aux = b.pop();
                a.push(aux);
            }
            //Si disco a menor que disco b ( se mueve)
            else if (a.Top() > b.Top()){
                
                Disco aux = a.pop();
                b.push(aux);
            }
            //Si disco b menor que disco a ( se mueve)
            else if (a.Top() < b.Top()){
                
                Disco aux = b.pop();
               
                a.push(aux);
            }
            else{
                Console.WriteLine("Error no se han podido mover los discos");
            }
        }

        //Obtiene el numero de movimientos hata solucinarlo modo iterativo
        public int iterativo(int n, Pila ini, Pila aux, Pila fin){

            //Sol numero de movimientos
            int sol = 0;

            //Si los pasos están activados
            if (paso==true){
                //Si n(numero discos) es impar
                if (n % 2 != 0) {

                    while (ini.isEmpty() == false || aux.isEmpty() == false) {

                        ini.mostrar3(aux, fin);

                        mover_disco(ini, fin);
                        ini.mostrar3(aux, fin);
                        sol++;
                        if (fin.Size() == n) { return sol; };


                        mover_disco(ini, aux);
                        ini.mostrar3(aux, fin);
                        sol++;
                        if (fin.Size() == n) { return sol; };

                        mover_disco(aux, fin);
                        ini.mostrar3(aux, fin);
                        sol++;
                        if (fin.Size() == n) { return sol; };
                    }

                } else if (n % 2 == 0) {
                   
                    while (ini.isEmpty() == false || aux.isEmpty() == false){

                        ini.mostrar3(aux, fin);

                        mover_disco(ini, aux);
                        ini.mostrar3(aux, fin);
                        sol++;
                        if (fin.Size() == n) { return sol; };

                        mover_disco(ini, fin);
                        ini.mostrar3(aux, fin);
                        sol++;
                        if (fin.Size() == n) { return sol; };

                        mover_disco(aux, fin);
                        ini.mostrar3(aux, fin);
                        sol++;
                        if (fin.Size() == n) { return sol; };
                    }
                }
                return sol;
            }
            else{
                if (n % 2 != 0){

                    while (ini.isEmpty() == false || aux.isEmpty() == false){

                        mover_disco(ini, fin);
                        sol++;
                        if (fin.Size() == n) { return sol; };


                        mover_disco(ini, aux);
                        sol++;
                        if (fin.Size() == n) { return sol; };

                        mover_disco(aux, fin);
                        sol++;
                        if (fin.Size() == n) { return sol; };
                    }

                }
                else if (n % 2 == 0){
                    while (ini.isEmpty() == false || aux.isEmpty() == false){
 
                        mover_disco(ini, aux);
                        sol++;
                        if (fin.Size() == n) { return sol; };

                        mover_disco(ini, fin);
                        sol++;
                        if (fin.Size() == n) { return sol; };

                        mover_disco(aux, fin);
                        sol++;
                        if (fin.Size() == n) { return sol; };
                    }
                }
                return sol;
            }
          
        }
        //Obtiene el numero de movimientos hata solucinarlo modo recursivo
        public int recursivo(int n, Pila ini, Pila aux, Pila fin){
            int sol=0;
            if (n == 1){
                mover_disco(ini, fin);
                sol++;
                if (fin.Size() == n) { return sol; };
            }
            else{
                sol += recursivo(n - 1, ini, aux, fin);
                mover_disco(ini, fin);
                sol++;
                if (fin.Size() == n) { return sol; };
                sol += recursivo(n - 1, aux, fin, ini);
            }
                return sol; 
        }
    }
}
