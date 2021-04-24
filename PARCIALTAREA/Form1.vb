Public Class Form1
    Public Class Operaciones
        Public numero As Integer

        Public Function Suma(numero As Integer) As Object
            Dim sumaNum As Integer
            sumaNum = numero + numero

            Return sumaNum
        End Function

        Public Function Resta(numero As Integer) As Object

            Dim restaNum As Integer
            For i = 1 To 10 Step 1
                restaNum = numero - i
            Next
            Return restaNum
        End Function
        Public Function Multiplicacion(numero As Integer) As Object

            Dim mult As Integer
            For i = 1 To 10 Step 1
                mult = numero * i
            Next
            Return mult
        End Function
    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Operaciones = New Operaciones()
        Dim num As Integer = ComboBox1.SelectedItem : Dim result As Integer

        If (RadioButton1.Checked) Then
            For index = 1 To 10 Step 1
                result = num + num
            Next
            ListBox1.Items.Add(num & " + " & num & " = " & result)
        ElseIf (RadioButton2.Checked) Then
            result = num - num
            ListBox1.Items.Add(num & " - " & num & " = " & result)
        ElseIf (RadioButton3.Checked) Then
            For i = 1 To 10 Step 1
                result = num * i
                ListBox1.Items.Add(num & " X " & i & " = " & result)
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub
End Class
