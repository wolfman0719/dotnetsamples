using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web;

namespace JsonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // URLエンコーディング
            string url = "http://localhost:57772/rest/jqueryjsonarray";
            // HTTPアクセス
            var req = WebRequest.Create(url);
            req.Headers.Add("Accept-Language:ja,en-us;q=0.7,en;q=0.3");
            var res = req.GetResponse();
            // レスポンス(JSON)をオブジェクトに変換
            ServiceResult info;
            using (res)
            {
                using (var resStream = res.GetResponseStream())
                {
                    var serializer = new DataContractJsonSerializer(typeof(ServiceResult));
                    info = (ServiceResult)serializer.ReadObject(resStream);
                }
            }
            // 結果を出力
            Debug.WriteLine("red: " + info.red);
            Debug.WriteLine("blue: " + info.red);
            Debug.WriteLine("yellow: " + info.red);
        }
    }

    [DataContract]
    public class ServiceResult
    {
        [DataMember]
        public string red { get; set; }
        [DataMember]
        public string blue { get; set; }
        [DataMember]
        public string yellow { get; set; }
    }
}