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
        string name = "data";

        public File()
        {
            openbw(2);
        }

        public bool openbw(byte b)
        {
            FileStream f = null;
            switch (b)
            {
                case 1:
                    f = new FileStream(name, FileMode.CreateNew);
                    break;
                case 2:
                    f = new FileStream(name, FileMode.Create);
                    break;
                case 3:
                    f = new FileStream(name, FileMode.Open);
                    break;
                case 4:
                    f = new FileStream(name, FileMode.OpenOrCreate);
                    break;
                case 5:
                    f = new FileStream(name, FileMode.Truncate);
                    break;
                case 6:
                    f = new FileStream(name, FileMode.Append);
                    break;
            }
            try
            {
                bw = new BinaryWriter(f);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create/open file.");
                return false;
            }
            return true;
        }

        public bool openbr(byte b)
        {
            FileStream f = null;
            switch (b)
            {
                case 1:
                    f = new FileStream(name, FileMode.CreateNew);
                    break;
                case 2:
                    f = new FileStream(name, FileMode.Create);
                    break;
                case 3:
                    f = new FileStream(name, FileMode.Open);
                    break;
                case 4:
                    f = new FileStream(name, FileMode.OpenOrCreate);
                    break;
                case 5:
                    f = new FileStream(name, FileMode.Truncate);
                    break;
                case 6:
                    f = new FileStream(name, FileMode.Append);
                    break;
            }
            try
            {
                br = new BinaryReader(f);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read file.");
                return false;
            }
            return true;
        }

        public void cerrar()
        {
            if (bw != null)
                bw.Close();
            if (br != null)
                br.Close();
        }
    }
}
