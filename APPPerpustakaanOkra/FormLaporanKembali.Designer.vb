<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanKembali
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
        Me.DataSetKembali = New WindowsApplication1.DataSetKembali()
        Me.dataKembaliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSetKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataKembaliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetKembali"
        ReportDataSource1.Value = Me.dataKembaliBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.ReportKembali.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(675, 460)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetKembali
        '
        Me.DataSetKembali.DataSetName = "DataSetKembali"
        Me.DataSetKembali.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dataKembaliBindingSource
        '
        Me.dataKembaliBindingSource.DataMember = "dataKembali"
        Me.dataKembaliBindingSource.DataSource = Me.DataSetKembali
        '
        'FormLaporanKembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 460)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLaporanKembali"
        Me.Text = "FormLaporanKembali"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSetKembali, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataKembaliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dataKembaliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetKembali As WindowsApplication1.DataSetKembali
End Class
