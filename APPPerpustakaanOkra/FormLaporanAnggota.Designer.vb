<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanAnggota
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
        Me.DataSetAnggota = New WindowsApplication1.DataSetAnggota()
        Me.dataAnggotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSetAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataAnggotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetAnggota"
        ReportDataSource1.Value = Me.dataAnggotaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.ReportAnggota.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(541, 391)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetAnggota
        '
        Me.DataSetAnggota.DataSetName = "DataSetAnggota"
        Me.DataSetAnggota.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dataAnggotaBindingSource
        '
        Me.dataAnggotaBindingSource.DataMember = "dataAnggota"
        Me.dataAnggotaBindingSource.DataSource = Me.DataSetAnggota
        '
        'FormLaporanAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 391)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLaporanAnggota"
        Me.Text = "FormLaporanAnggota"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSetAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataAnggotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dataAnggotaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetAnggota As WindowsApplication1.DataSetAnggota
End Class
