Imports System.Diagnostics.Metrics
Public Class FormStart
    Private elements As List(Of Letter)
    Private caughtCount As Integer = 0
    Private elementCount As Integer = 15 ' Количество "летающих" букв
    Private rand As New Random()
    Private timer As Timer
    Private alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    'Private alphabet As String
    Private Sub StartGameWords_Click(sender As Object, e As EventArgs) Handles StartGameWords.Click
        Dim GameWords = New GameWords

        Me.Hide()
        'GameWords.ShowDialog(Me)
        GameWords.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub StartGameLetters_Click(sender As Object, e As EventArgs) Handles StartGameLetters.Click
        Dim GameLetters = New GameLetters
        Me.Hide()
        GameLetters.Show()
    End Sub

    Public Sub New()
        InitializeComponent()

        ' Создаем элементы (буквы)
        elements = New List(Of Letter)
        For i As Integer = 1 To elementCount
            Dim letterChar As Char = alphabet(rand.Next(alphabet.Length))
            Dim letter As New Letter(letterChar, rand.Next(10, 450), rand.Next(10, 450), 20)
            AddHandler letter.Click, AddressOf Element_Click
            elements.Add(letter)
            Panel1.Controls.Add(letter)
        Next

        ' Настраиваем таймер
        timer = New Timer()
        timer.Interval = 100 ' 100 мс
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Start()

        ' Устанавливаем начальное значение счетчика
        LabelStartGame.Text = "Пойманные буквы: 0"
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        For Each letter In elements
            letter.Move(Panel1.ClientSize)
        Next
    End Sub

    Private Sub Element_Click(sender As Object, e As EventArgs)
        Dim letter As Letter = CType(sender, Letter)
        Panel1.Controls.Remove(letter)
        elements.Remove(letter)
        caughtCount += 1
        LabelStartGame.Text = "Пойманные буквы: " & caughtCount

        If caughtCount = elementCount Then
            'MsgBox("Все")
            PictureBox2.Visible = True
            PictureBox1.Visible = False
        End If
    End Sub

End Class

Public Class Letter
    Inherits Label

    Private dx As Integer = 5
    Private dy As Integer = 5

    Public Sub New(letterChar As Char, x As Integer, y As Integer, size As Integer)
        Dim rnd As New Random()

        Me.Text = letterChar.ToString()
        Me.Size = New Size(size, size)
        Me.Location = New Point(x, y)
        Me.Font = New Font("Arial", 16, FontStyle.Bold)
        Me.BackColor = Color.Transparent
        'Me.ForeColor = Color.Black
        Me.ForeColor = Color.FromArgb(rnd.Next(50, 256), rnd.Next(50, 256), rnd.Next(50, 256))
        Me.TextAlign = ContentAlignment.MiddleCenter
        Me.AutoSize = True


    End Sub

    Public Sub Move(boundary As Size)
        If Me.Left < 0 Or Me.Right > boundary.Width Then
            dx = -dx
        End If
        If Me.Top < 0 Or Me.Bottom > boundary.Height Then
            dy = -dy
        End If

        Me.Left += dx
        Me.Top += dy
    End Sub
End Class
