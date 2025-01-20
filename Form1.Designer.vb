<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblMaklumatPelanggan = New Label()
        lblNama = New Label()
        lblNotel = New Label()
        lblAlamat = New Label()
        lblNegeri = New Label()
        txtNama = New TextBox()
        txtNotel = New TextBox()
        txtAlamat = New TextBox()
        cmbNegeri = New ComboBox()
        gbxJantina = New GroupBox()
        RbtPerempuan = New RadioButton()
        RbtLelaki = New RadioButton()
        gbxPerisa = New GroupBox()
        RbtKopi = New RadioButton()
        RbtPisang = New RadioButton()
        RbtStrawberi = New RadioButton()
        RbtCoklat = New RadioButton()
        RbtMilo = New RadioButton()
        gbxKaedahbayaran = New GroupBox()
        RbtCashless = New RadioButton()
        RbtCash = New RadioButton()
        lblTarikh = New Label()
        dtpTarikh = New DateTimePicker()
        dgvMaklumat = New DataGridView()
        dgvBil = New DataGridViewTextBoxColumn()
        dgvNama = New DataGridViewTextBoxColumn()
        dgvNotel = New DataGridViewTextBoxColumn()
        BtnCreate = New Button()
        BtnRead = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        gbxJantina.SuspendLayout()
        gbxPerisa.SuspendLayout()
        gbxKaedahbayaran.SuspendLayout()
        CType(dgvMaklumat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMaklumatPelanggan
        ' 
        lblMaklumatPelanggan.AutoSize = True
        lblMaklumatPelanggan.Location = New Point(12, 9)
        lblMaklumatPelanggan.Name = "lblMaklumatPelanggan"
        lblMaklumatPelanggan.Size = New Size(177, 20)
        lblMaklumatPelanggan.TabIndex = 0
        lblMaklumatPelanggan.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(12, 42)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' lblNotel
        ' 
        lblNotel.AutoSize = True
        lblNotel.Location = New Point(12, 80)
        lblNotel.Name = "lblNotel"
        lblNotel.Size = New Size(55, 20)
        lblNotel.TabIndex = 2
        lblNotel.Text = "No. Tel"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(12, 123)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(57, 20)
        lblAlamat.TabIndex = 3
        lblAlamat.Text = "Alamat"
        ' 
        ' lblNegeri
        ' 
        lblNegeri.AutoSize = True
        lblNegeri.Location = New Point(12, 169)
        lblNegeri.Name = "lblNegeri"
        lblNegeri.Size = New Size(54, 20)
        lblNegeri.TabIndex = 4
        lblNegeri.Text = "Negeri"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(110, 39)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(467, 27)
        txtNama.TabIndex = 5
        ' 
        ' txtNotel
        ' 
        txtNotel.Location = New Point(110, 80)
        txtNotel.Name = "txtNotel"
        txtNotel.Size = New Size(467, 27)
        txtNotel.TabIndex = 6
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(110, 120)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(467, 34)
        txtAlamat.TabIndex = 7
        ' 
        ' cmbNegeri
        ' 
        cmbNegeri.FormattingEnabled = True
        cmbNegeri.Location = New Point(110, 166)
        cmbNegeri.Name = "cmbNegeri"
        cmbNegeri.Size = New Size(467, 28)
        cmbNegeri.TabIndex = 8
        ' 
        ' gbxJantina
        ' 
        gbxJantina.Controls.Add(RbtPerempuan)
        gbxJantina.Controls.Add(RbtLelaki)
        gbxJantina.Location = New Point(52, 246)
        gbxJantina.Name = "gbxJantina"
        gbxJantina.Size = New Size(200, 76)
        gbxJantina.TabIndex = 9
        gbxJantina.TabStop = False
        gbxJantina.Text = "Jantina"
        ' 
        ' RbtPerempuan
        ' 
        RbtPerempuan.AutoSize = True
        RbtPerempuan.Location = New Point(86, 38)
        RbtPerempuan.Name = "RbtPerempuan"
        RbtPerempuan.Size = New Size(104, 24)
        RbtPerempuan.TabIndex = 1
        RbtPerempuan.TabStop = True
        RbtPerempuan.Text = "Perempuan"
        RbtPerempuan.UseVisualStyleBackColor = True
        ' 
        ' RbtLelaki
        ' 
        RbtLelaki.AutoSize = True
        RbtLelaki.Location = New Point(12, 38)
        RbtLelaki.Name = "RbtLelaki"
        RbtLelaki.Size = New Size(68, 24)
        RbtLelaki.TabIndex = 0
        RbtLelaki.TabStop = True
        RbtLelaki.Text = "Lelaki"
        RbtLelaki.UseVisualStyleBackColor = True
        ' 
        ' gbxPerisa
        ' 
        gbxPerisa.Controls.Add(RbtKopi)
        gbxPerisa.Controls.Add(RbtPisang)
        gbxPerisa.Controls.Add(RbtStrawberi)
        gbxPerisa.Controls.Add(RbtCoklat)
        gbxPerisa.Controls.Add(RbtMilo)
        gbxPerisa.Location = New Point(288, 266)
        gbxPerisa.Name = "gbxPerisa"
        gbxPerisa.Size = New Size(231, 125)
        gbxPerisa.TabIndex = 10
        gbxPerisa.TabStop = False
        gbxPerisa.Text = "Perisa"
        ' 
        ' RbtKopi
        ' 
        RbtKopi.AutoSize = True
        RbtKopi.Location = New Point(149, 56)
        RbtKopi.Name = "RbtKopi"
        RbtKopi.Size = New Size(61, 24)
        RbtKopi.TabIndex = 4
        RbtKopi.TabStop = True
        RbtKopi.Text = "Kopi"
        RbtKopi.UseVisualStyleBackColor = True
        ' 
        ' RbtPisang
        ' 
        RbtPisang.AutoSize = True
        RbtPisang.Location = New Point(149, 26)
        RbtPisang.Name = "RbtPisang"
        RbtPisang.Size = New Size(73, 24)
        RbtPisang.TabIndex = 3
        RbtPisang.TabStop = True
        RbtPisang.Text = "Pisang"
        RbtPisang.UseVisualStyleBackColor = True
        ' 
        ' RbtStrawberi
        ' 
        RbtStrawberi.AutoSize = True
        RbtStrawberi.Location = New Point(6, 86)
        RbtStrawberi.Name = "RbtStrawberi"
        RbtStrawberi.Size = New Size(93, 24)
        RbtStrawberi.TabIndex = 2
        RbtStrawberi.TabStop = True
        RbtStrawberi.Text = "Strawberi"
        RbtStrawberi.UseVisualStyleBackColor = True
        ' 
        ' RbtCoklat
        ' 
        RbtCoklat.AutoSize = True
        RbtCoklat.Location = New Point(6, 56)
        RbtCoklat.Name = "RbtCoklat"
        RbtCoklat.Size = New Size(72, 24)
        RbtCoklat.TabIndex = 1
        RbtCoklat.TabStop = True
        RbtCoklat.Text = "Coklat"
        RbtCoklat.UseVisualStyleBackColor = True
        ' 
        ' RbtMilo
        ' 
        RbtMilo.AutoSize = True
        RbtMilo.Location = New Point(6, 26)
        RbtMilo.Name = "RbtMilo"
        RbtMilo.Size = New Size(60, 24)
        RbtMilo.TabIndex = 0
        RbtMilo.TabStop = True
        RbtMilo.Text = "Milo"
        RbtMilo.UseVisualStyleBackColor = True
        ' 
        ' gbxKaedahbayaran
        ' 
        gbxKaedahbayaran.Controls.Add(RbtCashless)
        gbxKaedahbayaran.Controls.Add(RbtCash)
        gbxKaedahbayaran.Location = New Point(52, 332)
        gbxKaedahbayaran.Name = "gbxKaedahbayaran"
        gbxKaedahbayaran.Size = New Size(200, 76)
        gbxKaedahbayaran.TabIndex = 11
        gbxKaedahbayaran.TabStop = False
        gbxKaedahbayaran.Text = "Kaedah Bayaran"
        ' 
        ' RbtCashless
        ' 
        RbtCashless.AutoSize = True
        RbtCashless.Location = New Point(86, 35)
        RbtCashless.Name = "RbtCashless"
        RbtCashless.Size = New Size(85, 24)
        RbtCashless.TabIndex = 1
        RbtCashless.TabStop = True
        RbtCashless.Text = "Cashless"
        RbtCashless.UseVisualStyleBackColor = True
        ' 
        ' RbtCash
        ' 
        RbtCash.AutoSize = True
        RbtCash.Location = New Point(12, 35)
        RbtCash.Name = "RbtCash"
        RbtCash.Size = New Size(61, 24)
        RbtCash.TabIndex = 0
        RbtCash.TabStop = True
        RbtCash.Text = "Cash"
        RbtCash.UseVisualStyleBackColor = True
        ' 
        ' lblTarikh
        ' 
        lblTarikh.AutoSize = True
        lblTarikh.Location = New Point(14, 213)
        lblTarikh.Name = "lblTarikh"
        lblTarikh.Size = New Size(47, 20)
        lblTarikh.TabIndex = 12
        lblTarikh.Text = "Tarikh"
        ' 
        ' dtpTarikh
        ' 
        dtpTarikh.Location = New Point(110, 213)
        dtpTarikh.Name = "dtpTarikh"
        dtpTarikh.Size = New Size(467, 27)
        dtpTarikh.TabIndex = 13
        ' 
        ' dgvMaklumat
        ' 
        dgvMaklumat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMaklumat.Columns.AddRange(New DataGridViewColumn() {dgvBil, dgvNama, dgvNotel})
        dgvMaklumat.Location = New Point(23, 419)
        dgvMaklumat.Name = "dgvMaklumat"
        dgvMaklumat.RowHeadersWidth = 51
        dgvMaklumat.Size = New Size(554, 82)
        dgvMaklumat.TabIndex = 14
        ' 
        ' dgvBil
        ' 
        dgvBil.HeaderText = "Bil"
        dgvBil.MinimumWidth = 6
        dgvBil.Name = "dgvBil"
        dgvBil.Width = 50
        ' 
        ' dgvNama
        ' 
        dgvNama.HeaderText = "Nama"
        dgvNama.MinimumWidth = 6
        dgvNama.Name = "dgvNama"
        dgvNama.Width = 250
        ' 
        ' dgvNotel
        ' 
        dgvNotel.HeaderText = "No. Tel"
        dgvNotel.MinimumWidth = 6
        dgvNotel.Name = "dgvNotel"
        dgvNotel.Width = 200
        ' 
        ' BtnCreate
        ' 
        BtnCreate.Location = New Point(40, 519)
        BtnCreate.Name = "BtnCreate"
        BtnCreate.Size = New Size(94, 29)
        BtnCreate.TabIndex = 15
        BtnCreate.Text = "Create"
        BtnCreate.UseVisualStyleBackColor = True
        ' 
        ' BtnRead
        ' 
        BtnRead.Location = New Point(158, 519)
        BtnRead.Name = "BtnRead"
        BtnRead.Size = New Size(94, 29)
        BtnRead.TabIndex = 16
        BtnRead.Text = "Read"
        BtnRead.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(288, 519)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(94, 29)
        BtnUpdate.TabIndex = 17
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(415, 519)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(94, 29)
        BtnDelete.TabIndex = 18
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(603, 560)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnRead)
        Controls.Add(BtnCreate)
        Controls.Add(dgvMaklumat)
        Controls.Add(dtpTarikh)
        Controls.Add(lblTarikh)
        Controls.Add(gbxKaedahbayaran)
        Controls.Add(gbxPerisa)
        Controls.Add(gbxJantina)
        Controls.Add(cmbNegeri)
        Controls.Add(txtAlamat)
        Controls.Add(txtNotel)
        Controls.Add(txtNama)
        Controls.Add(lblNegeri)
        Controls.Add(lblAlamat)
        Controls.Add(lblNotel)
        Controls.Add(lblNama)
        Controls.Add(lblMaklumatPelanggan)
        Name = "Form1"
        Text = "MAKLUMAT PELANGGAN"
        gbxJantina.ResumeLayout(False)
        gbxJantina.PerformLayout()
        gbxPerisa.ResumeLayout(False)
        gbxPerisa.PerformLayout()
        gbxKaedahbayaran.ResumeLayout(False)
        gbxKaedahbayaran.PerformLayout()
        CType(dgvMaklumat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMaklumatPelanggan As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNotel As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblNegeri As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNotel As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents cmbNegeri As ComboBox
    Friend WithEvents gbxJantina As GroupBox
    Friend WithEvents RbtPerempuan As RadioButton
    Friend WithEvents RbtLelaki As RadioButton
    Friend WithEvents gbxPerisa As GroupBox
    Friend WithEvents RbtStrawberi As RadioButton
    Friend WithEvents RbtCoklat As RadioButton
    Friend WithEvents RbtMilo As RadioButton
    Friend WithEvents RbtKopi As RadioButton
    Friend WithEvents RbtPisang As RadioButton
    Friend WithEvents gbxKaedahbayaran As GroupBox
    Friend WithEvents RbtCashless As RadioButton
    Friend WithEvents RbtCash As RadioButton
    Friend WithEvents lblTarikh As Label
    Friend WithEvents dtpTarikh As DateTimePicker
    Friend WithEvents dgvMaklumat As DataGridView
    Friend WithEvents dgvBil As DataGridViewTextBoxColumn
    Friend WithEvents dgvNama As DataGridViewTextBoxColumn
    Friend WithEvents dgvNotel As DataGridViewTextBoxColumn
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button

End Class
