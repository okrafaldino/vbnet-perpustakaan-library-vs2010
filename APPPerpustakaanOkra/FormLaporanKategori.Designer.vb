<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanKategori
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
        Me.DataSetKategori = New WindowsApplication1.DataSetKategori()
        Me.dataKategoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSetKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataKategoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetKategori"
        ReportDataSource1.Value = Me.dataKategoriBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.ReportKategori.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(649, 422)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetKategori
        '
        Me.DataSetKategori.DataSetName = "DataSetKategori"
        Me.DataSetKategori.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dataKategoriBindingSource
        '
        Me.dataKategoriBindingSource.DataMember = "dataKategori"
        Me.dataKategoriBindingSource.DataSource = Me.DataSetKategori
        '
        'FormLaporanKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 422)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLaporanKategori"
        Me.Text = "FormLaporanKategori"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSetKategori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataKategoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dataKategoriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetKategori As WindowsApplication1.DataSetKategori
End Class
