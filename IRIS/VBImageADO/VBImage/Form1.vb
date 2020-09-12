Imports InterSystems.Data.IRISClient
Imports InterSystems.Data.IRISClient.ADO
Imports System.Drawing
Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As IRISConnection
        cn = New IRISConnection("Server=127.0.0.1;Port=51773;Namespace=User;Username=_system;Password=SYS")
        cn.Open()
        Dim iris As IRIS
        Dim iriscommand As IRISCommand
        Dim memstream As New MemoryStream
        Dim buf As Byte()

        iris = IRIS.CreateIRIS(cn)

        Dim img As System.IO.FileStream
        img = New System.IO.FileStream("C:\temp\test.jpg", System.IO.FileMode.Open, IO.FileAccess.Read)

        buf = New Byte(img.Length) {}
        img.Read(buf, 0, img.Length)

        iriscommand = New IRISCommand("Insert into SQLUSER.FAX(MEMO, PIC) Values(?, ?)", cn)

        Dim pMemo As IRISParameter
        pMemo = New IRISParameter()
        pMemo.ParameterName = "Memo"
        pMemo.IRISDbType = IRISDbType.NVarChar
        pMemo.Direction = ParameterDirection.Input
        pMemo.Value = "Hoge Hoge"
        iriscommand.Parameters.Add(pMemo)

        Dim pPicture As IRISParameter
        pPicture = New IRISParameter()
        pPicture.ParameterName = "Picture"
        pPicture.IRISDbType = IRISDbType.LongVarBinary
        pPicture.Direction = ParameterDirection.Input
        pPicture.Value = buf
        iriscommand.Parameters.Add(pPicture)

        iriscommand.ExecuteNonQuery()

        img.Dispose()
        cn.Close()

        MsgBox("Done!")

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim cn As IRISConnection
        Dim iris As IRIS
        Dim iriscommand As IRISCommand
        Dim memorystream As New MemoryStream

        cn = New IRISConnection("Server=127.0.0.1;Port=51773;Namespace=User;Username=_system;Password=SYS")
        cn.Open()

        iris = IRIS.CreateIRIS(cn)

        iriscommand = New IRISCommand("select PIC from SQLUSER.FAX where id = ?", cn)

        Dim pId As IRISParameter
        pId = New IRISParameter()
        pId.ParameterName = "ID"
        pId.IRISDbType = IRISDbType.Int
        pId.Direction = ParameterDirection.Input
        pId.Value = 1
        iriscommand.Parameters.Add(pId)

        Dim Reader As IRISDataReader = iriscommand.ExecuteReader()

        While Reader.Read()
            memorystream.Write(Reader.Item(Reader.GetOrdinal("PIC")), 0, Reader.Item(Reader.GetOrdinal("PIC")).Length)
            PictureBox1.Image = Image.FromStream(memorystream)
        End While

        cn.Close()
    End Sub

End Class
