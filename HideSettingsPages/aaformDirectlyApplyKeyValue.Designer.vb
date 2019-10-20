<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aaformDirectlyApplyKeyValue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.labelTypePageOrList = New System.Windows.Forms.Label()
        Me.labelValue = New System.Windows.Forms.Label()
        Me.textboxKeyValue = New System.Windows.Forms.TextBox()
        Me.buttonApply = New System.Windows.Forms.Button()
        Me.buttonUndo = New System.Windows.Forms.Button()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.buttonClearTextbox = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelTypePageOrList
        '
        Me.labelTypePageOrList.AutoSize = True
        Me.labelTypePageOrList.Location = New System.Drawing.Point(12, 9)
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
        Me.labelValue.Location = New System.Drawing.Point(12, 111)
        Me.labelValue.Name = "labelValue"
        Me.labelValue.Size = New System.Drawing.Size(74, 17)
        Me.labelValue.TabIndex = 1
        Me.labelValue.Text = "Key value:"
        '
        'textboxKeyValue
        '
        Me.textboxKeyValue.Location = New System.Drawing.Point(89, 108)
        Me.textboxKeyValue.Name = "textboxKeyValue"
        Me.textboxKeyValue.Size = New System.Drawing.Size(332, 22)
        Me.textboxKeyValue.TabIndex = 2
        '
        'buttonApply
        '
        Me.buttonApply.Location = New System.Drawing.Point(89, 151)
        Me.buttonApply.Name = "buttonApply"
        Me.buttonApply.Size = New System.Drawing.Size(134, 35)
        Me.buttonApply.TabIndex = 3
        Me.buttonApply.Text = "Apply changes"
        Me.buttonApply.UseVisualStyleBackColor = True
        '
        'buttonUndo
        '
        Me.buttonUndo.Location = New System.Drawing.Point(229, 151)
        Me.buttonUndo.Name = "buttonUndo"
        Me.buttonUndo.Size = New System.Drawing.Size(134, 35)
        Me.buttonUndo.TabIndex = 4
        Me.buttonUndo.Text = "Undo all changes"
        Me.buttonUndo.UseVisualStyleBackColor = True
        '
        'buttonClose
        '
        Me.buttonClose.Location = New System.Drawing.Point(369, 151)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(134, 35)
        Me.buttonClose.TabIndex = 5
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        'buttonClearTextbox
        '
        Me.buttonClearTextbox.Location = New System.Drawing.Point(427, 107)
        Me.buttonClearTextbox.Name = "buttonClearTextbox"
        Me.buttonClearTextbox.Size = New System.Drawing.Size(76, 25)
        Me.buttonClearTextbox.TabIndex = 6
        Me.buttonClearTextbox.Text = "Clear"
        Me.buttonClearTextbox.UseVisualStyleBackColor = True
        '
        'aaformDirectlyApplyKeyValue
        '
        Me.AcceptButton = Me.buttonApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonClose
        Me.ClientSize = New System.Drawing.Size(515, 198)
        Me.Controls.Add(Me.buttonClearTextbox)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.buttonUndo)
        Me.Controls.Add(Me.buttonApply)
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
    Friend WithEvents buttonApply As Button
    Friend WithEvents buttonUndo As Button
    Friend WithEvents buttonClose As Button
    Friend WithEvents buttonClearTextbox As Button
End Class
