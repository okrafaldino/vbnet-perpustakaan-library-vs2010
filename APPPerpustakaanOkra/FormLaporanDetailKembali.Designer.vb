<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanDetailKembali
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
        Me.DataSetDetailKembali = New WindowsApplication1.DataSetDetailKembali()
        Me.dataDetailKembaliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSetDetailKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataDetailKembaliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetDetailKembali"
        ReportDataSource1.Value = Me.dataDetailKembaliBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.ReportDetailKembali.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(637, 412)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetDetailKembali
        '
        Me.DataSetDetailKembali.DataSetName = "DataSetDetailKembali"
        Me.DataSetDetailKembali.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dataDetailKembaliBindingSource
        '
        Me.dataDetailKembaliBindingSource.DataMember = "dataDetailKembali"
        Me.dataDetailKembaliBindingSource.DataSource = Me.DataSetDetailKembali
        '
        'FormLaporanDetailKembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 412)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLaporanDetailKembali"
        Me.Text = "FormLaporanDetailKembali"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSetDetailKembali, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataDetailKembaliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dataDetailKembaliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetDetailKembali As WindowsApplication1.DataSetDetailKembali
End Class
