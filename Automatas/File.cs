using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Automatas
{
    class File
    {
        public BinaryWriter bw;
        public BinaryReader br;

        public File()
        {
            try
            {
                bw = new BinaryWriter(new FileStream("data", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }
            //bw.Close();
        }
    }
}
