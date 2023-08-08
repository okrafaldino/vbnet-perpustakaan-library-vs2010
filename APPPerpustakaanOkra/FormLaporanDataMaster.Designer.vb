<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanDataMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblBtnKat = New System.Windows.Forms.Label()
        Me.lblBtnRak = New System.Windows.Forms.Label()
        Me.lblBtnBuku = New System.Windows.Forms.Label()
        Me.lblBtnAnggota = New System.Windows.Forms.Label()
        Me.lblBtnPetugas = New System.Windows.Forms.Label()
        Me.btnKategoriBuku = New System.Windows.Forms.Button()
        Me.btnRakBuku = New System.Windows.Forms.Button()
        Me.btnBuku = New System.Windows.Forms.Button()
        Me.btnAnggota = New System.Windows.Forms.Button()
        Me.btnPetugas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBtnKat
        '
        Me.lblBtnKat.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblBtnKat.Font = New System.Drawing.Font("Hack", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBtnKat.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBtnKat.Location = New System.Drawing.Point(254, 356)
        Me.lblBtnKat.Name = "lblBtnKat"
        Me.lblBtnKat.Size = New System.Drawing.Size(120, 23)
        Me.lblBtnKat.TabIndex = 34
        Me.lblBtnKat.Text = "Kategori Buku"
        Me.lblBtnKat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBtnRak
        '
        Me.lblBtnRak.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblBtnRak.Font = New System.Drawing.Font("Hack", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBtnRak.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBtnRak.Location = New System.Drawing.Point(52, 356)
        Me.lblBtnRak.Name = "lblBtnRak"
        Me.lblBtnRak.Size = New System.Drawing.Size(120, 23)
        Me.lblBtnRak.TabIndex = 32
        Me.lblBtnRak.Text = "Rak Buku"
        Me.lblBtnRak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBtnBuku
        '
        Me.lblBtnBuku.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblBtnBuku.Font = New System.Drawing.Font("Hack", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBtnBuku.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBtnBuku.Location = New System.Drawing.Point(456, 158)
        Me.lblBtnBuku.Name = "lblBtnBuku"
        Me.lblBtnBuku.Size = New System.Drawing.Size(120, 23)
        Me.lblBtnBuku.TabIndex = 30
        Me.lblBtnBuku.Text = "Buku"
        Me.lblBtnBuku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBtnAnggota
        '
        Me.lblBtnAnggota.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblBtnAnggota.Font = New System.Drawing.Font("Hack", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBtnAnggota.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBtnAnggota.Location = New System.Drawing.Point(254, 158)
        Me.lblBtnAnggota.Name = "lblBtnAnggota"
        Me.lblBtnAnggota.Size = New System.Drawing.Size(120, 23)
        Me.lblBtnAnggota.TabIndex = 28
        Me.lblBtnAnggota.Text = "Anggota"
        Me.lblBtnAnggota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBtnPetugas
        '
        Me.lblBtnPetugas.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblBtnPetugas.Font = New System.Drawing.Font("Hack", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBtnPetugas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBtnPetugas.Location = New System.Drawing.Point(52, 158)
        Me.lblBtnPetugas.Name = "lblBtnPetugas"
        Me.lblBtnPetugas.Size = New System.Drawing.Size(120, 23)
        Me.lblBtnPetugas.TabIndex = 26
        Me.lblBtnPetugas.Text = "Petugas"
        Me.lblBtnPetugas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnKategoriBuku
        '
        Me.btnKategoriBuku.BackColor = System.Drawing.Color.Silver
        Me.btnKategoriBuku.FlatAppearance.BorderSize = 0
        Me.btnKategoriBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKategoriBuku.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_repository_801
        Me.btnKategoriBuku.Location = New System.Drawing.Point(254, 243)
        Me.btnKategoriBuku.Name = "btnKategoriBuku"
        Me.btnKategoriBuku.Size = New System.Drawing.Size(120, 120)
        Me.btnKategoriBuku.TabIndex = 33
        Me.btnKategoriBuku.UseVisualStyleBackColor = False
        '
        'btnRakBuku
        '
        Me.btnRakBuku.BackColor = System.Drawing.Color.Silver
        Me.btnRakBuku.FlatAppearance.BorderSize = 0
        Me.btnRakBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRakBuku.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_stack_80
        Me.btnRakBuku.Location = New System.Drawing.Point(52, 243)
        Me.btnRakBuku.Name = "btnRakBuku"
        Me.btnRakBuku.Size = New System.Drawing.Size(120, 120)
        Me.btnRakBuku.TabIndex = 31
        Me.btnRakBuku.UseVisualStyleBackColor = False
        '
        'btnBuku
        '
        Me.btnBuku.BackColor = System.Drawing.Color.Silver
        Me.btnBuku.FlatAppearance.BorderSize = 0
        Me.btnBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuku.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_book_stack_80
        Me.btnBuku.Location = New System.Drawing.Point(456, 45)
        Me.btnBuku.Name = "btnBuku"
        Me.btnBuku.Size = New System.Drawing.Size(120, 120)
        Me.btnBuku.TabIndex = 29
        Me.btnBuku.UseVisualStyleBackColor = False
        '
        'btnAnggota
        '
        Me.btnAnggota.BackColor = System.Drawing.Color.Silver
        Me.btnAnggota.FlatAppearance.BorderSize = 0
        Me.btnAnggota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnggota.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_badge_80
        Me.btnAnggota.Location = New System.Drawing.Point(254, 45)
        Me.btnAnggota.Name = "btnAnggota"
        Me.btnAnggota.Size = New System.Drawing.Size(120, 120)
        Me.btnAnggota.TabIndex = 27
        Me.btnAnggota.UseVisualStyleBackColor = False
        '
        'btnPetugas
        '
        Me.btnPetugas.BackColor = System.Drawing.Color.Silver
        Me.btnPetugas.FlatAppearance.BorderSize = 0
        Me.btnPetugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPetugas.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_users_80
        Me.btnPetugas.Location = New System.Drawing.Point(52, 45)
        Me.btnPetugas.Name = "btnPetugas"
        Me.btnPetugas.Size = New System.Drawing.Size(120, 120)
        Me.btnPetugas.TabIndex = 25
        Me.btnPetugas.UseVisualStyleBackColor = False
        '
        'FormLaporanDataMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 424)
        Me.Controls.Add(Me.lblBtnKat)
        Me.Controls.Add(Me.btnKategoriBuku)
        Me.Controls.Add(Me.lblBtnRak)
        Me.Controls.Add(Me.btnRakBuku)
        Me.Controls.Add(Me.lblBtnBuku)
        Me.Controls.Add(Me.btnBuku)
        Me.Controls.Add(Me.lblBtnAnggota)
        Me.Controls.Add(Me.btnAnggota)
        Me.Controls.Add(Me.lblBtnPetugas)
        Me.Controls.Add(Me.btnPetugas)
        Me.Name = "FormLaporanDataMaster"
        Me.Text = "FormLaporanDataMaster"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBtnKat As System.Windows.Forms.Label
    Friend WithEvents btnKategoriBuku As System.Windows.Forms.Button
    Friend WithEvents lblBtnRak As System.Windows.Forms.Label
    Friend WithEvents btnRakBuku As System.Windows.Forms.Button
    Friend WithEvents lblBtnBuku As System.Windows.Forms.Label
    Friend WithEvents btnBuku As System.Windows.Forms.Button
    Friend WithEvents lblBtnAnggota As System.Windows.Forms.Label
    Friend WithEvents btnAnggota As System.Windows.Forms.Button
    Friend WithEvents lblBtnPetugas As System.Windows.Forms.Label
    Friend WithEvents btnPetugas As System.Windows.Forms.Button
End Class
