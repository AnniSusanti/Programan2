Public Class Form8
    Sub Bersih()
        TxtKodeBrg.Text = ""
        TxtNamaBrg.Text = ""
        TxtSatuan.Text = ""
        TxtHrgSatuan.Text = ""
        TxtJumlah.Text = ""
        TxtTotalHarga.Text = ""
        TxtKodeBrg.Focus()
        TxtTotalHarga.Enabled = False
    End Sub
    Private Function Hitung()
        Dim Harga, Jumlah, Total As Integer
        Harga = TxtHrgSatuan.Text
        Jumlah = TxtJumlah.Text
        Total = Harga * Jumlah
        TxtTotalHarga.Text = Total
        Return Total
    End Function
    Sub CekDataKosong()
        If TxtKodeBrg.Text = "" Then
        MessageBox.Show("Kode Barang harus diisi", "Konfirmasi",MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtKodeBrg.Focus()
        ElseIf TxtNamaBrg.Text = "" Then
MessageBox.Show("Nama Barang harus diisi", "Konfirmasi",MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNamaBrg.Focus()
        ElseIf TxtSatuan.Text = "" Then
MessageBox.Show("Satuan Barang harus diisi", "Konfirmasi",MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtSatuan.Focus()
        ElseIf TxtHrgSatuan.Text = "" Then
MessageBox.Show("Harga Barang harus diisi", "Konfirmasi",MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtHrgSatuan.Focus()
        ElseIf TxtJumlah.Text = "" Then
MessageBox.Show("Jumlah Barang harus diisi", "Konfirmasi",MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtJumlah.Focus()
        Else
            Call Hitung()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Bersih()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call CekDataKosong()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Tutup As String
Tutup = MessageBox.Show("Yakin tutup form ini ?", "Konfirmasi",MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class