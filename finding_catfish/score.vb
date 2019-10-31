Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data
Public Class score
    Dim sql As New MySqlConnection
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataAdapter
    Dim myadapter As New MySqlDataAdapter
    Dim mydata As DataTable
    Sub koneksi()
        sql = New MySqlConnection("server='localhost';user id ='root'; password='';database='catfishgame'")
        sql.Open()
    End Sub
    Sub opentable()
        Dim myadapter As New MySqlDataAdapter("select * from score", sql)
        Dim mydata As New DataTable
        myadapter.Fill(mydata)
        DataGridView1.DataSource = mydata
        DataGridView1.Refresh()
    End Sub
    Private Sub score_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        opentable()
        DataGridView1.Refresh()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        opening10.Show()
    End Sub
End Class