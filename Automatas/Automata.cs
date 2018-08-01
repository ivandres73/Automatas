using System;
using System.Collections.Generic;
using System.IO;
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
        private File archivo;

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

        public bool save()
        {
            archivo = new File();
            archivo.openbw(2);
            try
            {
                archivo.bw.Write(Name);
                archivo.bw.Write(';');
                archivo.bw.Write(Q);
                archivo.bw.Write(Sigma);
                archivo.bw.Write(';');
                archivo.bw.Write(InitState);
                archivo.bw.Write(FState.Length);
                for (short i = 0; i < FState.Length; i++)
                {
                    archivo.bw.Write(FState[i]);
                }
                archivo.bw.Write("Delta");
                archivo.bw.Write('.');//. separa automatas, ; separa atributos de automatas
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Error saving Automaton to file.");
                return false;
            }
            archivo.cerrar();
            return true;
        }

        public bool load()
        {
            archivo = new File();
            archivo.openbr(3);
            try
            {
                char n = '\0';
                string nombre = "";
                int i;
                do
                {
                    nombre += n;
                    n = archivo.br.ReadChar();
                } while (n != ';');
                Name = nombre;
                Q = archivo.br.ReadInt32();
                nombre = "";
                n = '\0';
                do
                {
                    nombre += n;
                    n = archivo.br.ReadChar();
                } while (n != ';');
                Sigma = Parser.StrToCharArray(nombre);
                InitState = archivo.br.ReadInt32();
                i = archivo.br.ReadInt32();
                FState = new int[i];
                for (i=0; i < FState.Length; i++)
                {
                    FState[i] = archivo.br.ReadInt32();
                }
                n = '\0';
                do
                {
                    n = archivo.br.ReadChar();
                } while (n != '.');
            } catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n error loading automaton from file.");
            }
            Console.WriteLine(Name + " loaded correctly !");
            archivo.cerrar();
            return true;
        }

    }
}
