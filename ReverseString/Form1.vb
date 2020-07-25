Public Class frmPrincipal

    Private Sub btnReverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReverse.Click
        Dim S As String = String.Empty

        For i As Integer = Len(Me.txtInvertida.Text) To 1 Step -1
            S &= Mid(Me.txtInvertida.Text, i, 1)
        Next

        Me.txtNormal.Text = S
    End Sub
End Class
