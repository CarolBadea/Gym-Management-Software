using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SalaDeGimnastica
{
   
    /// <summary>
    /// Provides file read and write mechanism for member class
    /// </summary>
    class ClientData
    {
        public static string[] GetClients(String path)
        {
            string[] lines = File.ReadAllLines(path);
            return lines;
        }

        public static void SaveClients(string path, string[] data)
        {
            File.WriteAllLines(path, data);
        }
    }
}


