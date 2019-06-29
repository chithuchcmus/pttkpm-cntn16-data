using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandleData
{
    public class ReadFile
    {
        public static List<String> readDataFromFile(String url)
        {
            List<String>  data = new List<string>();
            if (File.Exists(url))
            {
                // Read a text file line by line.
                string[] lines = File.ReadAllLines(url);
                foreach (string line in lines)
                    data.Add(line);
                return data;
            }
            return null;
        }
    }
}
