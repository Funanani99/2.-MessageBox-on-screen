<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnSayHI = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btnSayHI
        ' 
        btnSayHI.ForeColor = SystemColors.Desktop
        btnSayHI.Location = New Point(365, 240)
        btnSayHI.Name = "btnSayHI"
        btnSayHI.Size = New Size(321, 49)
        btnSayHI.TabIndex = 0
        btnSayHI.Text = "Say Hi!"
        btnSayHI.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tempus Sans ITC", 20F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(83, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(647, 53)
        Label1.TabIndex = 1
        Label1.Text = "THE BUTTON THAT GREET YOU!!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(23, 249)
        Label2.Name = "Label2"
        Label2.Size = New Size(336, 28)
        Label2.TabIndex = 2
        Label2.Text = "Please Click Here and See Miracle:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSayHI)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSayHI As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
