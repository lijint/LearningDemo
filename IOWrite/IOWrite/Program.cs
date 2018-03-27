using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IOWrite
{
    class Program
    {
        private const string FILE_NAME = "test.txt";
        static void Main(string[] args)
        {
            using (StreamWriter w = File.AppendText("test.txt"))
            {
                Log("heihei", w);
                Log("hello world", w);
                w.Close();
            }
        }

        private static void Log(string logMessage,TextWriter w)
        {
            w.Write("\r\nLog Entry");
            w.WriteLine(" : {0}", logMessage);
            w.Flush();
        }
    }
}
