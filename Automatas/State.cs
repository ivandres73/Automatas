using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatas
{
    struct arista
    {
        public char entrada;
        public State nextState;

        public arista(char c, State s)
        {
            entrada = c;
            nextState = s;
        }
    }
    class State
    {
        public int num { get; set; }
        public List<arista> aristas;
        public bool isFinal { get; set; }

        public State()
        {
            num = 0;
            aristas = null;
            isFinal = false;
        }

        public State(int n, bool f)
        {
            num = n;
            aristas = new List<arista>();
            isFinal = f;
        }

        public void addEntrada(char ent, State sig)
        {
            arista nueva = new arista(ent, sig);
            aristas.Add(nueva);
        }

        public void printAristas()
        {
            Console.WriteLine("Las aristas de q" + num + " son:");
            foreach(arista a in aristas)
            {
                Console.WriteLine(a.entrada + "-> q" + a.nextState.num);
            }
        }
    }
}
