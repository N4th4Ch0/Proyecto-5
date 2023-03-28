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
        lbl1 = New Label()
        lbl2 = New Label()
        txtEdad = New TextBox()
        lblRespuesta1 = New Label()
        lblRespuesta2 = New Label()
        cmdCompro = New Button()
        cmdResset = New Button()
        lblNoDato = New Label()
        SuspendLayout()
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbl1.Location = New Point(37, 86)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(129, 21)
        lbl1.TabIndex = 0
        lbl1.Text = "Ingrese su edad"' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbl2.ForeColor = SystemColors.HotTrack
        lbl2.Location = New Point(37, 9)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(183, 21)
        lbl2.TabIndex = 1
        lbl2.Text = "Comprobador de edad"' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(172, 84)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(100, 23)
        txtEdad.TabIndex = 2
        ' 
        ' lblRespuesta1
        ' 
        lblRespuesta1.AutoSize = True
        lblRespuesta1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblRespuesta1.ForeColor = Color.Red
        lblRespuesta1.Location = New Point(172, 146)
        lblRespuesta1.Name = "lblRespuesta1"
        lblRespuesta1.Size = New Size(0, 30)
        lblRespuesta1.TabIndex = 3
        ' 
        ' lblRespuesta2
        ' 
        lblRespuesta2.AutoSize = True
        lblRespuesta2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblRespuesta2.ForeColor = Color.Aqua
        lblRespuesta2.Location = New Point(160, 176)
        lblRespuesta2.Name = "lblRespuesta2"
        lblRespuesta2.Size = New Size(0, 21)
        lblRespuesta2.TabIndex = 4
        ' 
        ' cmdCompro
        ' 
        cmdCompro.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        cmdCompro.Location = New Point(299, 77)
        cmdCompro.Name = "cmdCompro"
        cmdCompro.Size = New Size(86, 34)
        cmdCompro.TabIndex = 5
        cmdCompro.Text = "Comprobar"
        cmdCompro.UseVisualStyleBackColor = True
        ' 
        ' cmdResset
        ' 
        cmdResset.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        cmdResset.ForeColor = Color.Red
        cmdResset.Location = New Point(478, 336)
        cmdResset.Name = "cmdResset"
        cmdResset.Size = New Size(79, 31)
        cmdResset.TabIndex = 6
        cmdResset.Text = "Reset"
        cmdResset.UseVisualStyleBackColor = True
        ' 
        ' lblNoDato
        ' 
        lblNoDato.AutoSize = True
        lblNoDato.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNoDato.ForeColor = Color.OrangeRed
        lblNoDato.Location = New Point(172, 258)
        lblNoDato.Name = "lblNoDato"
        lblNoDato.Size = New Size(0, 21)
        lblNoDato.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 373)
        Controls.Add(lblNoDato)
        Controls.Add(cmdResset)
        Controls.Add(cmdCompro)
        Controls.Add(lblRespuesta2)
        Controls.Add(lblRespuesta1)
        Controls.Add(txtEdad)
        Controls.Add(lbl2)
        Controls.Add(lbl1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents lblRespuesta1 As Label
    Friend WithEvents lblRespuesta2 As Label
    Friend WithEvents cmdCompro As Button
    Friend WithEvents cmdResset As Button
    Friend WithEvents lblNoDato As Label
End Class
