using System;
using System.IO;
using System.Web;
using System.Web.Hosting;

namespace AngularSandbox
{
    class AspNet : MarshalByRefObject
    {
        public override object InitializeLifetimeService()
        {
            return null;
        }
        internal void ProcessRequest(string page, string queryString, Stream output)
        {
            // StreamWriter für den ausgabe-strom
            StreamWriter writer = new StreamWriter(output);

            // SimpleWorkerRequest mit relevanten informationen erzeugen
            SimpleWorkerRequest wr = new SimpleWorkerRequest(page, queryString, writer);
            //SimpleWorkerRequest wr = new SimpleWorkerRequest(page, queryString, Console.Out);

            Console.WriteLine(HttpRuntime.UsingIntegratedPipeline);
            // request an HTTP runtime übergeben
            HttpRuntime.ProcessRequest(wr);

            writer.Close();
        }
    }
}
