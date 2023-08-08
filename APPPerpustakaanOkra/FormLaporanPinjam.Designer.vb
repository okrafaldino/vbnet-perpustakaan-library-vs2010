<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPinjam
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetPinjam = New WindowsApplication1.DataSetPinjam()
        Me.dataPinjamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSetPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataPinjamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetPinjam"
        ReportDataSource1.Value = Me.dataPinjamBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.ReportPinjam.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(648, 472)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetPinjam
        '
        Me.DataSetPinjam.DataSetName = "DataSetPinjam"
        Me.DataSetPinjam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dataPinjamBindingSource
        '
        Me.dataPinjamBindingSource.DataMember = "dataPinjam"
        Me.dataPinjamBindingSource.DataSource = Me.DataSetPinjam
        '
        'FormLaporanPinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 472)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLaporanPinjam"
        Me.Text = "FormLaporanPinjam"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSetPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataPinjamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dataPinjamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetPinjam As WindowsApplication1.DataSetPinjam
End Class
