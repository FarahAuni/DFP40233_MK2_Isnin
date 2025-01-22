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
        RbtWanita = New RadioButton()
        RbtLelaki = New RadioButton()
        gbxPerisa = New GroupBox()
        cbxPisang = New CheckBox()
        cbxStrawberi = New CheckBox()
        cbxCoklat = New CheckBox()
        cbxKopi = New CheckBox()
        cbxMilo = New CheckBox()
        gbxKaedahbayaran = New GroupBox()
        RbtCashless = New RadioButton()
        RbtCash = New RadioButton()
        lblTarikh = New Label()
        dtpTarikh = New DateTimePicker()
        dgvMaklumat = New DataGridView()
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
        txtNama.Size = New Size(409, 27)
        txtNama.TabIndex = 5
        ' 
        ' txtNotel
        ' 
        txtNotel.Location = New Point(110, 80)
        txtNotel.Name = "txtNotel"
        txtNotel.Size = New Size(409, 27)
        txtNotel.TabIndex = 6
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(110, 120)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(409, 27)
        txtAlamat.TabIndex = 7
        ' 
        ' cmbNegeri
        ' 
        cmbNegeri.FormattingEnabled = True
        cmbNegeri.Items.AddRange(New Object() {"Perlis", "Kedah ", "Pulau Pinang", "Melaka", "Selangor", "Perak", "Negeri Sembilan", "Johor", "Pahang", "Terengganu", "Kelantan", "Sabah", "Sarawak", "Wilayah Persekutuan"})
        cmbNegeri.Location = New Point(110, 166)
        cmbNegeri.Name = "cmbNegeri"
        cmbNegeri.Size = New Size(409, 28)
        cmbNegeri.TabIndex = 8
        ' 
        ' gbxJantina
        ' 
        gbxJantina.Controls.Add(RbtWanita)
        gbxJantina.Controls.Add(RbtLelaki)
        gbxJantina.Location = New Point(52, 246)
        gbxJantina.Name = "gbxJantina"
        gbxJantina.Size = New Size(200, 76)
        gbxJantina.TabIndex = 9
        gbxJantina.TabStop = False
        gbxJantina.Text = "Jantina"
        ' 
        ' RbtWanita
        ' 
        RbtWanita.AutoSize = True
        RbtWanita.Location = New Point(86, 38)
        RbtWanita.Name = "RbtWanita"
        RbtWanita.Size = New Size(76, 24)
        RbtWanita.TabIndex = 1
        RbtWanita.TabStop = True
        RbtWanita.Text = "Wanita"
        RbtWanita.UseVisualStyleBackColor = True
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
        gbxPerisa.Controls.Add(cbxPisang)
        gbxPerisa.Controls.Add(cbxStrawberi)
        gbxPerisa.Controls.Add(cbxCoklat)
        gbxPerisa.Controls.Add(cbxKopi)
        gbxPerisa.Controls.Add(cbxMilo)
        gbxPerisa.Location = New Point(288, 266)
        gbxPerisa.Name = "gbxPerisa"
        gbxPerisa.Size = New Size(231, 125)
        gbxPerisa.TabIndex = 10
        gbxPerisa.TabStop = False
        gbxPerisa.Text = "Perisa"
        ' 
        ' cbxPisang
        ' 
        cbxPisang.AutoSize = True
        cbxPisang.Location = New Point(101, 56)
        cbxPisang.Name = "cbxPisang"
        cbxPisang.Size = New Size(74, 24)
        cbxPisang.TabIndex = 4
        cbxPisang.Text = "Pisang"
        cbxPisang.UseVisualStyleBackColor = True
        ' 
        ' cbxStrawberi
        ' 
        cbxStrawberi.AutoSize = True
        cbxStrawberi.Location = New Point(101, 26)
        cbxStrawberi.Name = "cbxStrawberi"
        cbxStrawberi.Size = New Size(94, 24)
        cbxStrawberi.TabIndex = 3
        cbxStrawberi.Text = "Strawberi"
        cbxStrawberi.UseVisualStyleBackColor = True
        ' 
        ' cbxCoklat
        ' 
        cbxCoklat.AutoSize = True
        cbxCoklat.Location = New Point(6, 86)
        cbxCoklat.Name = "cbxCoklat"
        cbxCoklat.Size = New Size(73, 24)
        cbxCoklat.TabIndex = 2
        cbxCoklat.Text = "Coklat"
        cbxCoklat.UseVisualStyleBackColor = True
        ' 
        ' cbxKopi
        ' 
        cbxKopi.AutoSize = True
        cbxKopi.Location = New Point(6, 56)
        cbxKopi.Name = "cbxKopi"
        cbxKopi.Size = New Size(62, 24)
        cbxKopi.TabIndex = 1
        cbxKopi.Text = "Kopi"
        cbxKopi.UseVisualStyleBackColor = True
        ' 
        ' cbxMilo
        ' 
        cbxMilo.AutoSize = True
        cbxMilo.Location = New Point(6, 26)
        cbxMilo.Name = "cbxMilo"
        cbxMilo.Size = New Size(61, 24)
        cbxMilo.TabIndex = 0
        cbxMilo.Text = "Milo"
        cbxMilo.UseVisualStyleBackColor = True
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
        dtpTarikh.Size = New Size(245, 27)
        dtpTarikh.TabIndex = 13
        ' 
        ' dgvMaklumat
        ' 
        dgvMaklumat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMaklumat.Location = New Point(57, 414)
        dgvMaklumat.Name = "dgvMaklumat"
        dgvMaklumat.RowHeadersWidth = 51
        dgvMaklumat.Size = New Size(436, 82)
        dgvMaklumat.TabIndex = 14
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
        ClientSize = New Size(536, 560)
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
    Friend WithEvents RbtWanita As RadioButton
    Friend WithEvents RbtLelaki As RadioButton
    Friend WithEvents gbxPerisa As GroupBox
    Friend WithEvents gbxKaedahbayaran As GroupBox
    Friend WithEvents RbtCashless As RadioButton
    Friend WithEvents RbtCash As RadioButton
    Friend WithEvents lblTarikh As Label
    Friend WithEvents dtpTarikh As DateTimePicker
    Friend WithEvents dgvMaklumat As DataGridView
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents cbxPisang As CheckBox
    Friend WithEvents cbxStrawberi As CheckBox
    Friend WithEvents cbxCoklat As CheckBox
    Friend WithEvents cbxKopi As CheckBox
    Friend WithEvents cbxMilo As CheckBox

End Class
