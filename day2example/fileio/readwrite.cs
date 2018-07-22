using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileio
{
    class readwrite
    {
        public void WriteFile(string fname)
          
        {
            StreamWriter write = new StreamWriter(fname,true);
            try
            {
                StreamWriter write = new StreamWriter(fname);
                Console.WriteLine("ent th data to b wriiten to the file");
                string data = Console.ReadLine();
                write.WriteLine(data);
                Console.WriteLine("data writte to the file");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            finally
            {
                write.Close();

            }


        }
        public void ReadFile(string fname)
        {
            StreamReader read = new StreamReader(fname);
            try
            {
                string data = read.ReadToEnd();
                Console.WriteLine("data read into file");

            }

            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            finally
            {
                read.Close();

            }

        }
    
    }
}
