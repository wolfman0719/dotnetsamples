// binread.cs

using System;
using System.IO;
using System.Data;
using InterSystems.Data.IRISClient;
using InterSystems.Data.IRISClient.ADO;

namespace binaryfileread {

    class binaryfileread 
    {
    [STAThread]
    static void Main(string[] args) {

        IRISCommand spIRIS;
        IRISConnection cnIRIS;
        IRISTransaction txIRIS = null;

        //存在するファイルを指定する
        FileStream fs = new FileStream(
        @"c:\temp\test.jpeg", FileMode.Open, FileAccess.Read);

        int fileSize = (int)fs.Length; // ファイルのサイズ
        byte[] buf = new byte[fileSize]; // データ格納用配列

        long readSize; // Readメソッドで読み込んだバイト数
        int remain = fileSize; // 読み込むべき残りのバイト数

        readSize = fs.Read(buf, 0, (int)fs.Length);

        string IRISConnectString = "Server = localhost;Port=1972;Namespace=User;Password=SYS;User ID = _SYSTEM;";
        cnIRIS = new IRISConnection(IRISConnectString);
        cnIRIS.Open();
        spIRIS = new IRISCommand("Insert into MyApp.Person2(Name, Picture) Values(?, ?)", cnIRIS, txIRIS);

        IRISParameter pName = new IRISParameter();
        pName.ParameterName = "Name";
        pName.IRISDbType = IRISDbType.NVarChar;
        pName.Direction = ParameterDirection.Input;
        pName.Value = "Hoge Hoge";
        spIRIS.Parameters.Add(pName);

        IRISParameter pPicture = new IRISParameter();
        pPicture.ParameterName = "Picture";
        pPicture.IRISDbType = IRISDbType.LongVarBinary;
        pPicture.Direction = ParameterDirection.Input;
        pPicture.Value = buf;
        spIRIS.Parameters.Add(pPicture);

        spIRIS.ExecuteNonQuery();

        fs.Dispose();
        cnIRIS.Close();
    }
   }
}
