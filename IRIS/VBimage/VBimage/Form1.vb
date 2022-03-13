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
        Dim pic As IRISObject
        Dim maxlength As Long


        maxlength = 3600000L

        iris = IRIS.CreateIRIS(cn)

        irisobject = iris.ClassMethodObject("User.Fax", "%New")

        pic = irisobject.GetObject("pic")


        Dim img As System.IO.FileStream
        img = New System.IO.FileStream("C:\temp\test.jpg", System.IO.FileMode.Open, IO.FileAccess.Read)

        Dim bytes = New Byte(maxlength) {}

        While img.Read(bytes, 0, bytes.Length) > 0
            pic.InvokeStatusCode("Write", bytes)
        End While

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

        Dim maxlength As Long
        Dim len As Long

        maxlength = 3600000L

        cn = New IRISConnection("Server=127.0.0.1;Port=1972;Namespace=User;Username=_system;Password=SYS")
        cn.Open()

        iris = IRIS.CreateIRIS(cn)

        irisobject = iris.ClassMethodObject("User.Fax", "%OpenId", 1)
        pic = irisobject.GetObject("pic")

        Do
            Dim buf = pic.InvokeBytes("Read", maxlength)
            len = buf.Length
            If len = 0 Then Exit Do
            memorystream.Write(buf, 0, len)
            If len < maxlength Then Exit Do
        Loop

        PictureBox1.Image = Image.FromStream(MemoryStream)

        cn.Close()
    End Sub

End Class
