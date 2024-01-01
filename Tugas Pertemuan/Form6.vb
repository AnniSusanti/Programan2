Public Class Form6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim kecepatan As Double
        Dim waktutempuh As Double
        Dim jarak As Double
        kecepatan = TextBox1.Text
        waktutempuh = TextBox2.Text
        jarak = kecepatan * waktutempuh
        TextBox3.Text = jarak
        ListBox1.Items.Add(jarak)
    End Sub
End Class