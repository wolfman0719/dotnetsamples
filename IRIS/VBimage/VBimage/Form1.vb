Imports InterSystems.Data.IRISClient
Imports InterSystems.Data.IRISClient.ADO
Imports System.Drawing
Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As IRISConnection
        cn = New IRISConnection("Server=127.0.0.1;Port=1972;Namespace=User;Username=_system;Password=SYS")
        cn.Open()
        Dim iris As IRIS
        Dim irisobject As IRISObject
        Dim memstream As New MemoryStream
        Dim str As String
        Dim buf As Byte()
        Dim pic As IRISObject


        iris = IRIS.CreateIRIS(cn)

        irisobject = iris.ClassMethodObject("User.Fax", "%New")



        Dim img As System.IO.FileStream
        img = New System.IO.FileStream("C:\temp\test.jpg", System.IO.FileMode.Open, IO.FileAccess.Read)

        buf = New Byte(img.Length) {}
        img.Read(buf, 0, img.Length)

        'str = System.Text.Encoding.GetEncoding("ISO-8859-1").GetString(buf)

        pic = irisobject.GetObject("pic")

        pic.InvokeVoid("Write", buf)

        irisobject.InvokeStatusCode("%Save")

        MsgBox("Done!")

        cn.Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim cn As IRISConnection
        Dim iris As IRIS
        Dim irisobject As IRISObject
        Dim pic As IRISObject
        Dim memorystream As New MemoryStream

        Dim buf As Byte()
        Dim str As String
        Dim len As Long

        cn = New IRISConnection("Server=127.0.0.1;Port=1972;Namespace=User;Username=_system;Password=SYS")
        cn.Open()

        iris = IRIS.CreateIRIS(cn)

        irisobject = iris.ClassMethodObject("User.Fax", "%OpenId", 1)
        pic = irisobject.GetObject("pic")

        len = pic.InvokeLong("SizeGet")

        str = pic.InvokeString("Read", len)

        buf = System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(str)

        memorystream.Write(buf, 0, len)

        PictureBox1.Image = Image.FromStream(MemoryStream)

        cn.Close()
    End Sub

End Class
