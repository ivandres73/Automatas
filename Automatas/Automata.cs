using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Automatas
{
    class Automata
    {
        public String Name { get; set; }
        public int Q { get; set; }
        public char[] Sigma { get; set; }
        public int InitState { get; set; }
        public int[] FState { get; set; }
        public int[,] Delta { get; set; }
        private File archivo;

        public Automata(String name, int q, char[] sigma, int initState, int[] fState, int[,] delta)
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
            Delta = new int[Q, Sigma.Length + 1];
            for (int i = 0; i < Q; i++)
                Delta[i, 0] = i;
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
            Console.Write("Sigma: { ");
            for (int i=0; i < Sigma.Length; i++)
                Console.Write((i == Sigma.Length-1) ? Sigma[i]+"" : Sigma[i]+", ");
            Console.WriteLine(" }");
            Console.WriteLine("s: " + InitState);
            if (FState != null)
            {
                for (int i = 0; i < FState.Length; i++)
                    Console.WriteLine("F[" + i + "]: " + FState[i]);
            }

            if (Delta != null)
            {
                for (int i = 0; i < Delta.GetLength(0); i++)
                {
                    Console.Write("q" + Delta[i, 0] + "->");
                    for (int v = 1; v < Delta.GetLength(1); v++)
                    {
                        Console.Write(" " + Sigma[v - 1] + ":" + Delta[i, v]);
                    }
                    Console.Write('\n');
                }
            }
        }

        public bool save()
        {
            archivo = new File();
            archivo.openbw(2);
            try
            {
                archivo.bw.Write((byte)Name.Length);//tamano del nombre
                archivo.bw.Write(Name);
                archivo.bw.Write(Q);
                archivo.bw.Write((byte)Sigma.Length);//tamano del alfabeto
                archivo.bw.Write(Sigma);
                archivo.bw.Write(InitState);
                archivo.bw.Write((byte)FState.Length);//tamano de los estados finales
                for (short i = 0; i < FState.Length; i++)
                {
                    archivo.bw.Write(FState[i]);
                }
                archivo.bw.Write((byte)Delta.GetLength(0));
                archivo.bw.Write((byte)Delta.GetLength(1));
                for (short i=0; i < Delta.GetLength(0); i++)
                {
                    for (short v=0; v < Delta.GetLength(1); v++)
                    {
                        archivo.bw.Write(Delta[i, v]);
                    }
                }
                archivo.bw.Write('.');//. separador de automatas
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
                Name = "";
                byte i = archivo.br.ReadByte();
                for(byte v=0; v <= i; v++)
                {
                    Name += archivo.br.ReadChar();
                }
                Q = archivo.br.ReadInt32();
                i = archivo.br.ReadByte();
                string temp = "";
                for (byte v=0; v < i; v++)
                {
                    temp += archivo.br.ReadChar();
                }
                Sigma = Parser.StrToCharArray(temp);
                InitState = archivo.br.ReadInt32();
                i = archivo.br.ReadByte();
                FState = new int[i];
                for (i=0; i < FState.Length; i++)
                {
                    FState[i] = archivo.br.ReadInt32();
                }
                do
                {
                    //Delta goes here
                } while (archivo.br.ReadChar() != '.');
            } catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n error loading automaton from file.");
            }
            Console.WriteLine(Name + " loaded correctly !");
            archivo.cerrar();
            return true;
        }

        public DataTable getTableFromDelta()
        {
            DataTable dt = new DataTable();

            var columnSpec = new DataColumn();
            columnSpec.DataType = typeof(String);
            columnSpec.ColumnName = "States";
            columnSpec.ReadOnly = true;
            dt.Columns.Add(columnSpec);

            foreach (char c in Sigma)
            {
                var ColumnEntry = new DataColumn();
                ColumnEntry.DataType = typeof(int);
                ColumnEntry.ColumnName = c.ToString();
                dt.Columns.Add(ColumnEntry);
            }

            DataRow dr;

            for (byte i = 0; i < Q; i++)
            {
                dr = dt.NewRow();
                dr["States"] = "q" + i;
                dt.Rows.Add(dr);
            }

            return dt;
        }

        public void setDeltaFromTable(DataTable dt)
        {
            Delta = new int[Q, Sigma.Length+1];
            for (int i = 0; i < Q; i++)
                Delta[i, 0] = i;

            for (int i=0; i < Q; i++)
            {
                for (int v=1; v <= Sigma.Length; v++)
                {
                    if (dt.Rows[i].ItemArray[v].ToString() == "")
                        continue;
                    else
                        Delta[i, v] = int.Parse(dt.Rows[i].ItemArray[v].ToString());
                }
            }
        }

    }
}
