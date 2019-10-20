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
        Me.labelTypePageOrList = New System.Windows.Forms.Label()
        Me.labelValue = New System.Windows.Forms.Label()
        Me.textboxKeyValue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'labelTypePageOrList
        '
        Me.labelTypePageOrList.AutoSize = True
        Me.labelTypePageOrList.Location = New System.Drawing.Point(13, 13)
        Me.labelTypePageOrList.Name = "labelTypePageOrList"
        Me.labelTypePageOrList.Size = New System.Drawing.Size(489, 68)
        Me.labelTypePageOrList.TabIndex = 0
        Me.labelTypePageOrList.Text = "Type a page or list of pages to hide or show only and HideSettingsPages will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "app" &
    "ly the key value to the Registry to hide the relevant pages in Settings." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Form" &
    "atting example: ""hide:about;display"""
        '
        'labelValue
        '
        Me.labelValue.AutoSize = True
        Me.labelValue.Location = New System.Drawing.Point(13, 116)
        Me.labelValue.Name = "labelValue"
        Me.labelValue.Size = New System.Drawing.Size(74, 17)
        Me.labelValue.TabIndex = 1
        Me.labelValue.Text = "Key value:"
        '
        'textboxKeyValue
        '
        Me.textboxKeyValue.Location = New System.Drawing.Point(94, 116)
        Me.textboxKeyValue.Name = "textboxKeyValue"
        Me.textboxKeyValue.Size = New System.Drawing.Size(408, 22)
        Me.textboxKeyValue.TabIndex = 2
        '
        'aaformDirectlyApplyKeyValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(515, 230)
        Me.Controls.Add(Me.textboxKeyValue)
        Me.Controls.Add(Me.labelValue)
        Me.Controls.Add(Me.labelTypePageOrList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aaformDirectlyApplyKeyValue"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Directly Apply Key Value"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelTypePageOrList As Label
    Friend WithEvents labelValue As Label
    Friend WithEvents textboxKeyValue As TextBox
End Class
