<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaformDirectlyApplyKeyValue
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
        Me.flowlayoutpanelBox = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'flowlayoutpanelBox
        '
        Me.flowlayoutpanelBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowlayoutpanelBox.Location = New System.Drawing.Point(0, 0)
        Me.flowlayoutpanelBox.Name = "flowlayoutpanelBox"
        Me.flowlayoutpanelBox.Size = New System.Drawing.Size(412, 184)
        Me.flowlayoutpanelBox.TabIndex = 0
        '
        'aaformDirectlyApplyKeyValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 184)
        Me.Controls.Add(Me.flowlayoutpanelBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aaformDirectlyApplyKeyValue"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Directly Apply Key Value"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flowlayoutpanelBox As FlowLayoutPanel
End Class
