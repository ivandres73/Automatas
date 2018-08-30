using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatas
{
    class StatesDiagram
    {
        List<State> nuevos;
        List<State> NFA;

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
                    String entrada = a.Sigma[v-1].ToString();
                    nuevos[i].addEntrada(entrada, nuevos[sigEstado]);
                }
            }

            foreach (int i in a.FState)
            {
                nuevos[i].isFinal = true;
            }
        }

        public DataTable createNFA(DataTable dt, char[] entries)
        {
            DataTable tablaNFA = new DataTable();

            var c_epsilon = new DataColumn();
            c_epsilon.DataType = typeof(String);
            c_epsilon.ColumnName = "cE(q)";
            tablaNFA.Columns.Add(c_epsilon);

            foreach (char c in entries)
            {
                var col = new DataColumn();
                col.DataType = typeof(String);
                col.ColumnName = "d(cE(q),"+c+")";
                tablaNFA.Columns.Add(col);
            }

            String valor;
            int actual = 0;
            foreach (DataRow dr in dt.Rows)
            {
                valor = "";
                for (byte i=0; i < dr.ItemArray.Length; i++)
                {
                    if (i == 0)
                    {
                        valor += dr.ItemArray[i];
                        valor = valor.TrimStart('q');
                    }
                    if (i == dr.ItemArray.Length - 1)
                    {
                        if (dr.ItemArray[i].ToString() != "")
                        {
                            valor += "," + dr.ItemArray[i];
                        }
                    }
                }
                valor = Parser.removeDuplicates(valor);
                Console.WriteLine("uniendo " + dr.ItemArray[0] + " y epislon: " + valor);
                DataRow nueva_row = tablaNFA.NewRow();
                nueva_row.ItemArray[0] = valor;
                tablaNFA.Rows.Add(nueva_row);
                tablaNFA.Rows[actual++][0] = valor;
            }

            valor = "";
            foreach(DataRow dr in tablaNFA.Rows)
            {
                int[] estados_actuales;
                estados_actuales = Parser.StrToIntArray(dr.ItemArray[0].ToString());
                valor = "";

                for (int a = 1; a < tablaNFA.Columns.Count; a++)
                {
                    valor = "";
                    foreach (int i in estados_actuales)
                    {
                        valor += dt.Rows[i].ItemArray[a] + ",";
                    }
                    valor = valor.TrimEnd(',');
                    valor = Parser.removeDuplicates(valor);
                    dr[a] = valor;
                }
            }

            foreach (char c in entries)
            {
                var col = new DataColumn();
                col.DataType = typeof(String);
                col.ColumnName = "cE(d(cE(q)," + c + "))";
                tablaNFA.Columns.Add(col);
            }

            foreach (DataRow dr in tablaNFA.Rows)
            {
                int[] estados_actuales;
                for (byte i = 1; i < entries.Length+1; i++)
                {
                    valor = "";
                    estados_actuales = Parser.StrToIntArray(dr.ItemArray[i].ToString());
                    foreach (int v in estados_actuales)
                    {
                        valor += tablaNFA.Rows[v].ItemArray[0] + ",";
                    }
                    valor = valor.TrimEnd(',');
                    Console.WriteLine("Iteracion #" + i);
                    Console.WriteLine("lo qe tiene valor= " + valor);
                    valor = Parser.removeDuplicates(valor);
                    Console.WriteLine("lo qe tiene valor sin duplicados= " + valor);
                    dr[i + entries.Length] = valor;
                }
            }

            return tablaNFA;
            
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
                    if (a.entrada[0] == c)
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
                unifyAristas(s);
            foreach (State s in nuevos)
            {
                foreach (arista a in s.aristas)
                {
                    if (a.nextState.num == inicial.num)
                    {
                        State nuevoInicial = new State(-1, false);
                        nuevoInicial.addEntrada("", inicial);
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
                    nuevos[i].addEntrada("", nuevo_final);
                    nuevos[i].isFinal = false;
                }
            }
            foreach (State s in nuevos)
                unifyAristas(s);
            printDiagram();
        }

        public String statesElimination()
        {
            foreach (State s in nuevos)
                unifyAristas(s);
            String er = "";
            int[] arreglo = new int[nuevos.Count - 2];
            int conta = 0;
            while (nuevos.Count > 2)
            {
                conta = 0;
                foreach (State s in nuevos)
                {
                    if (s == nuevos[1])
                        continue;
                    foreach (arista a in s.aristas)
                    {
                        if (a.nextState == nuevos[1])
                        {
                            arreglo[conta++] = nuevos.IndexOf(s);
                            break;
                        }
                    }
                }
                for (byte a = 0; a < arreglo.Length; a++)
                {
                    for (byte i = 0; i < nuevos[arreglo[a]].aristas.Count; i++)
                    {
                        if (nuevos[arreglo[a]].aristas[i].nextState.isFinal)
                            continue;

                        if (nuevos[arreglo[a]].aristas[i].nextState == nuevos[1])
                        {
                            eliminate(nuevos[arreglo[a]], nuevos[1]);
                            Console.WriteLine("loop de aristas");
                        }
                        if (nuevos.Count < 2)
                            break;
                    }
                }
                nuevos.Remove(nuevos[1]);
            }
            for (byte i=0; i < nuevos[0].aristas.Count; i++) {
                er += "(" + nuevos[0].aristas[i].entrada + ")";
                if (i != nuevos[0].aristas.Count-1)
                    er += " + ";
            }
            return er;
        }

        private void eliminate(State entry, State s)
        {
            unifyAristas(s);
            String prologue = null;
            foreach (arista a in entry.aristas)
            {
                if (a.nextState == s)
                {
                    prologue = a.entrada;
                    foreach (arista ar in s.aristas)
                    {
                        if (ar.nextState == s)
                        {
                            prologue += (ar.entrada.Length == 1) ? ar.entrada + "*" : "(" + ar.entrada + ")*";
                            entry.aristas.Remove(a);
                            break;
                        }
                    }
                    break;
                }
            }
            String input = null;
            Console.WriteLine("Para q" + entry.num + ":");
            foreach (arista a in s.aristas)
            {
                if (a.nextState == s)
                    continue;
                input = prologue + a.entrada;
                entry.addEntrada(input, a.nextState);
                Console.WriteLine(input + "->" + a.nextState.num);
            }
        }

        private void unifyAristas(State s)
        {
            String nuevaEntrada = "";
            bool flag = true;
            bool help = false;
            foreach (arista a in s.aristas)
            {
                if (a.nextState == s)
                {
                    if (a.entrada.Contains("+"))
                    {
                        flag = false;
                    }
                    nuevaEntrada += (flag) ? a.entrada + "+" : "(" + a.entrada + ")" + "+";
                    help = true;
                }
            }
            if (help)
            {
                nuevaEntrada = nuevaEntrada.TrimEnd('+');
                while (s.deleteEntradaWith(s))
                {
                    ;
                }
                s.addEntrada(nuevaEntrada, s);
            }
        }
    }
}
