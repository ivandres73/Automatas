using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatas
{
    class StatesDiagram
    {
        List<State> nuevos;

        public StatesDiagram()
        {
            ;
        }

        public void createStates(Automata a)
        {
            nuevos = new List<State>();
            State nuevo;
            for (byte i=0; i < a.Q; i++)
            {
                nuevo = new State(i, false);
                nuevos.Add(nuevo);
            }

            for (byte i=0; i < a.Q; i++)
            {
                for(byte v=1; v <= a.Sigma.Length; v++)
                {
                    int sigEstado = a.Delta[i, v];
                    char entrada = a.Sigma[v-1];
                    nuevos[i].addEntrada(entrada, nuevos[sigEstado]);
                }
            }

            foreach (int i in a.FState)
            {
                nuevos[i].isFinal = true;
            }
        }

        public void printDiagram()
        {
            if (nuevos == null)
            {
                Console.WriteLine("diagrama vacio...");
                return;
            }
            
            foreach(State s in nuevos)
            {
                s.printAristas();
            }
        }

        public bool evualateWord(String s, char[] sigma)
        {
            bool flag = false;
            State last = nuevos.First<State>();
            foreach (char c in s)
            {
                for (byte i = 0; i < sigma.Length; i++)
                {
                    if (c == sigma[i])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("word is not part of language cause of: " + c);
                    return false;
                }
                foreach (arista a in last.aristas)
                {
                    if (a.entrada == c)
                    {
                        last = a.nextState;
                        Console.WriteLine("con " + c + " me movi a q" + last.num);
                        break;
                    }
                }
            }
            return last.isFinal;
        }

        public void tranformForElimination(int[] fs)
        {
            State inicial = nuevos.First<State>();
            State nuevo_final = null;
            bool salirSiEntrada = false;
            foreach (State s in nuevos)
            {
                foreach (arista a in s.aristas)
                {
                    if (a.nextState.num == inicial.num)
                    {
                        State nuevoInicial = new State(-1, false);
                        nuevoInicial.addEntrada('\0', inicial);
                        nuevos.Insert(0, nuevoInicial);
                        salirSiEntrada = true;
                        break;
                    }
                }
                if (salirSiEntrada)
                    break;
            }
            for (byte i=0; i < nuevos.Count; i++)
            {
                if (nuevos[i].isFinal && nuevos[i] != nuevo_final)
                {
                    if (nuevo_final == null)
                    {
                        nuevo_final = new State(-2, true);
                        nuevos.Add(nuevo_final);
                    }
                    nuevos[i].addEntrada('\0', nuevo_final);
                    nuevos[i].isFinal = false;
                }
            }
            printDiagram();
        }
    }
}
