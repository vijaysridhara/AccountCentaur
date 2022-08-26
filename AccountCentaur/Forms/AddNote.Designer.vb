<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNote
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.lblNotes = New System.Windows.Forms.Label
        Me.dtpYear = New System.Windows.Forms.DateTimePicker
        Me.twcNotes = New TwinText
        Me.lblOnorAfter = New System.Windows.Forms.Label
        Me.dtpOnorAfter = New System.Windows.Forms.DateTimePicker
        Me.twtStatus = New TwinCombo
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(221, 286)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(20, 10)
        Me.lblNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(37, 16)
        Me.lblNotes.TabIndex = 0
        Me.lblNotes.Text = "&Date"
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "dd-MMM-yyyy"
        Me.dtpYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(139, 7)
        Me.dtpYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.Size = New System.Drawing.Size(167, 22)
        Me.dtpYear.TabIndex = 1
        '
        'twcNotes
        '
        Me.twcNotes.AlignVertical = False
        Me.twcNotes.AllowNumeric = False
        Me.twcNotes.FillerLength = 0
        Me.twcNotes.Label = "&nText"
        Me.twcNotes.Location = New System.Drawing.Point(25, 106)
        Me.twcNotes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.twcNotes.MultiLine = True
        Me.twcNotes.Name = "twcNotes"
        Me.twcNotes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.twcNotes.Scrollbars = System.Windows.Forms.ScrollBars.None
        Me.twcNotes.Size = New System.Drawing.Size(391, 165)
        Me.twcNotes.TabIndex = 2
        '
        'lblOnorAfter
        '
        Me.lblOnorAfter.AutoSize = True
        Me.lblOnorAfter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnorAfter.Location = New System.Drawing.Point(20, 42)
        Me.lblOnorAfter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOnorAfter.Name = "lblOnorAfter"
        Me.lblOnorAfter.Size = New System.Drawing.Size(69, 16)
        Me.lblOnorAfter.TabIndex = 0
        Me.lblOnorAfter.Text = "&On or after"
        '
        'dtpOnorAfter
        '
        Me.dtpOnorAfter.CustomFormat = "dd-MMM-yyyy"
        Me.dtpOnorAfter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOnorAfter.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOnorAfter.Location = New System.Drawing.Point(137, 39)
        Me.dtpOnorAfter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpOnorAfter.Name = "dtpOnorAfter"
        Me.dtpOnorAfter.Size = New System.Drawing.Size(167, 22)
        Me.dtpOnorAfter.TabIndex = 1
        '
        'twtStatus
        '
        Me.twtStatus.AlignVertical = False
        Me.twtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.twtStatus.FillerLength = 12
        Me.twtStatus.Location = New System.Drawing.Point(25, 71)
        Me.twtStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.twtStatus.Name = "twtStatus"
        Me.twtStatus.SelectedIndex = -1
        Me.twtStatus.SelectedItem = Nothing
        Me.twtStatus.Size = New System.Drawing.Size(173, 22)
        Me.twtStatus.TabIndex = 3
        '
        'AddNote
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(427, 336)
        Me.Controls.Add(Me.twtStatus)
        Me.Controls.Add(Me.twcNotes)
        Me.Controls.Add(Me.dtpOnorAfter)
        Me.Controls.Add(Me.lblOnorAfter)
        Me.Controls.Add(Me.dtpYear)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddNote"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddNote"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents twcNotes As TwinText
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblOnorAfter As System.Windows.Forms.Label
    Friend WithEvents dtpOnorAfter As System.Windows.Forms.DateTimePicker
    Friend WithEvents twtStatus As TwinCombo

End Class
