Imports MySql.Data.MySqlClient
Public Class spADDstock
    Dim con As MySqlConnection
    Dim str, query As String
    Dim comm As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim id As Integer = Val(TextBox1.Text)
        Dim stock As Integer = Val(TextBox2.Text)
        str = "server = localhost; user id = root; password=; database = Final_project; SslMode=none"
        con = New MySqlConnection(str)

        Try
            If TextBox1.Text.Length <= 0 Or TextBox2.Text.Length <= 0 Then
                MessageBox.Show("you need to fill all boxes")

            Else
                con.Open()
                query = "update sparepart set stock = stock + " + CStr(stock) + " where sp_id = " + CStr(id)
                comm = New MySqlCommand(query, con)
                reader = comm.ExecuteReader
                MessageBox.Show("stock has been succesfully added")
                con.Close()



                TextBox1.Enabled = False
                TextBox2.Enabled = False
                Laptop.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show("error while adding stock")
        End Try
    End Sub
End Class