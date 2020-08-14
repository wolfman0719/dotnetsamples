Imports InterSystems.Data.CacheClient
Imports InterSystems.Data.CacheTypes
Imports System.Drawing

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As CacheConnection
        cn = New CacheConnection("Server=127.0.0.1;Port=1972;Namespace=User;Username=_system;Password=SYS")
        cn.Open()

        Dim img As System.IO.FileStream
        img = New System.IO.FileStream("C:\temp\test.jpg", System.IO.FileMode.Open, IO.FileAccess.Read)

        Dim f As User.Fax

        ' NEW -----------
        f = New User.Fax(cn)
        img.CopyTo(f.pic)
        f.memo = "abcde"
        f.Save()
        f.Dispose()

        MsgBox("Done!")

        cn.Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim cn As CacheConnection
        cn = New CacheConnection("Server=127.0.0.1;Port=1972;Namespace=User;Username=_system;Password=SYS")
        cn.Open()

        Dim f As User.Fax

        f = User.Fax.OpenId(cn, 1)
        PictureBox1.Image = Image.FromStream(f.pic)

        cn.Close()
    End Sub
End Class
