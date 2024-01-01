Public Class Form5
    Private Sub ArraySatuDimensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM")
        ListView1.Columns.Add("NAMA", 115)
        ListView1.Columns.Add("PRODI", 110)
        txtNIM.Text = 1
        txtNama.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Arr(2) As String
        Arr(0) = txtNIM.Text
        Arr(1) = txtNama.Text
        Arr(2) = txtProdi.Text
        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        txtNIM.Text = txtNIM.Text + 1
        txtNama.Text = ""
        txtProdi.Text = ""
        txtNama.Focus()
    End Sub
End Class