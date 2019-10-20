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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTypePageOrList
        '
        Me.labelTypePageOrList.AutoSize = True
        Me.labelTypePageOrList.Location = New System.Drawing.Point(9, 6)
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
        Me.labelValue.Location = New System.Drawing.Point(9, 108)
        Me.labelValue.Name = "labelValue"
        Me.labelValue.Size = New System.Drawing.Size(74, 17)
        Me.labelValue.TabIndex = 1
        Me.labelValue.Text = "Key value:"
        '
        'textboxKeyValue
        '
        Me.textboxKeyValue.Location = New System.Drawing.Point(90, 105)
        Me.textboxKeyValue.Name = "textboxKeyValue"
        Me.textboxKeyValue.Size = New System.Drawing.Size(408, 22)
        Me.textboxKeyValue.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.69903!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.30097!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(515, 230)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.textboxKeyValue)
        Me.Panel1.Controls.Add(Me.labelValue)
        Me.Panel1.Controls.Add(Me.labelTypePageOrList)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 170)
        Me.Panel1.TabIndex = 3
        '
        'aaformDirectlyApplyKeyValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(515, 230)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aaformDirectlyApplyKeyValue"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Directly Apply Key Value"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents labelTypePageOrList As Label
    Friend WithEvents labelValue As Label
    Friend WithEvents textboxKeyValue As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
End Class
