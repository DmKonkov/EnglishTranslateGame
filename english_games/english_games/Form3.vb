Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Microsoft.Office.Interop.Excel
Public Class GameLetters

    Dim Exc As Object = CreateObject("Excel.Application")
    Dim correctAnswer, key_list, translationAnswer, AnswerP1, AnswerP2, AnswerP3, AnswerP4 As String
    Dim currentWordIndex As Long

    Private remainingTime As Integer = valueTimer
    Private timerRunning As Boolean = False
    Private valueTimer As Integer = 60 ' Время в секундах

    Dim c As Integer ' Серия
    Dim s As Integer ' Рекорд


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        word_rus.Text = ""
        Label_Message.Text = ""
        LblAnswer.Text = ""
        TextBox1.Visible = False
        TextBox2.Visible = False
        NewGame.Visible = False
        ButtonCheck.Visible = False
        pic_ok.Visible = False
        pic_sad.Visible = False
        pic_load.Visible = True
        Label_seria.Visible = False
        Label_score.Visible = False

        ' При инициализации формы прописать 
        Timer1.Interval = 1000
        ProgressBar1.Value = valueTimer
        ProgressBar1.Maximum = valueTimer

        'Технические
        word_eng.Visible = False
        count.Visible = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If RadioButton1.Checked = True Then key_list = "Словарь"
        If RadioButton2.Checked = True Then key_list = "Цифры"
        If RadioButton3.Checked = True Then key_list = "Цвета"
        If RadioButton4.Checked = True Then key_list = "Новые"

        Button5.Text = key_list

        Exc.workbooks.open("C:\Users\dkkonkov\Desktop\Слова.xlsx") 'Открываем книгу эксель по указанному адресу

        LoadNewWord()

        ' Обнуляю счетчик
        c = 0
        Label_seria.Text = "Серия ответов: " & c

    End Sub

    Sub LoadNewWord()
        Dim rowCount As Long
        Dim rnd As New Random()
        Dim randomIdex, randomIdex2 As String
        Dim countAnswer, countAnswerFirstHalf, countAnswerSecondHalf As Integer

        'Очищаю переменные
        AnswerP1 = ""
        AnswerP2 = ""
        AnswerP3 = ""
        AnswerP4 = ""

        ' Очистка ответов
        TextBox1.Text = ""
        TextBox2.Text = ""

        pic_ok.Visible = False
        pic_sad.Visible = False
        pic_load.Visible = False
        Label_seria.Visible = True
        Label_score.Visible = True
        LblTimer.Visible = True
        ProgressBar1.Visible = True


        ' Задаем количество строк
        rowCount = Exc.sheets(key_list).Cells(Exc.Rows.Count, 2).End(XlDirection.xlUp).Row ' Предполагаем, что первая строка - заголовок

        ' Выбираем случайый перевод
        currentWordIndex = rnd.Next(1, rowCount) ' Индексы начинаются с 0, поэтому 1
        'currentWordIndex = 6
        correctAnswer = Exc.sheets(key_list).Cells(currentWordIndex, 1).Value.ToString().Trim() ' Предполагаем, что правильный ответ в первом столбце
        translationAnswer = Exc.sheets(key_list).Cells(currentWordIndex, 2).Value.ToString().Trim()

        'Количесвто букв в англ переводе
        countAnswer = correctAnswer.Length

        'Вопрос
        word_rus.Text = "Какая буква пропущена?" & Environment.NewLine & translationAnswer


        If countAnswer = 1 Then
            randomIdex = 1
            TextBox1.Visible = True
            TextBox2.Visible = False

            LblAnswer.Text = "_"

        Else

            If countAnswer < 5 Then
                'Случайный индекс символа
                randomIdex = rnd.Next(1, countAnswer + 1)
                AnswerP1 = Mid(correctAnswer, 1, randomIdex - 1)
                AnswerP2 = Mid(correctAnswer, randomIdex + 1, countAnswer)

                TextBox1.Visible = True
                TextBox2.Visible = False

                LblAnswer.Text = AnswerP1 & "_" & AnswerP2

            Else
                'Случайные 2 индекса символов
                countAnswerFirstHalf = countAnswer \ 2
                countAnswerSecondHalf = countAnswer - countAnswerFirstHalf

                randomIdex = rnd.Next(1, countAnswerFirstHalf + 1)
                randomIdex2 = rnd.Next(countAnswerFirstHalf + 1, countAnswer + 1)

                AnswerP1 = Mid(correctAnswer, 1, randomIdex - 1)
                AnswerP2 = Mid(correctAnswer, randomIdex + 1, countAnswerFirstHalf - randomIdex)

                'если countAnswer четный то countAnswerSecondHalf + 1
                If countAnswer Mod 2 = 0 Then
                    AnswerP3 = Mid(correctAnswer, countAnswerSecondHalf + 1, randomIdex2 - countAnswerFirstHalf - 1)
                Else
                    AnswerP3 = Mid(correctAnswer, countAnswerSecondHalf, randomIdex2 - countAnswerFirstHalf - 1)
                End If

                AnswerP4 = Mid(correctAnswer, randomIdex2 + 1, countAnswer - randomIdex2)

                LblAnswer.Text = AnswerP1 & "_" & AnswerP2 & AnswerP3 & "_" & AnswerP4
                TextBox1.Visible = True
                TextBox2.Visible = True

            End If

        End If


        ButtonCheck.Visible = True
        Label_Message.Text = ""

        ' Сброс таймера
        TimerReset()

        'проверки
        word_eng.Text = correctAnswer
        count.Text = randomIdex & "and" & randomIdex2 & "/" & countAnswer

    End Sub

    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs) Handles ButtonCheck.Click
        Dim myAnswer As String

        myAnswer = AnswerP1 & TextBox1.Text & AnswerP2 & AnswerP3 & TextBox2.Text & AnswerP4

        If LCase(myAnswer) = LCase(correctAnswer) Then
            Label_Message.Text = "Правильный ответ! Поздравляю!"
            word_rus.Text = ""
            NewGame.Visible = True
            ButtonCheck.Visible = False
            LblAnswer.Text = ""
            TextBox1.Visible = False
            TextBox2.Visible = False
            pic_ok.Visible = True
            pic_sad.Visible = False

            ' Серия правильных ответов
            c += 1
            Label_seria.Text = "Серия ответов: " & c

            ' Рекорд
            ReadTxt()
            If c > s Then
                s = c
                UpdateTxt(s)
                Label_score.Text = "Новый рекорд: " & s
            Else
                Label_score.Text = "Лучшая серия: " & s
            End If

            ' Останавливаю таймер
            TimerStop()

        Else
            Label_Message.Text = "Ошибка! Попробуй снова!"
            pic_sad.Visible = True
            pic_ok.Visible = False
            'ButtonCheck.Text = myAnswer & "." & correctAnswer

            ' Серия правильных ответов
            c = 0
            Label_seria.Text = "Серия ответов: " & c

            ' Останавливаю таймер
            TimerReset()
        End If

        TextBox1.Text = ""
        TextBox2.Text = ""


    End Sub

    Private Sub NewGame_Click(sender As Object, e As EventArgs) Handles NewGame.Click
        LoadNewWord()
        NewGame.Visible = False
    End Sub

    Private Sub Button_close_Click(sender As Object, e As EventArgs) Handles Button_close.Click
        '' Закрываем workbook и Excel
        'If Workbook IsNot Nothing Then
        '    Workbook.Close(False)
        '    Marshal.ReleaseComObject(Workbook)
        'End If
        'If Worksheet IsNot Nothing Then
        '    Marshal.ReleaseComObject(Worksheet)
        'End If
        Exc.Quit()
        Marshal.ReleaseComObject(Exc)

        Me.Close()
        ' Перезапуск стартовой формы
        'Dim FormStart As New FormStart()
        FormStart.Show()
    End Sub

    ' Методы таймера
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If remainingTime > 0 Then
            remainingTime -= 1 ' Уменьшить оставшееся время на 1 секунду
            ProgressBar1.Value = remainingTime ' Шкала прогрессбара
            If remainingTime <= 10 Then
                LblTimer.ForeColor = Color.Red
            Else
                If remainingTime <= (valueTimer + 10) / 2 Then
                    LblTimer.ForeColor = Color.Blue
                Else
                    LblTimer.ForeColor = Color.Green
                End If
            End If

            LblTimer.Text = remainingTime.ToString() ' Обновить текст на Label
        Else
            Timer1.Stop() ' Остановить таймер, если время вышло
            timerRunning = False
            MessageBox.Show("Время вышло!") ' Сообщение о завершении

            ' Сброс серии
            c = 0
            Label_seria.Text = "Серия ответов: " & c

            ' Останавливаю таймер
            TimerStop()
        End If
    End Sub

    Private Sub TimerReset()
        Timer1.Stop() ' Остановить таймер
        remainingTime = valueTimer ' Сбросить время на 30 секунд
        ProgressBar1.Value = remainingTime ' Сброс шкалы прогрессбара
        LblTimer.ForeColor = Color.Green
        LblTimer.Text = valueTimer ' Обновить текст на Label
        Timer1.Start() ' Запустить таймер
        timerRunning = True
    End Sub

    Private Sub TimerStart()
        If Not timerRunning Then
            remainingTime = valueTimer ' Сбросить время на 30 секунд
            ProgressBar1.Value = remainingTime ' Сброс шкалы прогрессбара
            Timer1.Start() ' Запустить таймер
            timerRunning = True
        End If
    End Sub

    Private Sub TimerStop()
        Timer1.Stop() ' Остановить таймер
        remainingTime = valueTimer ' Сбросить время на 30 секунд
        ProgressBar1.Value = remainingTime ' Сброс шкалы прогрессбара
        LblTimer.ForeColor = Color.Green
        LblTimer.Text = valueTimer ' Обновить текст на Label
        timerRunning = False
    End Sub

    ' Методы рекорда
    Sub ReadTxt()
        s = My.Computer.FileSystem.ReadAllText("score_letters.txt", System.Text.Encoding.UTF8)
    End Sub

    Sub UpdateTxt(s As Integer)
        My.Computer.FileSystem.WriteAllText("score_letters.txt", s, False, System.Text.Encoding.UTF8)
        ReadTxt()
    End Sub


End Class





