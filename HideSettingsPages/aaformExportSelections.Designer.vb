<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaformExportSelections
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
        Me.tablelayoutpanelExportSelections = New System.Windows.Forms.TableLayoutPanel()
        Me.labelManualExportMessage = New System.Windows.Forms.Label()
        Me.textboxFormattedOutput = New System.Windows.Forms.TextBox()
        Me.tablelayoutpanelExportSelections.SuspendLayout()
        Me.SuspendLayout()
        '
        'tablelayoutpanelExportSelections
        '
        Me.tablelayoutpanelExportSelections.ColumnCount = 1
        Me.tablelayoutpanelExportSelections.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelExportSelections.Controls.Add(Me.labelManualExportMessage, 0, 0)
        Me.tablelayoutpanelExportSelections.Controls.Add(Me.textboxFormattedOutput, 0, 1)
        Me.tablelayoutpanelExportSelections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutpanelExportSelections.Location = New System.Drawing.Point(0, 0)
        Me.tablelayoutpanelExportSelections.Name = "tablelayoutpanelExportSelections"
        Me.tablelayoutpanelExportSelections.RowCount = 2
        Me.tablelayoutpanelExportSelections.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.tablelayoutpanelExportSelections.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelExportSelections.Size = New System.Drawing.Size(396, 272)
        Me.tablelayoutpanelExportSelections.TabIndex = 0
        '
        'labelManualExportMessage
        '
        Me.labelManualExportMessage.AutoSize = True
        Me.labelManualExportMessage.Location = New System.Drawing.Point(3, 0)
        Me.labelManualExportMessage.Name = "labelManualExportMessage"
        Me.labelManualExportMessage.Size = New System.Drawing.Size(377, 34)
        Me.labelManualExportMessage.TabIndex = 0
        Me.labelManualExportMessage.Text = "Please copy the following text to a file and save it. This will be automated in t" &
    "he future."
        '
        'textboxFormattedOutput
        '
        Me.textboxFormattedOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxFormattedOutput.Location = New System.Drawing.Point(3, 46)
        Me.textboxFormattedOutput.Multiline = True
        Me.textboxFormattedOutput.Name = "textboxFormattedOutput"
        Me.textboxFormattedOutput.ReadOnly = True
        Me.textboxFormattedOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxFormattedOutput.Size = New System.Drawing.Size(390, 223)
        Me.textboxFormattedOutput.TabIndex = 1
        '
        'aaformExportSelections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(396, 272)
        Me.Controls.Add(Me.tablelayoutpanelExportSelections)
        Me.Name = "aaformExportSelections"
        Me.Text = "Export Selections"
        Me.tablelayoutpanelExportSelections.ResumeLayout(False)
        Me.tablelayoutpanelExportSelections.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tablelayoutpanelExportSelections As TableLayoutPanel
    Friend WithEvents labelManualExportMessage As Label
    Friend WithEvents textboxFormattedOutput As TextBox
End Class
