Imports Windows.Win32.System
Imports Microsoft.Office.Interop.Excel
'Imports System.Threading
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Formats.Asn1.AsnWriter
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class GameWords

    Dim Exc As Object = CreateObject("Excel.Application")
    Dim correctAnswer, key_list As String
    Dim options As New Collection()
    'Dim options As New HashSet(Of String)()
    Dim currentWordIndex As Long

    ' Для таймера
    Private remainingTime As Integer = valueTimer
    Private timerRunning As Boolean = False
    Private valueTimer As Integer = 30 ' Время в секундах

    Dim c As Integer ' Для серии ответов
    Dim t As Integer ' Для вкл/откл транскрипции
    Dim s As Integer ' Для рекорда


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If RadioButton1.Checked = True Then key_list = "Словарь"
        If RadioButton2.Checked = True Then key_list = "Цифры"
        If RadioButton3.Checked = True Then key_list = "Цвета"
        If RadioButton4.Checked = True Then key_list = "Новые"

        If checkTrans.Checked = False Then
            t = 1
        Else
            t = 3
        End If

        ' Старт серии
        c = 0
        Label_seria.Text = "Серия ответов: " & c

        'Button5.Text = key_list

        Exc.workbooks.open("C:\Users\dkkonkov\Desktop\Слова.xlsx") 'Открываем книгу эксель по указанному адресу

        LoadNewWord()

    End Sub

    Sub LoadNewWord()
        Dim rowCount As Long
        Dim randomIndex As Long
        Dim i As Integer
        'Dim optionChosen As Integer
        Dim rnd As New Random()



        ' Задаем количество строк
        rowCount = Exc.sheets(key_list).Cells(Exc.Rows.Count, 2).End(XlDirection.xlUp).Row ' Предполагаем, что первая строка - заголовок



        ' Выбираем случайый перевод
        currentWordIndex = rnd.Next(1, rowCount) ' Индексы начинаются с 0, поэтому 1
        correctAnswer = Exc.sheets(key_list).Cells(currentWordIndex, t).Value.ToString().Trim() ' Предполагаем, что правильный ответ в первом столбце

        '' Проверяем значение correctAnswer
        'If String.IsNullOrEmpty(correctAnswer) Then
        '    MsgBox("correctAnswer пустой или содержит только пробелы.")
        'Else
        '    MsgBox("correctAnswer: " & correctAnswer)
        'End If


        ' Очищаем коллекцию ответов
        options.Clear()
        options.Add(correctAnswer)


        '' Проверяем содержимое HashSet
        'Dim allOptions As String = String.Join(", ", options)
        'MsgBox("Содержимое HashSet: " & allOptions)



        ' Генерируем 3 случайных ответа, которые не совпадают с правильным
        Do While options.Count < 4
            ' Генерируем случайный индекс
            'randomIndex = Exc.sheets(key_list).RandBetween(2, rowCount)
            randomIndex = rnd.Next(2, rowCount + 1) ' rowCount + 1, так как верхняя граница не включается

            Dim valueToAdd As String = Exc.sheets(key_list).Cells(randomIndex, t).Value.ToString().Trim()

            ' Проверяем, существует ли значение уже в коллекции
            If Not options.Contains(valueToAdd) Then
                options.Add(valueToAdd, valueToAdd)
            End If
            'options.Add(valueToAdd) 'если используется HashSet
        Loop

        ' Преобразуем HashSet обратно в список, если это необходимо
        'Dim finalOptions As List(Of String) = options.ToList()

        '' Проверяем содержимое HashSet
        'Dim allOptions2 As String = String.Join(", ", options)
        'MsgBox("Содержимое HashSet: " & allOptions2)



        ' Перемешиваем варианты
        Dim shuffledOptions(4) As String
        For i = 1 To 4
            shuffledOptions(i) = options(i)
        Next i

        Call ShuffleArray(shuffledOptions)

        '' Проверяем содержимое HashSet
        'Dim allOptions3 As String = String.Join(", ", options)
        'MsgBox("Содержимое HashSet3: " & allOptions3)


        ' Отображаем вопрос
        Me.Controls("Label_question").Text = "Какой перевод: '" & Exc.sheets(key_list).Cells(currentWordIndex, 2).Value & "' ?"

        ' Загружаю форму
        pic_thin.Visible = True
        pic_ok.Visible = False
        pic_sad.Visible = False
        pic_load.Visible = False
        Label_question.Visible = True
        Label_seria.Visible = True
        Label_score.Visible = True
        Label_Message.Visible = True
        LblTimer.Visible = True
        ProgressBar1.Visible = True
        cmdAnswer1.Visible = True
        cmdAnswer2.Visible = True
        cmdAnswer3.Visible = True
        cmdAnswer4.Visible = True
        newTask.Visible = False
        Me.cmdAnswer1.Text = shuffledOptions(1)
        Me.cmdAnswer2.Text = shuffledOptions(2)
        Me.cmdAnswer3.Text = shuffledOptions(3)
        Me.cmdAnswer4.Text = shuffledOptions(4)
        Me.Label1.Text = shuffledOptions(0)
        Label1.Visible = True

        ' Значения таймера
        Timer1.Interval = 1000
        ProgressBar1.Value = valueTimer
        ProgressBar1.Maximum = valueTimer

        ' Показываю текущий рекорд
        'ReadTxt()
        'Label_score.Text = "Лучшая серия: " & s

        ' Очищаем предыдущее сообщение
        Label_Message.Text = ""

        ' Старт таймера
        TimerReset()

    End Sub

    'Вариант 1 - появляется 0 индекс, это не правильно
    'Sub ShuffleArray(arr As Object)
    '    Dim i As Long, j As Long
    '    Dim temp As Object
    '    For i = UBound(arr) To LBound(arr) Step -1
    '        j = Int((i - LBound(arr) + 1) * Rnd() + LBound(arr))
    '        temp = arr(i)
    '        arr(i) = arr(j)
    '        arr(j) = temp
    '    Next i
    'End Sub


    'вариант 2
    Sub ShuffleArray(arr As Object)
        Dim i As Long, j As Long
        Dim temp As Object

        ' Начинаем с первого элемента (индекс 1) и до последнего элемента
        For i = UBound(arr) To 1 Step -1
            j = Int((i - 1 + 1) * Rnd() + 1) ' Генерируем случайный индекс от 1 до i
            temp = arr(i)
            arr(i) = arr(j)
            arr(j) = temp
        Next i
    End Sub

    Private Sub CmdAnswer1_Click(sender As Object, e As EventArgs) Handles cmdAnswer1.Click
        CheckAnswer(cmdAnswer1.Text)
    End Sub

    Private Sub CmdAnswer2_Click(sender As Object, e As EventArgs) Handles cmdAnswer2.Click
        CheckAnswer(cmdAnswer2.Text)
    End Sub

    Private Sub CmdAnswer3_Click(sender As Object, e As EventArgs) Handles cmdAnswer3.Click
        CheckAnswer(cmdAnswer3.Text)
    End Sub

    Private Sub CmdAnswer4_Click(sender As Object, e As EventArgs) Handles cmdAnswer4.Click
        CheckAnswer(cmdAnswer4.Text)
    End Sub


    Sub CheckAnswer(selectedAnswer As String)
        If Trim(selectedAnswer) = Trim(correctAnswer) Then

            cmdAnswer1.Visible = False
            cmdAnswer2.Visible = False
            cmdAnswer3.Visible = False
            cmdAnswer4.Visible = False
            Label_question.Visible = False
            Label_Message.Text = "Правильный ответ! Поздравляю!"
            newTask.Visible = True

            '' Смайлы по результату ответа
            pic_thin.Visible = False
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

            'Останавливаем таймер
            TimerStop()

        Else
            Label_Message.Text = "Ошибка! Попробуй снова!"

            '' Смайлы по результату ответа
            pic_thin.Visible = False
            pic_ok.Visible = False
            pic_sad.Visible = True

            ' Серия правильных ответов
            c = 0
            Label_seria.Text = "Серия ответов: " & c

            ' Перезапуск таймера
            TimerReset()

        End If

    End Sub

    Private Sub NewTask_Click(sender As Object, e As EventArgs) Handles newTask.Click
        LoadNewWord()
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
            If remainingTime <= valueTimer * 0.34 Then
                LblTimer.ForeColor = Color.Red
            Else
                If remainingTime <= valueTimer * 0.67 Then
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
            LoadNewWord() ' Перезапуск формы
            c = 0
            Label_seria.Text = "Серия ответов: " & c ' Обнуление серии
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
        s = My.Computer.FileSystem.ReadAllText("score_words.txt", System.Text.Encoding.UTF8)
        'Label_score.Text = "Рекорд: " & s
    End Sub

    Sub UpdateTxt(s As Integer)
        My.Computer.FileSystem.WriteAllText("score_words.txt", s, False, System.Text.Encoding.UTF8)
        ReadTxt()
        'Label_score.Text = "Новый рекорд: " & s
    End Sub

End Class
