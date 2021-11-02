Public Class EZINVADERS
    Dim SRight As Boolean
    Dim SLeft As Boolean
    Dim shooterspeed As Integer
    Dim shotspeed As Integer
    Dim invaderspeed As Integer
    Dim invaderdrop As Integer
    Const numofinvaders As Integer = 20
    Dim iright(numofinvaders) As Boolean
    Dim invader(numofinvaders) As PictureBox
    Dim x As Integer
    Dim shotdown As Integer
    Dim paused As Boolean




    Private Sub Timermain_Tick(sender As Object, e As EventArgs) Handles Timermain.Tick
        moveshooter()
        fireshot()
        moveinvadr()
        checkhit()
        checkgameover()
    End Sub


    Private Sub EZINVADERS_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Then
            SRight = True
            SLeft = False
        End If
        If e.KeyValue = Keys.Left Then
            SLeft = True
            SRight = False
        End If
        If e.KeyValue = Keys.Space And shot.Visible = False Then
            shot.Top = PNGshooter.Top
            shot.Left = PNGshooter.Left + (PNGshooter.Width / 2) - (shot.Width / 2)
            shot.Visible = True
        End If

    End Sub

    Private Sub moveshooter()
        If SRight = True And PNGshooter.Left + PNGshooter.Width < Me.ClientRectangle.Width Then

            PNGshooter.Left += shooterspeed
        End If
        If SLeft = True And PNGshooter.Left > Me.ClientRectangle.Left Then
            PNGshooter.Left -= shooterspeed
        End If
    End Sub

    Private Sub EZINVADERS_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Right Then
            SRight = False
        End If
        If e.KeyValue = Keys.Left Then
            SLeft = False
        End If
    End Sub

    Private Sub EZINVADERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadinvaders()
        loadsetting()
    End Sub

    Private Sub loadsetting()
        paused = False
        shotspeed = 20
        shooterspeed = 8
        shot.Visible = False
        For Me.x = 1 To numofinvaders
            iright(x) = True
            invader(x).Left = (-50 * x) - (x * 5)
            invader(x).Top = 0
            invader(x).Visible = True
        Next
        invaderspeed = 3
        invaderdrop = 50
        shotdown = 0
        SRight = False
        SLeft = False
        'My.Computer
        Timermain.Enabled = True
    End Sub

    Private Sub fireshot()
        If shot.Visible = True Then
            shot.Top -= shotspeed
        End If
        If shot.Top + shot.Height < Me.ClientRectangle.Top Then
            shot.Visible = False
        End If
    End Sub
    Private Sub moveinvadr()
        For Me.x = 1 To numofinvaders
            If iright(x) = True Then
                invader(x).Left += invaderspeed
            Else
                invader(x).Left -= invaderspeed

            End If
            If invader(x).Left + invader(x).Width > Me.ClientRectangle.Width And iright(x) = True Then
                iright(x) = False
                invader(x).Top += invaderdrop
            End If
            If invader(x).Left < Me.ClientRectangle.Left And iright(x) = False Then
                iright(x) = True
                invader(x).Top += invaderdrop
            End If
        Next
    End Sub

    Private Sub checkhit()
        For Me.x = 1 To numofinvaders

            If (shot.Top + shot.Height >= invader(x).Top) And
                (shot.Top <= invader(x).Top + invader(x).Height) And
                (shot.Left + shot.Width >= invader(x).Left) And
                (shot.Left <= invader(x).Left + invader(x).Width) And
                shot.Visible = True And
                invader(x).Visible = True Then

                invader(x).Visible = False
                shotdown += 1
                shot.Visible = False
            End If
        Next




    End Sub

    Private Sub checkgameover()
        For Me.x = 1 To numofinvaders
            If invader(x).Top + invader(x).Height >= PNGshooter.Top And invader(x).Visible = True Then
                Timermain.Enabled = False
                Me.x = numofinvaders
                MsgBox("Game Over")
                playagain()
            End If


        Next
        If shotdown = numofinvaders Then
            Timermain.Enabled = False
            MsgBox("Earth Is Saved")
            playagain()
        End If
    End Sub
    Private Sub loadinvaders()
        For Me.x = 1 To numofinvaders
            invader(x) = New PictureBox
            invader(x).Image = My.Resources.invaders
            invader(x).Width = 60
            invader(x).Height = 60
            invader(x).BackColor = Color.Transparent
            Controls.Add(invader(x))
        Next
    End Sub

    Private Sub EZINVADERS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "p" Or e.KeyChar = "p" Then
            If paused = True Then
                Timermain.Enabled = True
                paused = False
            Else
                Timermain.Enabled = False
                paused = True
            End If
        End If
    End Sub

    Private Sub playagain()
        Dim result = MsgBox("play again?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            loadsetting()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub PNGshooter_Click(sender As Object, e As EventArgs) Handles PNGshooter.Click

    End Sub

    Private Sub shot_Click(sender As Object, e As EventArgs) Handles shot.Click

    End Sub
End Class
