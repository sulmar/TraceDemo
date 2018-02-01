using System.Diagnostics;
using System.Net;

namespace TraceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TraceTest();

           // WebClientTest();
        }

        private static void TraceTest()
        {
            Trace.TraceInformation("Information Hello");
            Trace.TraceWarning("Warning Hello");
            Trace.TraceError("Error Hello");
        }

        private static void WebClientTest()
        {
            var webClient = new WebClient();
            webClient.DownloadString("http://somehost/nosuchfile.txt");
        }
    }
}
