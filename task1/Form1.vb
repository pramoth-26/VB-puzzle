Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '11,14
        checkbutton(Button1, Button11)
        checkbutton(Button1, Button14)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '4,12,5
        checkbutton(Button2, Button4)
        checkbutton(Button2, Button12)
        checkbutton(Button2, Button5)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '12,15,5,8
        checkbutton(Button3, Button12)
        checkbutton(Button3, Button15)
        checkbutton(Button3, Button5)
        checkbutton(Button3, Button8)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '13,2
        checkbutton(Button4, Button13)
        checkbutton(Button4, Button2)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '2,3,16
        checkbutton(Button5, Button2)
        checkbutton(Button5, Button3)
        checkbutton(Button5, Button16)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '11,12,14,15
        checkbutton(Button6, Button11)
        checkbutton(Button6, Button12)
        checkbutton(Button6, Button14)
        checkbutton(Button6, Button15)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '9,10
        checkbutton(Button7, Button9)
        checkbutton(Button7, Button10)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '3,10,16
        checkbutton(Button8, Button3)
        checkbutton(Button8, Button10)
        checkbutton(Button8, Button16)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '7,14,15
        checkbutton(Button9, Button7)
        checkbutton(Button9, Button14)
        checkbutton(Button9, Button15)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        '15,7,8
        checkbutton(Button10, Button7)
        checkbutton(Button10, Button8)
        checkbutton(Button10, Button15)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        '1,6,13
        checkbutton(Button11, Button1)
        checkbutton(Button11, Button6)
        checkbutton(Button11, Button13)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '13,2,3,6
        checkbutton(Button12, Button2)
        checkbutton(Button12, Button3)
        checkbutton(Button12, Button13)
        checkbutton(Button12, Button6)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        '11,12,4
        checkbutton(Button13, Button11)
        checkbutton(Button13, Button12)
        checkbutton(Button13, Button4)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        '1,6,9
        checkbutton(Button14, Button1)
        checkbutton(Button14, Button6)
        checkbutton(Button14, Button9)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        '3,6,9,10
        checkbutton(Button15, Button3)
        checkbutton(Button15, Button6)
        checkbutton(Button15, Button9)
        checkbutton(Button15, Button10)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        '8,5
        checkbutton(Button16, Button8)
        checkbutton(Button16, Button5)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackgroundImage = My.Resources.image_part_001
        Button2.BackgroundImage = My.Resources.image_part_002
        Button3.BackgroundImage = My.Resources.image_part_003
        Button4.BackgroundImage = My.Resources.image_part_004
        Button5.BackgroundImage = My.Resources.image_part_005
        Button6.BackgroundImage = My.Resources.image_part_006
        Button7.BackgroundImage = My.Resources.image_part_007
        Button8.BackgroundImage = My.Resources.image_part_008
        Button9.BackgroundImage = My.Resources.image_part_009
        Button10.BackgroundImage = My.Resources.image_part_010
        Button11.BackgroundImage = My.Resources.image_part_011
        Button12.BackgroundImage = My.Resources.image_part_012
        Button13.BackgroundImage = My.Resources.image_part_013
        Button14.BackgroundImage = My.Resources.image_part_014
        Button15.BackgroundImage = My.Resources.image_part_015
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000
        Label6.Text = Label6.Text - 1
        If Label6.Text = 0 Then
            Timer1.Enabled = False
            MessageBox.Show("yours time over")
            Label6.Text = 120
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
