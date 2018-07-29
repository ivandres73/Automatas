using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatas
{
    class Parser
    {
        public static int[] StrToArray(String text)
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
            Console.WriteLine(nuevo + "tamano" + nuevo.Length);
            int[] arreglo = new int[nuevo.Length];
            for (int i=0; i < nuevo.Length; i++)
            {
                arreglo[i] = nuevo[i] - '0';
            }

            return arreglo;
        }
    }
}
