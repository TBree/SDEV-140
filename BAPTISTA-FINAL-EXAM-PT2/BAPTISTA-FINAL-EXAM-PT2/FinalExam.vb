Public Class FinalExam

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Check EACH radio buttons for Calculation:'

        If Radio_Btn_Add.Checked Then
            'Checks to see if numbers are entered'
            If txtNum1.Text And txtNum2.Text = "" Then
                MessageBox.Show("ERROR: ... ENTER A NUMBER IN EACH BOX")
            Else
                MsgBox("THE SUM:" & Str(Val(txtNum1.Text) + Val(txtNum2.Text)))
            End If
        End If

        If Radio_btn_Subtract.Checked Then
            'Checks to see if numbers are entered'
            If txtNum1.Text And txtNum2.Text = "" Then
                MessageBox.Show("ERROR: ... ENTER A NUMBER IN EACH BOX")
            Else
                MsgBox("THE DIFFERENCE: " & Str(Val(txtNum1.Text) - Val(txtNum2.Text)))
            End If
        End If

        If Radio_btn_Dob.Checked Then
            'Check which number to calculate'

            If txtNum1.Text <> 99999 Then
                MsgBox("THE DOUBLE: " & Str(Val(txtNum1.Text * 2)))
            ElseIf txtNum2.Text <> 99999 Then
                MsgBox("THE DOUBLE: " & Str(Val(txtNum1.Text * 2)))
            End If
        End If

        If Radio_btn_Half.Checked Then
            'Check which number to calculate'

            If txtNum1.Text <> 99999 Then
                MsgBox("THE DOUBLE: " & Str(Val(txtNum1.Text \ 2)))
            ElseIf txtNum2.Text <> 99999 Then
                MsgBox("THE DOUBLE: " & Str(Val(txtNum2.Text \ 2)))
            End If
        End If
        End

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
