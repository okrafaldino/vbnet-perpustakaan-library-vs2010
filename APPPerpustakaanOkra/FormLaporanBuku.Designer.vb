<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanBuku
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
        Me.DataSetBuku = New WindowsApplication1.DataSetBuku()
        Me.dataBukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSetBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataBukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetBuku"
        ReportDataSource1.Value = Me.dataBukuBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.ReportBuku.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(558, 405)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetBuku
        '
        Me.DataSetBuku.DataSetName = "DataSetBuku"
        Me.DataSetBuku.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dataBukuBindingSource
        '
        Me.dataBukuBindingSource.DataMember = "dataBuku"
        Me.dataBukuBindingSource.DataSource = Me.DataSetBuku
        '
        'FormLaporanBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 405)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLaporanBuku"
        Me.Text = "FormLaporanBuku"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSetBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataBukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dataBukuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetBuku As WindowsApplication1.DataSetBuku
End Class
