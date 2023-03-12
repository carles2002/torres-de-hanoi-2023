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
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b){
            //Si b está vacía
            if (b.isEmpty() == true){
                Disco aux = a.pop();
                b.push(aux);
            }
            //Si a está vacía
            if (a.isEmpty() == true){
                Disco aux = b.pop();
                a.push(aux);
            }
            //Si disco a menor que disco b ( se mueve)
            if (a.Top() < b.Top()){
                Disco aux = a.pop();
                b.push(aux);
            }
            //Si disco b menor que disco a ( se mueve)
            if (b.Top() < a.Top()){
                Disco aux = b.pop();
                a.push(aux);
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            //Sol numero de movimientos
            int sol = 0;

            //Si n(numero discos) es impar
            if(n%2 == 0){
                while(fin.Size() < n){
                    mover_disco(ini, fin);
                    sol++;
                    mover_disco(ini, aux);
                    sol++;
                    mover_disco(aux, fin);
                    sol++;

                }
                
            }else if(n%2 != 0) {
                while (fin.Size() < n){
                    mover_disco(ini, fin);
                    sol++;
                    mover_disco(ini, aux);
                    sol++;
                    mover_disco(aux, fin);
                    sol++;
                }
            }
            return sol;
        }

    }
}
