using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.DBresourse
{
    public class ExceptionLogging
    {
        public static void logWrite(string method, string ERmess, string StackTrace)
        {
            File.AppendAllText("log.txt", DateTime.Now + " - " + method + "\r\n" + ERmess + "\r\n" + StackTrace + "\r\n");
        }
    }
}
