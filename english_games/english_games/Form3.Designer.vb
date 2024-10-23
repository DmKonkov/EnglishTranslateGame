<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameLetters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameLetters))
        Button5 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        word_eng = New Label()
        word_rus = New Label()
        count = New Label()
        TextBox1 = New TextBox()
        ButtonCheck = New Button()
        Label_Message = New Label()
        NewGame = New Button()
        TextBox2 = New TextBox()
        LblAnswer = New Label()
        Button_close = New Button()
        pic_ok = New PictureBox()
        pic_sad = New PictureBox()
        Label_seria = New Label()
        pic_load = New PictureBox()
        LblTimer = New Label()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        Label_score = New Label()
        CType(pic_ok, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_sad, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_load, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(493, 218)
        Button5.Name = "Button5"
        Button5.Size = New Size(121, 51)
        Button5.TabIndex = 3
        Button5.Text = "Старт"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(514, 71)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(72, 24)
        RadioButton1.TabIndex = 1
        RadioButton1.TabStop = True
        RadioButton1.Text = "Слова"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(514, 101)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(80, 24)
        RadioButton2.TabIndex = 2
        RadioButton2.Text = "Цифры"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(514, 131)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(71, 24)
        RadioButton3.TabIndex = 3
        RadioButton3.Text = "Цвета"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(514, 161)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(77, 24)
        RadioButton4.TabIndex = 4
        RadioButton4.Text = "Новые"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' word_eng
        ' 
        word_eng.AutoSize = True
        word_eng.Location = New Point(502, 290)
        word_eng.Name = "word_eng"
        word_eng.Size = New Size(53, 20)
        word_eng.TabIndex = 5
        word_eng.Text = "Label1"
        ' 
        ' word_rus
        ' 
        word_rus.AutoSize = True
        word_rus.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        word_rus.Location = New Point(75, 9)
        word_rus.Name = "word_rus"
        word_rus.Size = New Size(337, 38)
        word_rus.TabIndex = 6
        word_rus.Text = "Какая буква пропущена?"
        word_rus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' count
        ' 
        count.AutoSize = True
        count.Location = New Point(561, 290)
        count.Name = "count"
        count.Size = New Size(53, 20)
        count.TabIndex = 7
        count.Text = "Label1"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 16.2F)
        TextBox1.Location = New Point(198, 186)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(34, 43)
        TextBox1.TabIndex = 0
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' ButtonCheck
        ' 
        ButtonCheck.Location = New Point(177, 275)
        ButtonCheck.Name = "ButtonCheck"
        ButtonCheck.Size = New Size(112, 51)
        ButtonCheck.TabIndex = 9
        ButtonCheck.Text = "Проверим?"
        ButtonCheck.UseVisualStyleBackColor = True
        ' 
        ' Label_Message
        ' 
        Label_Message.AutoSize = True
        Label_Message.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label_Message.Location = New Point(29, 349)
        Label_Message.Name = "Label_Message"
        Label_Message.Size = New Size(439, 38)
        Label_Message.TabIndex = 12
        Label_Message.Text = "Правильный ответ! Поздравляю!"
        Label_Message.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NewGame
        ' 
        NewGame.Location = New Point(177, 275)
        NewGame.Name = "NewGame"
        NewGame.Size = New Size(112, 51)
        NewGame.TabIndex = 13
        NewGame.Text = "Ещё!!!"
        NewGame.UseVisualStyleBackColor = True
        NewGame.Visible = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 16.2F)
        TextBox2.Location = New Point(238, 186)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(34, 43)
        TextBox2.TabIndex = 0
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblAnswer
        ' 
        LblAnswer.AutoSize = True
        LblAnswer.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        LblAnswer.Location = New Point(199, 123)
        LblAnswer.Name = "LblAnswer"
        LblAnswer.Size = New Size(73, 41)
        LblAnswer.TabIndex = 16
        LblAnswer.Text = "Lbl2"
        LblAnswer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button_close
        ' 
        Button_close.Location = New Point(493, 336)
        Button_close.Name = "Button_close"
        Button_close.Size = New Size(121, 51)
        Button_close.TabIndex = 17
        Button_close.Text = "Закончить"
        Button_close.UseVisualStyleBackColor = True
        ' 
        ' pic_ok
        ' 
        pic_ok.Image = CType(resources.GetObject("pic_ok.Image"), Image)
        pic_ok.Location = New Point(113, 37)
        pic_ok.Name = "pic_ok"
        pic_ok.Size = New Size(281, 232)
        pic_ok.SizeMode = PictureBoxSizeMode.Zoom
        pic_ok.TabIndex = 18
        pic_ok.TabStop = False
        ' 
        ' pic_sad
        ' 
        pic_sad.Image = CType(resources.GetObject("pic_sad.Image"), Image)
        pic_sad.Location = New Point(324, 238)
        pic_sad.Name = "pic_sad"
        pic_sad.Size = New Size(111, 88)
        pic_sad.TabIndex = 19
        pic_sad.TabStop = False
        ' 
        ' Label_seria
        ' 
        Label_seria.AutoSize = True
        Label_seria.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label_seria.Location = New Point(493, 9)
        Label_seria.Name = "Label_seria"
        Label_seria.Size = New Size(113, 20)
        Label_seria.TabIndex = 20
        Label_seria.Text = "Серия ответов:"
        Label_seria.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pic_load
        ' 
        pic_load.Image = CType(resources.GetObject("pic_load.Image"), Image)
        pic_load.Location = New Point(0, 0)
        pic_load.Name = "pic_load"
        pic_load.Size = New Size(484, 407)
        pic_load.SizeMode = PictureBoxSizeMode.StretchImage
        pic_load.TabIndex = 21
        pic_load.TabStop = False
        ' 
        ' LblTimer
        ' 
        LblTimer.AutoSize = True
        LblTimer.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        LblTimer.ForeColor = Color.Green
        LblTimer.Location = New Point(0, 0)
        LblTimer.Name = "LblTimer"
        LblTimer.Size = New Size(34, 28)
        LblTimer.TabIndex = 22
        LblTimer.Text = "30"
        LblTimer.TextAlign = ContentAlignment.TopCenter
        LblTimer.Visible = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(30, 5)
        ProgressBar1.Maximum = 60
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(454, 7)
        ProgressBar1.TabIndex = 23
        ProgressBar1.Value = 60
        ProgressBar1.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label_score
        ' 
        Label_score.AutoSize = True
        Label_score.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label_score.Location = New Point(493, 37)
        Label_score.Name = "Label_score"
        Label_score.Size = New Size(110, 20)
        Label_score.TabIndex = 24
        Label_score.Text = "Лучшая серия:"
        Label_score.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' GameLetters
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(634, 405)
        Controls.Add(Label_score)
        Controls.Add(ProgressBar1)
        Controls.Add(LblTimer)
        Controls.Add(Label_seria)
        Controls.Add(pic_sad)
        Controls.Add(pic_ok)
        Controls.Add(Button_close)
        Controls.Add(LblAnswer)
        Controls.Add(TextBox2)
        Controls.Add(NewGame)
        Controls.Add(Label_Message)
        Controls.Add(ButtonCheck)
        Controls.Add(TextBox1)
        Controls.Add(count)
        Controls.Add(word_rus)
        Controls.Add(word_eng)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Button5)
        Controls.Add(pic_load)
        Name = "GameLetters"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Игра в буквы"
        CType(pic_ok, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_sad, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_load, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents word_eng As Label
    Friend WithEvents word_rus As Label
    Friend WithEvents count As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonCheck As Button
    Friend WithEvents Label_Message As Label
    Friend WithEvents NewGame As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LblAnswer As Label
    Friend WithEvents Button_close As Button
    Friend WithEvents pic_ok As PictureBox
    Friend WithEvents pic_sad As PictureBox
    Friend WithEvents Label_seria As Label
    Friend WithEvents pic_load As PictureBox
    Friend WithEvents LblTimer As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label_score As Label

End Class
