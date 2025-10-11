using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Json;
using InterSystems.XEP;

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

           EventPersister ep = PersisterFactory.CreatePersister();

           //ep.Connect("USER", "_SYSTEM", "SYS");
           ep.Connect("localhost",1972,"USER", "_SYSTEM", "SYS");

           Object returnvalue = ep.CallClassMethod("REST.JSON", "SendJSON",jso.ToString());

           ep.Close();

       }
   }
