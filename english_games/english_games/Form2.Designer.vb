<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameWords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameWords))
        cmdAnswer1 = New Button()
        Label_question = New Label()
        cmdAnswer2 = New Button()
        cmdAnswer3 = New Button()
        cmdAnswer4 = New Button()
        Label_Message = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        Button5 = New Button()
        newTask = New Button()
        Label_score = New Label()
        pic_thin = New PictureBox()
        pic_ok = New PictureBox()
        pic_sad = New PictureBox()
        Label1 = New Label()
        Button_close = New Button()
        checkTrans = New CheckBox()
        Label_seria = New Label()
        pic_load = New PictureBox()
        Timer1 = New Timer(components)
        LblTimer = New Label()
        ProgressBar1 = New ProgressBar()
        CType(pic_thin, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_ok, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_sad, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_load, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmdAnswer1
        ' 
        resources.ApplyResources(cmdAnswer1, "cmdAnswer1")
        cmdAnswer1.Name = "cmdAnswer1"
        cmdAnswer1.UseVisualStyleBackColor = True
        ' 
        ' Label_question
        ' 
        resources.ApplyResources(Label_question, "Label_question")
        Label_question.Name = "Label_question"
        ' 
        ' cmdAnswer2
        ' 
        resources.ApplyResources(cmdAnswer2, "cmdAnswer2")
        cmdAnswer2.Name = "cmdAnswer2"
        cmdAnswer2.UseVisualStyleBackColor = True
        ' 
        ' cmdAnswer3
        ' 
        resources.ApplyResources(cmdAnswer3, "cmdAnswer3")
        cmdAnswer3.Name = "cmdAnswer3"
        cmdAnswer3.UseVisualStyleBackColor = True
        ' 
        ' cmdAnswer4
        ' 
        resources.ApplyResources(cmdAnswer4, "cmdAnswer4")
        cmdAnswer4.Name = "cmdAnswer4"
        cmdAnswer4.UseVisualStyleBackColor = True
        ' 
        ' Label_Message
        ' 
        resources.ApplyResources(Label_Message, "Label_Message")
        Label_Message.Name = "Label_Message"
        ' 
        ' RadioButton1
        ' 
        resources.ApplyResources(RadioButton1, "RadioButton1")
        RadioButton1.Checked = True
        RadioButton1.Name = "RadioButton1"
        RadioButton1.TabStop = True
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        resources.ApplyResources(RadioButton2, "RadioButton2")
        RadioButton2.Name = "RadioButton2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        resources.ApplyResources(RadioButton3, "RadioButton3")
        RadioButton3.Name = "RadioButton3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        resources.ApplyResources(RadioButton4, "RadioButton4")
        RadioButton4.Name = "RadioButton4"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        resources.ApplyResources(Button5, "Button5")
        Button5.Name = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' newTask
        ' 
        resources.ApplyResources(newTask, "newTask")
        newTask.Name = "newTask"
        newTask.UseVisualStyleBackColor = True
        ' 
        ' Label_score
        ' 
        resources.ApplyResources(Label_score, "Label_score")
        Label_score.Name = "Label_score"
        ' 
        ' pic_thin
        ' 
        resources.ApplyResources(pic_thin, "pic_thin")
        pic_thin.Name = "pic_thin"
        pic_thin.TabStop = False
        ' 
        ' pic_ok
        ' 
        resources.ApplyResources(pic_ok, "pic_ok")
        pic_ok.Name = "pic_ok"
        pic_ok.TabStop = False
        ' 
        ' pic_sad
        ' 
        resources.ApplyResources(pic_sad, "pic_sad")
        pic_sad.Name = "pic_sad"
        pic_sad.TabStop = False
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' Button_close
        ' 
        resources.ApplyResources(Button_close, "Button_close")
        Button_close.Name = "Button_close"
        Button_close.UseVisualStyleBackColor = True
        ' 
        ' checkTrans
        ' 
        resources.ApplyResources(checkTrans, "checkTrans")
        checkTrans.Name = "checkTrans"
        checkTrans.UseVisualStyleBackColor = True
        ' 
        ' Label_seria
        ' 
        resources.ApplyResources(Label_seria, "Label_seria")
        Label_seria.Name = "Label_seria"
        ' 
        ' pic_load
        ' 
        resources.ApplyResources(pic_load, "pic_load")
        pic_load.Name = "pic_load"
        pic_load.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' LblTimer
        ' 
        resources.ApplyResources(LblTimer, "LblTimer")
        LblTimer.ForeColor = Color.Green
        LblTimer.Name = "LblTimer"
        ' 
        ' ProgressBar1
        ' 
        resources.ApplyResources(ProgressBar1, "ProgressBar1")
        ProgressBar1.Maximum = 30
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Value = 30
        ' 
        ' GameWords
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ProgressBar1)
        Controls.Add(LblTimer)
        Controls.Add(pic_load)
        Controls.Add(checkTrans)
        Controls.Add(Button_close)
        Controls.Add(Label1)
        Controls.Add(pic_sad)
        Controls.Add(pic_ok)
        Controls.Add(pic_thin)
        Controls.Add(Label_score)
        Controls.Add(Label_seria)
        Controls.Add(newTask)
        Controls.Add(Button5)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label_Message)
        Controls.Add(cmdAnswer4)
        Controls.Add(cmdAnswer3)
        Controls.Add(cmdAnswer2)
        Controls.Add(Label_question)
        Controls.Add(cmdAnswer1)
        Name = "GameWords"
        CType(pic_thin, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_ok, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_sad, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_load, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdAnswer1 As Button
    Friend WithEvents Label_question As Label
    Friend WithEvents cmdAnswer2 As Button
    Friend WithEvents cmdAnswer3 As Button
    Friend WithEvents cmdAnswer4 As Button
    Friend WithEvents Label_Message As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Button5 As Button
    Friend WithEvents newTask As Button
    Friend WithEvents Label_score As Label
    Friend WithEvents pic_thin As PictureBox
    Friend WithEvents pic_ok As PictureBox
    Friend WithEvents pic_sad As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_close As Button
    Friend WithEvents checkTrans As CheckBox
    Friend WithEvents Label_seria As Label
    Friend WithEvents pic_load As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblTimer As Label
    Friend WithEvents ProgressBar1 As ProgressBar

End Class
