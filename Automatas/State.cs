using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatas
{
    struct arista
    {
        public String entrada;
        public State nextState;

        public arista(String c, State s)
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

        public void addEntrada(String ent, State sig)
        {
            arista nueva = new arista(ent, sig);
            aristas.Add(nueva);
        }

        public bool deleteEntradaWith(State s)
        {
            arista eliminar = new arista("e", s);
            int pos = 0;
            foreach (arista a in aristas)
            {
                if (a.nextState == s)
                    break;
                pos++;
            }
            if (pos == aristas.Count)
                return false;
            aristas.RemoveAt(pos);
            return true;
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
