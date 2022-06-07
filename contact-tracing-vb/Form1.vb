
Imports System.IO

Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Using sw As StreamWriter = New StreamWriter(Application.StartupPath & "" + txtbxFname.Text & " " + txtbxLname.Text & ".txt")
            MessageBox.Show("Submitted!")



        End Using
    End Sub
End Class
