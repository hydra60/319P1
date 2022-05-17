Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        Dim result As String

        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)
        If a > b And a > c Then
            GoTo a_mayor
        Else
            If b > a And b > c Then
                GoTo b_mayor

            Else
                result = c.ToString
                If b > a Then
                    result = a.ToString + " " + b.ToString + " " + result
                Else
                    result = b.ToString + " " + a.ToString + " " + result
                End If
            End If
        End If

        TextBox4.Text = result

a_mayor:
        result = a.ToString
        If b > c Then
            result = c.ToString + " " + b.ToString + " " + result
        Else
            result = b.ToString + " " + c.ToString + " " + result
        End If
        GoTo Finalize
b_mayor:
        result = b.ToString
        If a > c Then
            result = c.ToString + " " + a.ToString + " " + result
        Else
            result = a.ToString + " " + c.ToString + " " + result
        End If
        GoTo Finalize

Finalize:

    End Sub
End Class
