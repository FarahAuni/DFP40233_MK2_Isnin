Public Class Form1
    ' Example database or list to simulate storage
    Dim pelangganList As New DataTable()

    Private Sub FormMaklumatPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize DataTable columns
        pelangganList.Columns.Add("Bil", GetType(Integer))
        pelangganList.Columns.Add("Nama", GetType(String))
        pelangganList.Columns.Add("NoTel", GetType(String))
        pelangganList.Columns.Add("Alamat", GetType(String))
        pelangganList.Columns.Add("Negeri", GetType(String))
        pelangganList.Columns.Add("Jantina", GetType(String))
        pelangganList.Columns.Add("Perisa", GetType(String))
        pelangganList.Columns.Add("KaedahBayaran", GetType(String))

        ' Bind DataTable to DataGridView
        DataGridView1.DataSource = pelangganList
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        ' Add new entry to the list
        If ValidateInput() Then
            Dim bil As Integer = pelangganList.Rows.Count + 1
            Dim nama As String = txtNama.Text
            Dim noTel As String = TxtNoTel.Text
            Dim alamat As String = txtAlamat.Text
            Dim negeri As String = cmbNegeri.Text
            Dim jantina As String = If(RbLelaki.Checked, "Lelaki", If(RbWanita.Checked, "Wanita", ""))
            Dim perisa As String = GetSelectedFlavors()
            Dim kaedahBayaran As String = If(RbCash.Checked, "Cash", If(RbCashless.Checked, "Cashless", ""))

            ' Add to DataTable
            pelangganList.Rows.Add(bil, nama, noTel, alamat, negeri, jantina, perisa, kaedahBayaran)

            MessageBox.Show("Data successfully added!", "Create")
            ClearFields()
        End If
    End Sub

    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
        ' Display the selected row's data
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            txtNama.Text = row.Cells("Nama").Value.ToString()
            txtNotel.Text = row.Cells("NoTel").Value.ToString()
            txtAlamat.Text = row.Cells("Alamat").Value.ToString()
            cmbNegeri.Text = row.Cells("Negeri").Value.ToString()
            Select Case row.Cells("Jantina").Value.ToString()
                Case "Lelaki"
                    RbLelaki.Checked = True
                Case "Wanita"
                    RbWanita.Checked = True
            End Select
            SetSelectedFlavors(row.Cells("Perisa").Value.ToString())
            Select Case row.Cells("KaedahBayaran").Value.ToString()
                Case "Cash"
                    RbCash.Checked = True
                Case "Cashless"
                    RbCashless.Checked = True
            End Select
        Else
            MessageBox.Show("Please select a row to view details!", "Read")
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        ' Update the selected row
        If DataGridView1.SelectedRows.Count > 0 AndAlso ValidateInput() Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            row.Cells("Nama").Value = txtNama.Text
            row.Cells("NoTel").Value = TxtNoTel.Text
            row.Cells("Alamat").Value = txtAlamat.Text
            row.Cells("Negeri").Value = CmbNegeri.Text
            row.Cells("Jantina").Value = If(RbLelaki.Checked, "Lelaki", If(RbWanita.Checked, "Wanita", ""))
            row.Cells("Perisa").Value = GetSelectedFlavors()
            row.Cells("KaedahBayaran").Value = If(RbCash.Checked, "Cash", If(RbCashless.Checked, "Cashless", ""))

            MessageBox.Show("Data successfully updated!", "Update")
            ClearFields()
        Else
            MessageBox.Show("Please select a row to update!", "Update")
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ' Delete the selected row
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            MessageBox.Show("Data successfully deleted!", "Delete")
            ClearFields()
        Else
            MessageBox.Show("Please select a row to delete!", "Delete")
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        ' Validate the input fields
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Please enter the name!", "Validation")
            Return False
        End If
        If String.IsNullOrWhiteSpace(TxtNoTel.Text) Then
            MessageBox.Show("Please enter the phone number!", "Validation")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            MessageBox.Show("Please enter the address!", "Validation")
            Return False
        End If
        If String.IsNullOrWhiteSpace(CmbNegeri.Text) Then
            MessageBox.Show("Please select a state!", "Validation")
            Return False
        End If
        Return True
    End Function

    Private Function GetSelectedFlavors() As String
        ' Get selected flavors as a comma-separated string
        Dim flavors As New List(Of String)
        If ChkMilo.Checked Then flavors.Add("Milo")
        If ChkCoklat.Checked Then flavors.Add("Coklat")
        If ChkKopi.Checked Then flavors.Add("Kopi")
        If ChkStrawberi.Checked Then flavors.Add("Strawberi")
        If ChkPisang.Checked Then flavors.Add("Pisang")
        Return String.Join(", ", flavors)
    End Function

    Private Sub SetSelectedFlavors(flavors As String)
        ' Set selected flavors based on a comma-separated string
        Dim flavorList = flavors.Split(", ")
        ChkMilo.Checked = flavorList.Contains("Milo")
        ChkCoklat.Checked = flavorList.Contains("Coklat")
        ChkKopi.Checked = flavorList.Contains("Kopi")
        ChkStrawberi.Checked = flavorList.Contains("Strawberi")
        ChkPisang.Checked = flavorList.Contains("Pisang")
    End Sub

    Private Sub ClearFields()
        ' Clear input fields
        txtNama.Clear()
        TxtNoTel.Clear()
        txtAlamat.Clear()
        CmbNegeri.SelectedIndex = -1
        RbLelaki.Checked = False
        RbWanita.Checked = False
        ChkMilo.Checked = False
        ChkCoklat.Checked = False
        ChkKopi.Checked = False
        ChkStrawberi.Checked = False
        ChkPisang.Checked = False
        RbCash.Checked = False
        RbCashless.Checked = False
    End Sub
End Class
