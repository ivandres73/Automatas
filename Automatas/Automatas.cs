using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Automatas
{
    class Automatas
    {
        public List<Automata> lista = new List<Automata>();
        Automata a;

        public bool loadList()
        {
            a = new Automata();
            a.load();
            lista.Add(a);
            return false;
        }
    }
}
