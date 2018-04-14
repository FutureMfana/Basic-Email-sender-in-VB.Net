<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtSend = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtMsg = New System.Windows.Forms.RichTextBox()
        Me.btnAttachment = New System.Windows.Forms.Button()
        Me.btnDraft = New System.Windows.Forms.Button()
        Me.btnDrafts = New System.Windows.Forms.Button()
        Me.dialogAttachmentFile = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(543, 430)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(103, 30)
        Me.txtSend.TabIndex = 0
        Me.txtSend.Text = "&Send"
        Me.txtSend.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.AutoSize = True
        Me.txtFile.Location = New System.Drawing.Point(94, 65)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(0, 13)
        Me.txtFile.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Subject:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Message:"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(95, 7)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(551, 20)
        Me.txtTo.TabIndex = 8
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(95, 37)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(551, 20)
        Me.txtSubject.TabIndex = 9
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(95, 89)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(551, 335)
        Me.txtMsg.TabIndex = 10
        Me.txtMsg.Text = ""
        '
        'btnAttachment
        '
        Me.btnAttachment.Location = New System.Drawing.Point(12, 60)
        Me.btnAttachment.Name = "btnAttachment"
        Me.btnAttachment.Size = New System.Drawing.Size(76, 23)
        Me.btnAttachment.TabIndex = 11
        Me.btnAttachment.Text = "Attachment"
        Me.btnAttachment.UseVisualStyleBackColor = True
        '
        'btnDraft
        '
        Me.btnDraft.Location = New System.Drawing.Point(434, 430)
        Me.btnDraft.Name = "btnDraft"
        Me.btnDraft.Size = New System.Drawing.Size(103, 30)
        Me.btnDraft.TabIndex = 12
        Me.btnDraft.Text = "Save As &Draft"
        Me.btnDraft.UseVisualStyleBackColor = True
        '
        'btnDrafts
        '
        Me.btnDrafts.Location = New System.Drawing.Point(325, 430)
        Me.btnDrafts.Name = "btnDrafts"
        Me.btnDrafts.Size = New System.Drawing.Size(103, 30)
        Me.btnDrafts.TabIndex = 13
        Me.btnDrafts.Text = "&Load Drafts"
        Me.btnDrafts.UseVisualStyleBackColor = True
        '
        'dialogAttachmentFile
        '
        Me.dialogAttachmentFile.FileName = "OpenFileDialog1"
        Me.dialogAttachmentFile.Multiselect = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 472)
        Me.Controls.Add(Me.btnDrafts)
        Me.Controls.Add(Me.btnDraft)
        Me.Controls.Add(Me.btnAttachment)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.txtSend)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSend As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtMsg As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAttachment As System.Windows.Forms.Button
    Friend WithEvents btnDraft As System.Windows.Forms.Button
    Friend WithEvents btnDrafts As System.Windows.Forms.Button
    Friend WithEvents dialogAttachmentFile As System.Windows.Forms.OpenFileDialog

End Class
