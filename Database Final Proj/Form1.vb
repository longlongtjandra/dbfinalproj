Imports MySql.Data.MySqlClient
Public Class Form1
    Dim con As MySqlConnection
    Dim str, query As String
    Dim comm As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Laptop.Show()
        Me.Hide()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        spareparts.Show()
        Me.Hide()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub







End Class
