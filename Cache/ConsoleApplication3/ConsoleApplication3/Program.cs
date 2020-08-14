using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterSystems.XEP;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            EventPersister ep = PersisterFactory.CreatePersister();

            ep.Connect("USER", "_SYSTEM", "SYS");
            //ep.Connect("localhost",1972,"USER", "_SYSTEM", "SYS");

            Object returnvalue = ep.CallClassMethod("%SYSTEM.Version", "GetVersion");
            Console.Write("ReturnValue = " + returnvalue.ToString());

            ep.Close();
        }
    }
}
