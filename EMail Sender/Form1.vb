Imports System.Net.Mail
Public Class Form1

    Private Sub btnAttachment_Click(sender As Object, e As EventArgs) Handles btnAttachment.Click
        dialogAttachmentFile.ShowDialog()
        txtFile.Text = dialogAttachmentFile.FileName
    End Sub

    Private Sub txtSend_Click(sender As Object, e As EventArgs) Handles txtSend.Click
        Try
            Dim mail As New MailMessage()
            Dim smtpSever As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("kamvelihleinnocent@gmail.com")
            mail.To.Add(txtTo.Text)
            mail.Subject = txtSubject.Text
            mail.Body = txtMsg.Text

            Dim attach As System.Net.Mail.Attachment
            attach = New System.Net.Mail.Attachment(txtFile.Text)
            mail.Attachments.Add(attach)
            smtpSever.Port = 587
            smtpSever.Credentials = New System.Net.NetworkCredential("Kamvelihleinnocent@gmail.com", "9501315938082")
            smtpSever.EnableSsl = True
            smtpSever.Send(mail)
            MessageBox.Show("Email has been sent...", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Sorry... There was an error when sending a message", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
