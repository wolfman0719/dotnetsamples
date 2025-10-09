using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using InterSystems.Data.IRISClient;
using InterSystems.Data.IRISClient.ADO;

    class sendJSON
   { 
       static void Main(string[] args)
       {
           JsonObject jso = new JsonObject();
           jso.Add("Grade",1);
           jso.Add("Class",2);
           jso.Add("Name","クライアントさん");

           JsonObject otherJO1 = new JsonObject();
           
           otherJO1.Add("Subject","数学");
           otherJO1.Add("Score",64);
           
           JsonObject otherJO2 = new JsonObject();

           otherJO2.Add("Subject","理科");
           otherJO2.Add("Score",70);

           JsonObject otherJO3 = new JsonObject();

           otherJO3.Add("Subject","英語");
           otherJO3.Add("Score",80);
           
            // Json array

           JsonArray ja = new JsonArray();
 
           ja.Add(otherJO1);
           ja.Add(otherJO2);
           ja.Add(otherJO3);

           jso.Add("Results",ja);

           Console.WriteLine(jso.ToString());
           
           IRISConnection conn = new IRISConnection();
           IRIS iris;

           conn.ConnectionString = "Server = localhost; Log File=cprovider.log;Port=1972; Namespace=USER; Password = SYS; User ID = _SYSTEM;";

           conn.Open();

           iris = IRIS.CreateIRIS(conn);
           string ReturnValue = iris.ClassMethodString("REST.JSON", "SendJSON", jso.ToString());

           conn.Close();

       }
   }
