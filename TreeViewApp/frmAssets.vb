﻿Public Class frmAssets
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub setLabel(ByVal sMessage As String)
        lblNodeMessage.Text = sMessage
    End Sub

End Class