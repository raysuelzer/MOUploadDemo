using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushroomObserver.ConsoleApp
{
    public class FileLogger : ILogger
    {
       
        private string FilePath { get; }
        public FileLogger(string logPath)
        {
            FilePath = logPath;
        }
       
        public void Log(string text)
        {
            Console.WriteLine(text);
        }

        public void LogError(string text)
        {
            using (StreamWriter w = File.AppendText(FilePath))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                w.WriteLine("  :");
                w.WriteLine("  :{0}", text);
                w.WriteLine("-------------------------------");
            }
            Console.WriteLine(text);
        }
    }
}
