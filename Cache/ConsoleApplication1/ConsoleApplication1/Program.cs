using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InterSystems.Data.CacheClient;
using InterSystems.Data.CacheTypes;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a connection to Cache
            CacheConnection conn = new CacheConnection();

            // Cache server Connection Information
            // Set Server to your IP address and port to Cache SuperServer port, Log File is optional
            conn.ConnectionString = "Server = localhost; Log File=cprovider.log;Port=1972; Namespace=Samples; Password = SYS; User ID = _SYSTEM;";

            //Open a Connection to Cache
            conn.Open();

            CacheMethodSignature ms = new CacheMethodSignature();

            ms.SetReturnType(conn, ClientTypeId.tString);
            CacheObject.RunClassMethod(conn, "%SYSTEM.Version", "GetVersion", ms);

            Console.Write("ReturnValue = " + ms.ReturnValue._Value);

            conn.Close();
        }
    }
}
