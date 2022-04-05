Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "Doğukan"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox3.Text))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(Convert.ToInt32(TextBox2.Text) - Convert.ToInt32(TextBox3.Text))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox(Convert.ToInt32(TextBox2.Text) * Convert.ToInt32(TextBox3.Text))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox(Convert.ToInt32(TextBox2.Text) / Convert.ToInt32(TextBox3.Text))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("Adınız : " + InputBox("Adınızı Giriniz:").ToString() + " Soyadınız : " + InputBox("Soyadınızı Giriniz:").ToString() + " Yaşınız : " + (2022 - Convert.ToInt32(InputBox("Doğum Tarihinizi Giriniz:"))).ToString())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MsgBox("Doğukan Tekin " + Now)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim ad, soyad, dogumyeri As String
        ad = TextBox4.Text
        soyad = TextBox5.Text
        dogumyeri = TextBox6.Text
        MsgBox(ad + " " + soyad + " " + dogumyeri)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim ad, soyad As String
        Dim sayi1, sayi2, sayi3 As Integer
        Dim tarih As Date
        ad = TextBox7.Text
        soyad = TextBox8.Text
        sayi1 = Convert.ToInt32(TextBox9.Text)
        tarih = Convert.ToDateTime(TextBox10.Text)
        sayi2 = Convert.ToInt32(TextBox11.Text)
        sayi3 = CInt(TextBox12.Text)
        MsgBox(ad + " " + soyad + " " + sayi1.ToString() + " " + tarih.ToString() + " " + sayi2.ToString() + " " + sayi3.ToString())
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ListBox1.Items.Clear()
        For i = 1 To 10
            ListBox1.Items.Add(i.ToString())
        Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ListBox1.Items.Clear()
        For i = 1 To 10
            ListBox1.Items.Add(TextBox13.Text)
        Next
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ListBox1.Items.Clear()
        For i = 1 To 10
            ListBox1.Items.Add(i.ToString() + " " + TextBox14.Text)
        Next
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim satir, sutun As Integer
        satir = CInt(InputBox("Kaçtan Başlasın"))
        sutun = CInt(InputBox("Kaça Gitsin"))
        For i = 1 To satir
            For j = 1 To sutun
                ListBox2.Items.Add(i.ToString() + "*" + j.ToString() + "=" + (i * j).ToString)
            Next
        Next
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ListBox3.Items.Clear()
        Dim num As Integer
        num = 1
        Do While (num <= 10)
            ListBox3.Items.Add(num.ToString())
            num += 1
        Loop
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ListBox3.Items.Clear()
        Dim num As Integer
        num = 1
        Do
            ListBox3.Items.Add(num.ToString())
            num += 1
        Loop While (num < 11)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ListBox3.Items.Clear()
        Dim num As Integer
        num = 1
        Do Until (num = 11)
            ListBox3.Items.Add(num.ToString())
            num += 1
        Loop
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        ListBox3.Items.Clear()
        Dim num As Integer
        num = 1
        Do
            ListBox3.Items.Add(num.ToString())
            num += 1
        Loop Until (num = 11)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If (CInt(TextBox15.Text) > 50) Then
            MsgBox("Geçti")
        Else
            MsgBox("Kaldı")
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim vize, final As Integer
        Dim ort As Double
        vize = CInt(TextBox16.Text)
        final = CInt(TextBox17.Text)
        ort = (final * 6 / 10) + (vize * 4 / 10)
        If (ort < 50) Then
            MsgBox("Kaldı")
        ElseIf (ort < 65) Then
            MsgBox("DC")
        ElseIf (ort < 85) Then
            MsgBox("BB")
        Else
            MsgBox("AA")
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Select Case CInt(TextBox18.Text)
            Case 1
                MsgBox("Çok Zayıf")
            Case 2
                MsgBox("Zayıf")
            Case 3
                MsgBox("Orta")
            Case 4
                MsgBox("İyi")
            Case 5
                MsgBox("Çok İyi")
        End Select
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox20.Text = Choose(CInt(TextBox19.Text), "İyi", "Kötü", "Çirkin")
    End Sub

    Private Sub TextBox21_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox21.KeyPress
        If (Char.IsLetter(e.KeyChar) = False And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox23_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox23.KeyPress
        If (Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox24_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox24.KeyPress
        If (Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox25_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox25.KeyPress
        If (Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox22_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox22.KeyPress
        If (Char.IsLetter(e.KeyChar) = False And e.KeyChar <> Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim maas As Integer
        Select Case CInt(TextBox23.Text)
            Case Is < 1000
                MsgBox("Maaş 1000TL'den düşük olamaz")
                TextBox23.Clear()
                TextBox23.Focus()
            Case Is > 50000
                MsgBox("Maaş 50.000TL'den yüksek olamaz")
                TextBox23.Clear()
                TextBox23.Focus()
            Case Else
                maas = CInt(TextBox23.Text) - CInt(TextBox24.Text) - CInt(TextBox25.Text)
        End Select
        Select Case maas
            Case <> 0
                ListBox4.Items.Add("Ad: " + TextBox21.Text + " Soyad: " + TextBox22.Text + " Maaş: " + maas.ToString())
        End Select
    End Sub
End Class
