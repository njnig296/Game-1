Public Class Form1
    Dim r As New Random
    Dim score As Integer
    Sub randmove(p As PictureBox)
        Dim x As Integer
        Dim y As Integer
        x = r.Next(-10, 11)
        x = r.Next(-10, 11)
        MoveTo(p, x, y)
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                MoveTo(peter, 0, -10)
            Case Keys.Down
                MoveTo(peter, 0, 10)
            Case Keys.Left
                MoveTo(peter, -10, 0)
            Case Keys.Right
                MoveTo(peter, 10, 0)
            Case Keys.Space
                bullet.Location = peter.Location
                bullet.Visible = True
            Case Keys.R
                peter.Image.RotateFlip(RotateFlipType.Rotate90FlipX)
                Me.Refresh()

            Case Keys.W
                MoveTo(bullet, 0, -50)
            Case Keys.S
                MoveTo(bullet, 0, 50)
            Case Keys.A
                MoveTo(bullet, -50, 0)
            Case Keys.D
                MoveTo(bullet, 50, 0)
            Case Keys.Space
                bullet.Location = bullet.Location
                bullet.Visible = True


        End Select
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs)
        MoveTo(bullet, 5, 5)
    End Sub

    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(peter.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > peter.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < peter.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(p, x, y)
    End Sub

    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    Function Collision(p As PictureBox, t As String)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
            End If
            If p.Name.Contains("bullet") And obj.Name.Contains("kong") And
                p.Bounds.IntersectsWith(obj.Bounds) Then
                obj.Visible = False

            End If
        Next
        For Each c In Controls
            Dim obj As Control
            obj = c
            If p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
            End If
            If p.Name.Contains("kong") And obj.Name.Contains("peter") And
                p.Bounds.IntersectsWith(obj.Bounds) Then
                obj.Visible = False

            End If
        Next

        Return col
    End Function

    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles bullet.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles peter.Click

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles wall091.Click

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        chase(kong1)
        randmove(kong1)
    End Sub
End Class
