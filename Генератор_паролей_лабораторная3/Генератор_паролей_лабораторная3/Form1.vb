Imports System.Text
Public Class Form1
    Public upper_latin As String = "QWERTYUIOPASDFGHJKLZXCVBNM"
    Public lower_latin As String = "qwertyuiopasdfghjklzxcvbnm"
    Public upper_rus As String = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ"
    Public lower_rus As String = "йцукенгшщзхъфывапролджэячсмитьбю"
    Public symbols As String = "+-*/=><[]()@{}.,:;'#$^ "
    Public numbers As String = "1234567890"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Text = CDec(10 ^ -5)
        Label9.Text = Math.Abs((CInt(TextBox1.Text) * CInt(TextBox2.Text)) / CDec(TextBox3.Text))
        Label10.Text = 0
        Label11.Text = 0
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim password_alphabet As String = ""
        For i = 1 To 10
            If CInt(Label9.Text) <= CInt(Label10.Text) ^ i Then
                Label11.Text = i
                If CheckBox1.Checked = True Then
                    password_alphabet += upper_latin
                End If
                If CheckBox2.Checked = True Then
                    password_alphabet += lower_latin
                End If
                If CheckBox3.Checked = True Then
                    password_alphabet += upper_rus
                End If
                If CheckBox4.Checked = True Then
                    password_alphabet += lower_rus
                End If
                If CheckBox5.Checked = True Then
                    password_alphabet += symbols
                End If
                If CheckBox6.Checked = True Then
                    password_alphabet += numbers
                End If
                Dim r As New Random
                Dim sb As New StringBuilder
                For a = 1 To i
                    Dim idx As Integer = r.Next(0, password_alphabet.Length)
                    sb.Append(password_alphabet.Substring(idx, 1))
                Next
                Label8.Text = sb.ToString
                Exit Sub
            End If
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label10.Text += upper_latin.Length
        Else
            Label10.Text -= upper_latin.Length
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Label10.Text += lower_latin.Length
        Else
            Label10.Text -= lower_latin.Length
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Label10.Text += upper_rus.Length
        Else
            Label10.Text -= upper_rus.Length
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Label10.Text += lower_rus.Length
        Else
            Label10.Text -= lower_rus.Length
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Label10.Text += symbols.Length
        Else
            Label10.Text -= symbols.Length
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            Label10.Text += numbers.Length
        Else
            Label10.Text -= numbers.Length
        End If
    End Sub
End Class