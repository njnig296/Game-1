<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.peter = New System.Windows.Forms.PictureBox()
        Me.kong1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.wall1 = New System.Windows.Forms.PictureBox()
        Me.wall2 = New System.Windows.Forms.PictureBox()
        Me.wall3 = New System.Windows.Forms.PictureBox()
        Me.wall4 = New System.Windows.Forms.PictureBox()
        Me.wall5 = New System.Windows.Forms.PictureBox()
        Me.bullet = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.wall091 = New System.Windows.Forms.PictureBox()
        Me.wall425 = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.peter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kong1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall091, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall425, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'peter
        '
        Me.peter.BackColor = System.Drawing.Color.Maroon
        Me.peter.Image = Global.game1.My.Resources.Resources.Peter_Griffin
        Me.peter.Location = New System.Drawing.Point(795, 333)
        Me.peter.Name = "peter"
        Me.peter.Size = New System.Drawing.Size(81, 97)
        Me.peter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.peter.TabIndex = 2
        Me.peter.TabStop = False
        '
        'kong1
        '
        Me.kong1.BackColor = System.Drawing.Color.DarkRed
        Me.kong1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kong1.Image = Global.game1.My.Resources.Resources.donkeykong
        Me.kong1.Location = New System.Drawing.Point(102, 334)
        Me.kong1.Name = "kong1"
        Me.kong1.Size = New System.Drawing.Size(87, 96)
        Me.kong1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.kong1.TabIndex = 1
        Me.kong1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'wall1
        '
        Me.wall1.BackColor = System.Drawing.Color.Transparent
        Me.wall1.Location = New System.Drawing.Point(-3, 386)
        Me.wall1.Name = "wall1"
        Me.wall1.Size = New System.Drawing.Size(100, 170)
        Me.wall1.TabIndex = 4
        Me.wall1.TabStop = False
        '
        'wall2
        '
        Me.wall2.BackColor = System.Drawing.Color.Transparent
        Me.wall2.Location = New System.Drawing.Point(905, 386)
        Me.wall2.Name = "wall2"
        Me.wall2.Size = New System.Drawing.Size(100, 170)
        Me.wall2.TabIndex = 5
        Me.wall2.TabStop = False
        '
        'wall3
        '
        Me.wall3.BackColor = System.Drawing.Color.Transparent
        Me.wall3.Location = New System.Drawing.Point(2, 3)
        Me.wall3.Name = "wall3"
        Me.wall3.Size = New System.Drawing.Size(1002, 108)
        Me.wall3.TabIndex = 6
        Me.wall3.TabStop = False
        '
        'wall4
        '
        Me.wall4.BackColor = System.Drawing.Color.Transparent
        Me.wall4.Location = New System.Drawing.Point(5, 240)
        Me.wall4.Name = "wall4"
        Me.wall4.Size = New System.Drawing.Size(91, 146)
        Me.wall4.TabIndex = 7
        Me.wall4.TabStop = False
        '
        'wall5
        '
        Me.wall5.BackColor = System.Drawing.Color.Transparent
        Me.wall5.Location = New System.Drawing.Point(906, 247)
        Me.wall5.Name = "wall5"
        Me.wall5.Size = New System.Drawing.Size(97, 138)
        Me.wall5.TabIndex = 8
        Me.wall5.TabStop = False
        '
        'bullet
        '
        Me.bullet.Location = New System.Drawing.Point(688, 416)
        Me.bullet.Name = "bullet"
        Me.bullet.Size = New System.Drawing.Size(37, 37)
        Me.bullet.TabIndex = 9
        Me.bullet.TabStop = False
        Me.bullet.Visible = False
        '
        'wall091
        '
        Me.wall091.BackColor = System.Drawing.Color.Transparent
        Me.wall091.Location = New System.Drawing.Point(2, 112)
        Me.wall091.Name = "wall091"
        Me.wall091.Size = New System.Drawing.Size(95, 135)
        Me.wall091.TabIndex = 10
        Me.wall091.TabStop = False
        '
        'wall425
        '
        Me.wall425.BackColor = System.Drawing.Color.Transparent
        Me.wall425.Location = New System.Drawing.Point(905, 112)
        Me.wall425.Name = "wall425"
        Me.wall425.Size = New System.Drawing.Size(99, 135)
        Me.wall425.TabIndex = 11
        Me.wall425.TabStop = False
        '
        'Timer3
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.game1.My.Resources.Resources.boxingrink1
        Me.ClientSize = New System.Drawing.Size(1005, 632)
        Me.Controls.Add(Me.wall425)
        Me.Controls.Add(Me.wall091)
        Me.Controls.Add(Me.bullet)
        Me.Controls.Add(Me.wall5)
        Me.Controls.Add(Me.wall4)
        Me.Controls.Add(Me.wall3)
        Me.Controls.Add(Me.wall2)
        Me.Controls.Add(Me.wall1)
        Me.Controls.Add(Me.peter)
        Me.Controls.Add(Me.kong1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.peter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kong1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall091, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall425, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents kong1 As PictureBox
    Friend WithEvents peter As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents wall1 As PictureBox
    Friend WithEvents wall2 As PictureBox
    Friend WithEvents wall3 As PictureBox
    Friend WithEvents wall4 As PictureBox
    Friend WithEvents wall5 As PictureBox
    Friend WithEvents bullet As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents wall091 As PictureBox
    Friend WithEvents wall425 As PictureBox
    Friend WithEvents Timer3 As Timer
End Class
