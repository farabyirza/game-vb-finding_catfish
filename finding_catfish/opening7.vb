Public Class opening7

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        PictureBox5.Hide()
        PictureBox4.Show()
        PictureBox4.Visible = True
    End Sub

    Private Sub PictureBox4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        PictureBox4.Visible = False
        PictureBox3.Show()
        PictureBox3.Visible = True
    End Sub

    Private Sub PictureBox3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Hide()
        quiz1.Show()
    End Sub


End Class