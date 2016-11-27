using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AngularSandbox
{
    class Program
    {
        static string wwwDir = @"C:\Users\Guido\Source\Repos\AngularSandbox\AngularSandbox\www";

        static void Main(string[] args)
        {
            SimpleWebServer ws = new SimpleWebServer(SendResponse, "http://localhost:8088/");
            ws.Run();
            Console.WriteLine("A simple webserver. Press a key to quit.");
            Console.ReadKey();
            ws.Stop();
        }

        public static string SendResponse(HttpListenerRequest request)
        {
            string requestedFile = wwwDir + request.RawUrl.Replace("/", @"\");
            if (File.Exists(requestedFile))
            {
                return File.ReadAllText(requestedFile, Encoding.UTF8);
            }
            else
            {
                requestedFile = Path.Combine(requestedFile, "index.html");
                if (File.Exists(requestedFile))
                {
                    return File.ReadAllText(requestedFile, Encoding.UTF8);
                }
            }
            return string.Format("<HTML><BODY>Requested file not found: {0}.<br>{1}</BODY></HTML>", request.RawUrl, DateTime.Now);
        }
    }
}
