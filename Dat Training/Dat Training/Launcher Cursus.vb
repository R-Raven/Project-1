Public Class Launcher

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NieuweCursist.Click
        Dim oForm As NieuweCursist
        oForm = New NieuweCursist()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Exitbutton.Click
        Close()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Opties.Click
        Dim oForm As Opties
        oForm = New Opties()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CursusData.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles HuidigeCursisten.Click
        Dim oForm As HuidigeCursisten
        oForm = New HuidigeCursisten()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class
