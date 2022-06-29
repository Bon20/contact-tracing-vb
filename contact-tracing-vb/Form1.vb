
Imports System.IO

Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Using sw As StreamWriter = New StreamWriter(Application.StartupPath & "" + txtbxFname.Text & " " + txtbxLname.Text & ".txt")
            MessageBox.Show(" Record Submitted!")
            Dim datenow = DateTime.Now

            sw.WriteLine(datenow.ToLongDateString())
            sw.WriteLine(datenow.ToShortTimeString())

            sw.WriteLine(vbCrLf & lblFname.Text & " " + txtbxFname.Text)
            sw.WriteLine(lblLname.Text & " " + txtbxLname.Text)
            sw.WriteLine(lblCnumber.Text & " " + txtbxCnumber.Text)
            sw.WriteLine(lblAge.Text & " " + txtbxAge.Text)
            sw.WriteLine(lblGender.Text & " " + cbxGender.Text)
            sw.WriteLine(lblAddress.Text & " " + txtbxAddress.Text)
            sw.WriteLine(vbCrLf & lblQuestion2.Text)
            sw.WriteLine(lblFever.Text & " " + cboxFever.Text)
            sw.WriteLine(lblCough.Text & " " + cboxCough.Text)
            sw.WriteLine(lblColds.Text & " " + cboxColds.Text)
            sw.WriteLine(lblSorethroat.Text & " " + cboxSorethroat.Text)
            sw.WriteLine(lblDiffInBreath.Text & " " + cboxDiffInBreath.Text)
            sw.WriteLine(lbldiarrhea.Text & " " + cBoxDiarrhea.Text)

            If radbuttonYes.Checked = True Then
                sw.WriteLine(vbCrLf & gbxQuestion1.Text + radbuttonYes.Text)
            Else
                sw.WriteLine(vbCrLf & gbxQuestion1.Text & " " + radbuttonNo.Text)
            End If

            sw.Close()

            txtbxFname.Text = ""
            txtbxLname.Text = ""
            txtbxCnumber.Text = ""
            txtbxAge.Text = ""
            txtbxAddress.Text = ""

            cbxGender.SelectedIndex = -1
            cboxFever.SelectedIndex = -1
            cboxCough.SelectedIndex = -1
            cboxColds.SelectedIndex = -1
            cboxSorethroat.SelectedIndex = -1
            cboxDiffInBreath.SelectedIndex = -1
            cBoxDiarrhea.SelectedIndex = -1

            radbuttonYes.Checked = False
            radbuttonNo.Checked = False

        End Using
    End Sub

    Private Sub txtbxCnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxCnumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field is accepting numbers only!")
        ElseIf txtbxCnumber.Text.Length > 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Contact number should not be more than 11 numbers!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub txtbxAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxAge.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field is accepting numbers only!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtbxAge.Text.Length > 3 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Age should not be more than 3 numbers!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub txtbxFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxFname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field is accepting letters only!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtbxLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxLname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field is accepting letters only!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnViewDisplay_Click(sender As Object, e As EventArgs) Handles btnViewDisplay.Click
        Dim ViewDisplay As OpenFileDialog = New OpenFileDialog()

        If ViewDisplay.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If (ViewDisplay.OpenFile()) IsNot Nothing Then
                Dim strfilename As String = ViewDisplay.FileName
                Dim filetext As String = File.ReadAllText(strfilename)
                RboxDisplay.Text = filetext
            End If

        End If
    End Sub

    Private Sub btnClearDisplay_Click(sender As Object, e As EventArgs) Handles btnClearDisplay.Click
        RboxDisplay.Clear()
    End Sub
End Class
