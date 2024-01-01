Public Class Form13
    Dim f1 As Form1 = New Form1
    Dim f2 As Form2 = New Form2
    Dim f3 As Form3 = New Form3
    Dim f4 As Form4 = New Form4
    Dim f6 As Form6 = New Form6
    Dim f5 As Form5 = New Form5
    Dim f7 As Form7 = New Form7
    Dim f8 As Form8 = New Form8
    Dim f9 As Form9 = New Form9
    Dim f10 As Form10 = New Form10
    Dim f11 As Form11 = New Form11
    Dim f12 As Form12 = New Form12


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If f1.IsDisposed Then
            f1 = New Form1
        Else
            f1.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If f2.IsDisposed Then
            f2 = New Form2
        Else
            f2.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If f3.IsDisposed Then
            f3 = New Form3
        Else
            f3.Show()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If f4.IsDisposed Then
            f4 = New Form4
        Else
            f4.Show()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If f6.IsDisposed Then
            f6 = New Form6
        Else
            f6.Show()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If f5.IsDisposed Then
            f5 = New Form5
        Else
            f5.Show()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If f7.IsDisposed Then
            f7 = New Form7
        Else
            f7.Show()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If f8.IsDisposed Then
            f8 = New Form8
        Else
            f8.Show()
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If f9.IsDisposed Then
            f9 = New Form9
        Else
            f9.Show()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If f10.IsDisposed Then
            f10 = New Form10
        Else
            f10.Show()
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If f11.IsDisposed Then
            f11 = New Form11
        Else
            f11.Show()
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If f12.IsDisposed Then
            f12 = New Form12
        Else
            f12.Show()
        End If
    End Sub
End Class