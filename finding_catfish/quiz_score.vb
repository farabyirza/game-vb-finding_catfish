Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data
Public Class quiz_score
    Dim mySqlConn As New MySqlConnection
    Dim mySqlCommand, mySqlCommandskor As New MySqlCommand
    Dim myadapter As New MySqlDataAdapter
    Dim mydata As New DataTable
    Dim reader As MySqlDataReader

    Dim bil1 As Integer
    Dim bil2 As Integer
    Dim hasil As Integer
    Sub koneksi()
        mySqlConn = New MySqlConnection("server='localhost';user id ='root'; password='';database='catfishgame'")
        mySqlConn.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksi()
        mySqlCommand = New MySqlCommand("insert into score (nama, skor) values ('" & TextBox4.Text & "','" & TextBox3.Text & "')", mySqlConn)
        mySqlCommand.ExecuteNonQuery()
        Me.Hide()
        score.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub quiz_score_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.lbscorecount.Text = TextBox2.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        bil1 = TextBox2.Text
        bil2 = TextBox1.Text
        hasil = bil1 + bil2
        TextBox3.Text = hasil
    End Sub
End Class