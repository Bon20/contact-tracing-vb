
Imports System.IO

Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Using sw As StreamWriter = New StreamWriter(Application.StartupPath & "" + txtbxFname.Text & " " + txtbxLname.Text & ".txt")
            MessageBox.Show("Submitted!")

            sw.WriteLine(lblFname.Text & " " + txtbxFname.Text)
            sw.WriteLine(lblLname.Text & " " + txtbxLname.Text)
            sw.WriteLine(lblCnumber.Text & " " + txtbxCnumber.Text)
            sw.WriteLine(lblAge.Text & " " + txtbxAge.Text)
            sw.WriteLine(lblGender.Text & " " + cbxGender.Text)
            sw.WriteLine(lblAddress.Text & " " + txtbxAddress.Text)
            sw.WriteLine(lblQuestion2.Text)
            sw.WriteLine(lblFever.Text & " " + cboxFever.Text)
            sw.WriteLine(lblCough.Text & " " + cboxCough.Text)
            sw.WriteLine(lblColds.Text & " " + cboxColds.Text)
            sw.WriteLine(lblSorethroat.Text & " " + cboxSorethroat.Text)
            sw.WriteLine(lblDiffInBreath.Text & " " + cboxDiffInBreath.Text)
            sw.WriteLine(lbldiarrhea.Text & " " + cBoxDiarrhea.Text)

            If radbuttonYes.Checked = True Then
                sw.WriteLine(gbxQuestion1.Text + radbuttonYes.Text)
            Else
                sw.WriteLine(vbCrLf & gbxQuestion1.Text & " " + radbuttonNo.Text)
            End If

            sw.Close()

        End Using
    End Sub
End Class
