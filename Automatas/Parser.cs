using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatas
{
    class Parser
    {
        public static int[] StrToIntArray(String text)
        {
            String nuevo = "";
            for (int i=0; i < text.Length; i++)
            {
                if (text[i] == ',' || text[i] == ' ')
                {
                    continue;
                }
                nuevo += text[i];
            }
            int[] arreglo = new int[nuevo.Length];
            for (int i=0; i < nuevo.Length; i++)
            {
                if (nuevo[i] < 48 || nuevo[i] > 57)
                {
                    FormatException OnlyDigitsException = new FormatException();
                    throw OnlyDigitsException;
                }
                arreglo[i] = nuevo[i] - '0';
            }

            return arreglo;
        }

        public static char[] StrToCharArray(String text)
        {
            String nuevo = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ',' || text[i] == ' ')
                {
                    continue;
                }
                nuevo += text[i];
            }
            char[] arreglo = new char[nuevo.Length];
            for (int i = 0; i < nuevo.Length; i++)
            {
                arreglo[i] = nuevo[i];
            }

            return arreglo;
        }

        public static String removeDuplicates(String original)
        {
            String nuevo = original;
            for (int c=0; c < original.Length; c++)
            {
                for (int i=original.Length-1; i >= 0; i--)
                {
                    if (original[i] == original[c] && i != c)
                    {
                        nuevo = "";
                        for (int v=0; v < original.Length; v++)
                        {
                            if (v == c-1 || v == c)
                            {
                                continue;
                            }
                            nuevo += original[v];
                        }
                        break;
                    }
                }
            }
            return nuevo;
        }
    }
}
