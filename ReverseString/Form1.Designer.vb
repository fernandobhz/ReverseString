<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.txtInvertida = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNormal = New System.Windows.Forms.TextBox
        Me.btnReverse = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtInvertida
        '
        Me.txtInvertida.Location = New System.Drawing.Point(104, 12)
        Me.txtInvertida.Name = "txtInvertida"
        Me.txtInvertida.Size = New System.Drawing.Size(679, 20)
        Me.txtInvertida.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "String Invertida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "String Normal"
        '
        'txtNormal
        '
        Me.txtNormal.Location = New System.Drawing.Point(104, 38)
        Me.txtNormal.Name = "txtNormal"
        Me.txtNormal.Size = New System.Drawing.Size(679, 20)
        Me.txtNormal.TabIndex = 3
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(789, 36)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(75, 23)
        Me.btnReverse.TabIndex = 4
        Me.btnReverse.Text = "Normalizar"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AcceptButton = Me.btnReverse
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 76)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNormal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInvertida)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reverse String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInvertida As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNormal As System.Windows.Forms.TextBox
    Friend WithEvents btnReverse As System.Windows.Forms.Button

End Class
