Module Module1
    Sub checkbutton(ByRef Butt1 As Button, ByRef Butt2 As Button)
        If Butt2.Text = "" Then
            Butt2.Text = Butt1.Text
            Butt2.BackgroundImage = Butt1.BackgroundImage
            Butt1.Text = ""
            Butt1.BackgroundImage = Nothing

        End If
    End Sub
End Module
