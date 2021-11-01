Imports System.Data.SqlClient

Public Class Form1
    Dim cmd As SqlCommand
    Dim conn As SqlConnection
    Dim cnstr As String = "data source = DESKTOP-VE1RHEC; user = resty; password = xxxx; database = PotolinSuperMarket;"
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim itemcoll(999) As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

      
        Try
            conn = New SqlConnection(cnstr)
            conn.Open()
            MsgBox("Successfully Connected to Database")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            conn = New SqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "insert into Categories(CategoryName, Description) values (@catname, @desc)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@catname", txt_Cat_Name.Text)
            cmd.Parameters.AddWithValue("@desc", txt_Desc.Text)
            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Data Added Successfully!")
            Else
                MsgBox("Data Cannot be save!")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        loadlistview()
        conn.Close()

    End Sub

    Public Sub loadlistview()
        Try
            ListView1.Items.Clear()
            conn = New SqlConnection(cnstr)
            conn.Open()
            Dim sql As String = "select * from Categories"
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "tables")
            For r = 0 To ds.Tables(0).Rows.Count - 1
                For c = 0 To ds.Tables(0).Columns.Count - 1
                    itemcoll(c) = ds.Tables(0).Rows(r)(c).ToString

                Next
                Dim lvitems As New ListViewItem(itemcoll)
                ListView1.Items.Add(lvitems)

            Next

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadlistview()

    End Sub
End Class
