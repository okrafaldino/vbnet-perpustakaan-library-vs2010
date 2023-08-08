<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtamaAnggota
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtamaAnggota))
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblSelected1 = New System.Windows.Forms.Label()
        Me.lblKodeUser = New System.Windows.Forms.Label()
        Me.lblNamaUser = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSelected4 = New System.Windows.Forms.Label()
        Me.lblSelected3 = New System.Windows.Forms.Label()
        Me.lblSelected2 = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.pnlClose = New System.Windows.Forms.Panel()
        Me.pnlDasboard = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlInformasi = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlTentang = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTextSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnAvatar = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnTentangSaya = New System.Windows.Forms.Button()
        Me.btnDataMaster = New System.Windows.Forms.Button()
        Me.pnlLeft.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlClose.SuspendLayout()
        Me.pnlDasboard.SuspendLayout()
        Me.pnlInformasi.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTentang.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlLeft.Controls.Add(Me.lblSelected1)
        Me.pnlLeft.Controls.Add(Me.btnDashboard)
        Me.pnlLeft.Controls.Add(Me.lblKodeUser)
        Me.pnlLeft.Controls.Add(Me.lblNamaUser)
        Me.pnlLeft.Controls.Add(Me.Label5)
        Me.pnlLeft.Controls.Add(Me.lblStatus)
        Me.pnlLeft.Controls.Add(Me.Label2)
        Me.pnlLeft.Controls.Add(Me.Label1)
        Me.pnlLeft.Controls.Add(Me.btnAvatar)
        Me.pnlLeft.Controls.Add(Me.Panel1)
        Me.pnlLeft.Controls.Add(Me.lblSelected3)
        Me.pnlLeft.Controls.Add(Me.btnTentangSaya)
        Me.pnlLeft.Controls.Add(Me.lblSelected2)
        Me.pnlLeft.Controls.Add(Me.btnDataMaster)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(287, 461)
        Me.pnlLeft.TabIndex = 1
        '
        'lblSelected1
        '
        Me.lblSelected1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSelected1.Location = New System.Drawing.Point(-1, 143)
        Me.lblSelected1.Name = "lblSelected1"
        Me.lblSelected1.Size = New System.Drawing.Size(5, 20)
        Me.lblSelected1.TabIndex = 19
        Me.lblSelected1.Visible = False
        '
        'lblKodeUser
        '
        Me.lblKodeUser.AutoSize = True
        Me.lblKodeUser.Font = New System.Drawing.Font("Hack", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeUser.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblKodeUser.Location = New System.Drawing.Point(205, 18)
        Me.lblKodeUser.Name = "lblKodeUser"
        Me.lblKodeUser.Size = New System.Drawing.Size(63, 13)
        Me.lblKodeUser.TabIndex = 17
        Me.lblKodeUser.Text = "KodeUser"
        '
        'lblNamaUser
        '
        Me.lblNamaUser.AutoSize = True
        Me.lblNamaUser.Font = New System.Drawing.Font("Hack", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaUser.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblNamaUser.Location = New System.Drawing.Point(99, 41)
        Me.lblNamaUser.Name = "lblNamaUser"
        Me.lblNamaUser.Size = New System.Drawing.Size(63, 13)
        Me.lblNamaUser.TabIndex = 17
        Me.lblNamaUser.Text = "NamaUser"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(101, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 1)
        Me.Label5.TabIndex = 16
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Hack", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStatus.Location = New System.Drawing.Point(99, 71)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(49, 13)
        Me.lblStatus.TabIndex = 16
        Me.lblStatus.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Hack", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(98, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Selamat datang,"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Hack", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(8, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Menu Utama"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblSelected4)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 397)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 64)
        Me.Panel1.TabIndex = 14
        '
        'lblSelected4
        '
        Me.lblSelected4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSelected4.Location = New System.Drawing.Point(0, 23)
        Me.lblSelected4.Name = "lblSelected4"
        Me.lblSelected4.Size = New System.Drawing.Size(5, 20)
        Me.lblSelected4.TabIndex = 11
        Me.lblSelected4.Visible = False
        '
        'lblSelected3
        '
        Me.lblSelected3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSelected3.Location = New System.Drawing.Point(-1, 225)
        Me.lblSelected3.Name = "lblSelected3"
        Me.lblSelected3.Size = New System.Drawing.Size(5, 20)
        Me.lblSelected3.TabIndex = 9
        Me.lblSelected3.Visible = False
        '
        'lblSelected2
        '
        Me.lblSelected2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSelected2.Location = New System.Drawing.Point(-1, 184)
        Me.lblSelected2.Name = "lblSelected2"
        Me.lblSelected2.Size = New System.Drawing.Size(5, 20)
        Me.lblSelected2.TabIndex = 1
        Me.lblSelected2.Visible = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Silver
        Me.pnlTop.Controls.Add(Me.lblTanggal)
        Me.pnlTop.Controls.Add(Me.lblJam)
        Me.pnlTop.Controls.Add(Me.pnlClose)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(287, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(819, 43)
        Me.pnlTop.TabIndex = 2
        '
        'lblTanggal
        '
        Me.lblTanggal.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblTanggal.Font = New System.Drawing.Font("Hack", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTanggal.Location = New System.Drawing.Point(102, 9)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(96, 23)
        Me.lblTanggal.TabIndex = 1
        Me.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJam
        '
        Me.lblJam.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblJam.Font = New System.Drawing.Font("Hack", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJam.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblJam.Location = New System.Drawing.Point(16, 10)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(80, 23)
        Me.lblJam.TabIndex = 1
        Me.lblJam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlClose
        '
        Me.pnlClose.Controls.Add(Me.btnClose)
        Me.pnlClose.Controls.Add(Me.btnMaximize)
        Me.pnlClose.Controls.Add(Me.btnMinimize)
        Me.pnlClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlClose.Location = New System.Drawing.Point(702, 0)
        Me.pnlClose.Name = "pnlClose"
        Me.pnlClose.Size = New System.Drawing.Size(117, 43)
        Me.pnlClose.TabIndex = 0
        '
        'pnlDasboard
        '
        Me.pnlDasboard.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlDasboard.Controls.Add(Me.Panel2)
        Me.pnlDasboard.Controls.Add(Me.Label13)
        Me.pnlDasboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDasboard.Location = New System.Drawing.Point(287, 43)
        Me.pnlDasboard.Name = "pnlDasboard"
        Me.pnlDasboard.Size = New System.Drawing.Size(819, 418)
        Me.pnlDasboard.TabIndex = 29
        Me.pnlDasboard.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Hack", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(18, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 22)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Dashboard"
        '
        'pnlInformasi
        '
        Me.pnlInformasi.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlInformasi.Controls.Add(Me.Label4)
        Me.pnlInformasi.Controls.Add(Me.Panel3)
        Me.pnlInformasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInformasi.Location = New System.Drawing.Point(287, 43)
        Me.pnlInformasi.Name = "pnlInformasi"
        Me.pnlInformasi.Size = New System.Drawing.Size(819, 418)
        Me.pnlInformasi.TabIndex = 31
        Me.pnlInformasi.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(729, 274)
        Me.DataGridView1.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Hack", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 22)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Informasi"
        '
        'pnlTentang
        '
        Me.pnlTentang.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTentang.Controls.Add(Me.Label8)
        Me.pnlTentang.Controls.Add(Me.Label6)
        Me.pnlTentang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTentang.Location = New System.Drawing.Point(287, 43)
        Me.pnlTentang.Name = "pnlTentang"
        Me.pnlTentang.Size = New System.Drawing.Size(819, 418)
        Me.pnlTentang.TabIndex = 32
        Me.pnlTentang.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Hack", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(18, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 22)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Tentang Aplikasi"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblTextSearch)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Location = New System.Drawing.Point(17, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(783, 339)
        Me.Panel2.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, -3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(754, 45)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Silahkan ketik judul, pengarang, penerbit, atau kategori buku yang Anda cari, d" & _
            "an aplikasi ini akan memberikan saran yang sesuai untuk membantu Anda menemukan " & _
            "buku yang tepat." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTextSearch
        '
        Me.lblTextSearch.Location = New System.Drawing.Point(3, 46)
        Me.lblTextSearch.Multiline = True
        Me.lblTextSearch.Name = "lblTextSearch"
        Me.lblTextSearch.Size = New System.Drawing.Size(724, 39)
        Me.lblTextSearch.TabIndex = 29
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(8, 91)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(761, 191)
        Me.DataGridView2.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Location = New System.Drawing.Point(19, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(774, 344)
        Me.Panel3.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Hack", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(20, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(539, 14)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Berikut Informasi Mengenai Buku Yang Telah Anda Pinjam dan Tenggat Waktu nya"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Hack", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(739, 115)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Silver
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_search_30
        Me.btnSearch.Location = New System.Drawing.Point(731, 46)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(43, 39)
        Me.btnSearch.TabIndex = 31
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_macos_close_18
        Me.btnClose.Location = New System.Drawing.Point(80, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(18, 18)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_macos_full_screen_18
        Me.btnMaximize.Location = New System.Drawing.Point(58, 13)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(18, 18)
        Me.btnMaximize.TabIndex = 0
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_macos_minimize_18
        Me.btnMinimize.Location = New System.Drawing.Point(34, 13)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(18, 18)
        Me.btnMinimize.TabIndex = 0
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Hack", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDashboard.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_home_page_30__2_
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 136)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(270, 35)
        Me.btnDashboard.TabIndex = 18
        Me.btnDashboard.Text = "    Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'btnAvatar
        '
        Me.btnAvatar.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAvatar.FlatAppearance.BorderSize = 0
        Me.btnAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvatar.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_cat_profile_80__1_
        Me.btnAvatar.Location = New System.Drawing.Point(12, 13)
        Me.btnAvatar.Name = "btnAvatar"
        Me.btnAvatar.Size = New System.Drawing.Size(80, 80)
        Me.btnAvatar.TabIndex = 15
        Me.btnAvatar.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Hack", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogout.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_logout_30
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 14)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(270, 35)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "   Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnTentangSaya
        '
        Me.btnTentangSaya.FlatAppearance.BorderSize = 0
        Me.btnTentangSaya.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTentangSaya.Font = New System.Drawing.Font("Hack", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTentangSaya.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTentangSaya.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_about_30
        Me.btnTentangSaya.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTentangSaya.Location = New System.Drawing.Point(0, 218)
        Me.btnTentangSaya.Name = "btnTentangSaya"
        Me.btnTentangSaya.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnTentangSaya.Size = New System.Drawing.Size(270, 35)
        Me.btnTentangSaya.TabIndex = 8
        Me.btnTentangSaya.Text = "    Tentang Aplikasi"
        Me.btnTentangSaya.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTentangSaya.UseVisualStyleBackColor = True
        '
        'btnDataMaster
        '
        Me.btnDataMaster.FlatAppearance.BorderSize = 0
        Me.btnDataMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDataMaster.Font = New System.Drawing.Font("Hack", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataMaster.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDataMaster.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_folder_30__1_
        Me.btnDataMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDataMaster.Location = New System.Drawing.Point(0, 177)
        Me.btnDataMaster.Name = "btnDataMaster"
        Me.btnDataMaster.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnDataMaster.Size = New System.Drawing.Size(270, 35)
        Me.btnDataMaster.TabIndex = 0
        Me.btnDataMaster.Text = "    Informasi"
        Me.btnDataMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDataMaster.UseVisualStyleBackColor = True
        '
        'FormMenuUtamaAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1106, 461)
        Me.Controls.Add(Me.pnlDasboard)
        Me.Controls.Add(Me.pnlTentang)
        Me.Controls.Add(Me.pnlInformasi)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuUtamaAnggota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenuUtamaAnggota"
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlClose.ResumeLayout(False)
        Me.pnlDasboard.ResumeLayout(False)
        Me.pnlDasboard.PerformLayout()
        Me.pnlInformasi.ResumeLayout(False)
        Me.pnlInformasi.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTentang.ResumeLayout(False)
        Me.pnlTentang.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblSelected1 As System.Windows.Forms.Label
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents lblKodeUser As System.Windows.Forms.Label
    Friend WithEvents lblNamaUser As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAvatar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSelected4 As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents lblSelected3 As System.Windows.Forms.Label
    Friend WithEvents btnTentangSaya As System.Windows.Forms.Button
    Friend WithEvents lblSelected2 As System.Windows.Forms.Label
    Friend WithEvents btnDataMaster As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents lblJam As System.Windows.Forms.Label
    Friend WithEvents pnlClose As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMaximize As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents pnlDasboard As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pnlInformasi As System.Windows.Forms.Panel
    Friend WithEvents pnlTentang As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTextSearch As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
