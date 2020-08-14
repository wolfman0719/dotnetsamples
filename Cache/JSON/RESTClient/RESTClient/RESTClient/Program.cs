using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;

namespace RESTClient
{
    class Program
    {
        static void Main(string[] args)
        {

            string mainuri = "http://localhost:57775/csp/samples/docserver/";
            //string mainuri = "http://160.0.9.169:57775/csp/samples/docserver/";
            //string mainuri = "http://160.0.9.169:57775/csp/user/DocServer/";

            Encoding enc = System.Text.Encoding.GetEncoding(932);
            HttpWebRequest req = null; 
            HttpWebResponse resp = null;
            StreamReader loResponseStream;
            string ResponseData;

            /// 1) Get the text of the class Samples/Sample.Person

            string targeturi = mainuri + "class/samples/Sample.Person";

            req = WebRequest.Create(targeturi) as HttpWebRequest;
            req.Method = "GET";

            resp = req.GetResponse() as HttpWebResponse;

            loResponseStream = new StreamReader(resp.GetResponseStream(), enc);
            ResponseData = loResponseStream.ReadToEnd();
            loResponseStream.Close();

            resp.Close();

            Console.WriteLine(ResponseData);

            //wait
            Console.WriteLine("<ENTER>");
            Console.ReadLine();


            ///  2) Get a list of namespaces on the target server (plain/text)

            targeturi = mainuri+"namespaces";

            req = WebRequest.Create(targeturi) as HttpWebRequest;
            req.Method = "GET";

            resp = req.GetResponse() as HttpWebResponse;
            
            loResponseStream = new StreamReader(resp.GetResponseStream(), enc);
            ResponseData = loResponseStream.ReadToEnd();
            loResponseStream.Close();
            resp.Close();

            Console.WriteLine(ResponseData);

            //wait
            Console.WriteLine("<ENTER>");
            Console.ReadLine();


            ///  3) Get a list of namespaces on the target server (plain/text)

            targeturi = mainuri + "namespaces";

            req = WebRequest.Create(targeturi) as HttpWebRequest;
            req.Accept = "application/json";
            req.Method = "GET";

            resp = req.GetResponse() as HttpWebResponse;

            loResponseStream = new StreamReader(resp.GetResponseStream(), enc);
            ResponseData = loResponseStream.ReadToEnd();
            loResponseStream.Close();
            resp.Close();

            Console.WriteLine(ResponseData);


            Console.WriteLine("DataContractJsonSerializerを使って表示");

            MemoryStream ms =new MemoryStream(Encoding.UTF8.GetBytes(ResponseData));
            //JSONデータをクラスに格納
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(nslist));
            nslist ns = (nslist)ser.ReadObject(ms);
            int nscnt = ns.namespaces.Count();

            for (int j = 0; j < nscnt; j++ )
            {
                Console.WriteLine("namespace[" +j +"]:"+ns.namespaces[j]);
            }
            //wait
            Console.WriteLine("<ENTER>");
            Console.ReadLine();


            /// 5) Get a list of embedded languages for syntax coloring

            targeturi = mainuri + "echo";

            req = WebRequest.Create(targeturi) as HttpWebRequest;
            req.ContentType = "text/plain";
            req.Method = "POST";

            string file = "RESTClient.exe.config";
            FileInfo fInfo = new FileInfo(file);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(file,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);  
            byte[] data = br.ReadBytes((int)numBytes);  
            br.Close();  
            fStream.Close();  
            fStream.Dispose();  
            Stream wrStream = req.GetRequestStream();  
            BinaryWriter bw = new BinaryWriter(wrStream);  
            bw.Write(data);  
            bw.Close(); 

            resp = req.GetResponse() as HttpWebResponse;

            loResponseStream = new StreamReader(resp.GetResponseStream(), enc);
            ResponseData = loResponseStream.ReadToEnd();
            loResponseStream.Close();
            resp.Close();

            Console.WriteLine(ResponseData);

            //wait
            Console.WriteLine("<ENTER>");
            Console.ReadLine();


            /// 7) Get a list of embedded languages for syntax coloring

            targeturi = mainuri + "languages";

            req = WebRequest.Create(targeturi) as HttpWebRequest;
            req.Accept = "application/json";
            req.Method = "GET";

            resp = req.GetResponse() as HttpWebResponse;

            loResponseStream = new StreamReader(resp.GetResponseStream(), enc);
            ResponseData = loResponseStream.ReadToEnd();
            loResponseStream.Close();
            resp.Close();

            Console.WriteLine(ResponseData);

            //wait
            Console.WriteLine("<ENTER>");
            Console.ReadLine();


        }
    }

    public class nslist
    {
        public List<string> namespaces { get; set; }
    }
}
