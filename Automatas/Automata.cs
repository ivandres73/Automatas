using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatas
{
    class Automata
    {
        public String Name { get; set; }
        public int Q { get; set; }
        public char[] Sigma { get; set; }
        public int InitState { get; set; }
        public int[] FState { get; set; }
        public int[][] Delta { get; set; }

        public Automata(String name, int q, char[] sigma, int initState, int[] fState, int[][] delta)
        {
            Name = name;
            Q = q;
            Sigma = sigma;
            InitState = initState;
            FState = fState;
            Delta = delta;
        }

        public Automata(String name, int q, char[] sigma, int initState, int[] fState)
        {
            Name = name;
            Q = q;
            Sigma = sigma;
            InitState = initState;
            FState = fState;
        }

        public Automata()
        {
            Name = null;
            Q = 0;
            Sigma = null;
            InitState = 0;
            FState = null;
            Delta = null;
        }

        public void print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Q: " + Q);
            for (int i=0; i < Sigma.Length; i++)
                Console.WriteLine("Sigma[" + i + "]: " + Sigma[i]);
            Console.WriteLine("s: " + InitState);
            if (FState != null)
            {
                for (int i = 0; i < FState.Length; i++)
                    Console.WriteLine("F[" + i + "]: " + FState[i]);
            }
            Console.WriteLine("Delta: " + Delta);
        }

    }
}
