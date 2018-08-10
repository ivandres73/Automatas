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
    }
}
