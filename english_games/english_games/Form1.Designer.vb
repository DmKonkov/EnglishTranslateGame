<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStart
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStart))
        StartGameWords = New Button()
        StartGameLetters = New Button()
        btnExit = New Button()
        LabelStartGame = New Label()
        Timer1 = New Timer(components)
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' StartGameWords
        ' 
        StartGameWords.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        StartGameWords.Location = New Point(552, 39)
        StartGameWords.Name = "StartGameWords"
        StartGameWords.Size = New Size(247, 82)
        StartGameWords.TabIndex = 0
        StartGameWords.Text = "Слова"
        StartGameWords.UseVisualStyleBackColor = True
        ' 
        ' StartGameLetters
        ' 
        StartGameLetters.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        StartGameLetters.Location = New Point(552, 141)
        StartGameLetters.Name = "StartGameLetters"
        StartGameLetters.Size = New Size(247, 82)
        StartGameLetters.TabIndex = 1
        StartGameLetters.Text = "Буквы"
        StartGameLetters.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        btnExit.Location = New Point(552, 454)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(247, 82)
        btnExit.TabIndex = 2
        btnExit.Text = "Закончить"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' LabelStartGame
        ' 
        LabelStartGame.AutoSize = True
        LabelStartGame.Location = New Point(12, 9)
        LabelStartGame.Name = "LabelStartGame"
        LabelStartGame.Size = New Size(53, 20)
        LabelStartGame.TabIndex = 3
        LabelStartGame.Text = "Label1"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(12, 39)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 500)
        Panel1.TabIndex = 4
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(494, 494)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        PictureBox2.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(576, 229)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 200)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' FormStart
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(819, 552)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(LabelStartGame)
        Controls.Add(btnExit)
        Controls.Add(StartGameLetters)
        Controls.Add(StartGameWords)
        Name = "FormStart"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Игрульки для Пукульки"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StartGameWords As Button
    Friend WithEvents StartGameLetters As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents LabelStartGame As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
