Imports System.ComponentModel

Public Class Form5
    Dim nm, n, num
    Dim rnd As New Random
    Dim label As New List(Of Label)
    Dim mk = 41 - 25
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim st() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", _
                              "J", "K", "L", "M", "N", "O", "P", "Q", "R", _
                              "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim gt As String 
        For m = 0 To 41
            nm = 0
            If m > 25 Then 
                mk = mk - 1
                gt = st(mk).ToString & st(25).ToString
            Else
                gt = st(m).ToString
            End If

            For i = 0 To 100

                Dim pb As New Label
                pb.Width = 8 'or whatever
                pb.Height = 8
                pb.Top = 10 + n 'or whatever
                pb.Left = 10 + nm
                'pb.ImageLocation = "dog.png" 
                collor(rnd.Next(11))
                pb.BackColor = dt
                'Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255)) 'Color.LimeGreen 'Color.FromArgb(225, n * 225 / 100, i * 225 / 100)
                num += 1
                pb.Name = "N" & num
                pb.Tag = "( " & gt & " , " & i & " )"
                 
                AddHandler pb.MouseMove, AddressOf Label1_MouseHover
                AddHandler pb.MouseLeave, AddressOf Label1_Mouseleave
                label.Add(pb)

                Me.Controls.Add(pb)
                nm += 10
                'TextBox1.Text = TextBox1.Text & 0
                Label1.Text += 1
            Next
            'TextBox1.AppendText(vbCrLf)
            n += 10
        Next
    End Sub
    Private Sub Label1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseMove
        Dim picBox As Label = DirectCast(sender, Label)
        Dim name As String = picBox.Name
        Label2.Text = name
        'picBox.BackColor = Color.Red 
        PictureBox12.BackColor = picBox.BackColor
        rand(rnd.Next(12))
        Label17.Text = status
        Label18.Text = picBox.Tag
         

    End Sub
    Private Sub Label1_Mouseleave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Dim picBox As Label = DirectCast(sender, Label)
        Dim name As String = picBox.Name
        Label2.Text = name
        'picBox.BackColor = Color.LimeGreen
        PictureBox12.BackColor = picBox.BackColor
        rand(rnd.Next(12))
        Label17.Text = status
        Label18.Text = picBox.Tag
    End Sub
    Dim status
    Dim dt As Color
    Sub rand(ByVal gt As Integer)
        If gt = 1 Then status = "Loading"
        If gt = 2 Then status = "Get Leveling"
        If gt = 3 Then status = "Analysis Location"
        If gt = 4 Then status = "Determine Charge"
        If gt = 5 Then status = "Done check"
        If gt = 6 Then status = "Starting Mission"
        If gt = 7 Then status = "First Mission"
        If gt = 8 Then status = "Done"
        If gt = 9 Then status = "Sec Mission"
        If gt = 10 Then status = "Finished"
        If gt = 11 Then status = "Warning"

    End Sub
    Sub collor(ByVal gt As Integer)
        
        If gt = 1 Then dt = Color.Aqua
        If gt = 2 Then dt = Color.Yellow
        If gt = 3 Then dt = Color.FromArgb(0, 192, 192)
        If gt = 4 Then dt = Color.FromArgb(192, 64, 0)
        If gt = 5 Then dt = Color.White
        If gt = 6 Then dt = Color.FromArgb(255, 192, 192)
        If gt = 7 Then dt = Color.FromArgb(192, 255, 192)
        If gt = 8 Then dt = Color.Lime
        If gt = 9 Then dt = Color.FromArgb(15, 129, 15)
        If gt = 10 Then dt = Color.Lime
        If gt = 11 Then dt = Color.FromArgb(192, 255, 255)
    End Sub
    Sub update()
        ' Dim pics As New List(Of PictureBox) From {str}
        For Each pic In label
            '  pic.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
            collor(rnd.Next(11))
            If pic.BackColor = Color.Lime Then
            Else
                pic.BackColor = dt
            End If
        Next
    End Sub

    Sub active(ByVal col As Color)
        ' Dim pics As New List(Of PictureBox) From {str}
        For Each pic In label
            If pic.BackColor = col Then
                pic.Visible = False
            End If
        Next
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        update()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Start update" Then
            Button2.Text = "Stop update (running)"
            Timer1.Start()
        Else
            Button2.Text = "Start update"
            Timer1.Stop()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim R, G, B As Integer

        R = rnd.Next(0, 225)

        G = rnd.Next(0, 225)

        B = rnd.Next(0, 225)

        TextBox1.BackColor = Color.FromArgb(255, R, G, B)
        TextBox1.Text = R.ToString & ", " & G.ToString & ", " & B.ToString  'Color.LimeGreen 'Color.FromArgb(225, n * 225 / 100, i * 225 / 100)
        Dim C = System.Drawing.Color.FromName(TextBox1.Text)

        active(C)
    End Sub 'Val()

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
