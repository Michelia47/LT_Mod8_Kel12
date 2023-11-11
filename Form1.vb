Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objConv As New ClassLibrary1.Class1
        Dim c As Double
        c = CDbl(TextBox1.Text)
        TextBox13.Text = objConv.cToF(c)
        Label20.Text = "F"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objConv As New ClassLibrary1.Class1
        Dim c As Double
        c = CDbl(TextBox1.Text)
        TextBox13.Text = objConv.cToR(c)
        Label20.Text = "R"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objConv As New ClassLibrary1.Class1
        Dim c As Double
        c = CDbl(TextBox1.Text)
        TextBox13.Text = objConv.cToK(c)
        Label20.Text = "K"
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim objConv As New ClassLibrary1.Class1
        Dim f As Double
        f = CDbl(TextBox6.Text)
        TextBox21.Text = objConv.fToC(f)
        Label24.Text = "C"
    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim objConv As New ClassLibrary1.Class1
        Dim f As Double
        f = CDbl(TextBox6.Text)
        TextBox21.Text = objConv.fToR(f)
        Label24.Text = "R"
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim objConv As New ClassLibrary1.Class1
        Dim f As Double
        f = CDbl(TextBox6.Text)
        TextBox21.Text = objConv.fToK(f)
        Label24.Text = "K"
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim objConv As New ClassLibrary1.Class1
        Dim r As Double
        r = CDbl(TextBox9.Text)
        TextBox18.Text = objConv.rToC(r)
        Label21.Text = "C"
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim objConv As New ClassLibrary1.Class1
        Dim r As Double
        r = CDbl(TextBox9.Text)
        TextBox18.Text = objConv.rToF(r)
        Label21.Text = "F"
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim objConv As New ClassLibrary1.Class1
        Dim r As Double
        r = CDbl(TextBox9.Text)
        TextBox18.Text = objConv.rToK(r)
        Label21.Text = "K"
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim objConv As New ClassLibrary1.Class1
        Dim k As Double
        k = CDbl(TextBox12.Text)
        TextBox24.Text = objConv.kToC(k)
        Label27.Text = "C"
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim objConv As New ClassLibrary1.Class1
        Dim k As Double
        k = CDbl(TextBox12.Text)
        TextBox24.Text = objConv.kToR(k)
        Label27.Text = "R"
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim objConv As New ClassLibrary1.Class1
        Dim k As Double
        k = CDbl(TextBox12.Text)
        TextBox24.Text = objConv.kToF(k)
        Label27.Text = "F"
    End Sub
End Class
