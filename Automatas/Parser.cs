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
    }
}
