<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Container1
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtDuplicateLayout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtDistancePanV = New System.Windows.Forms.Button()
        Me.BtDistancePanH = New System.Windows.Forms.Button()
        Me.TxtPanV = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtPanV = New System.Windows.Forms.Button()
        Me.TxtPanH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtPanH = New System.Windows.Forms.Button()
        Me.BtAbout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtDuplicateLayout
        '
        Me.BtDuplicateLayout.Location = New System.Drawing.Point(6, 39)
        Me.BtDuplicateLayout.Name = "BtDuplicateLayout"
        Me.BtDuplicateLayout.Size = New System.Drawing.Size(141, 23)
        Me.BtDuplicateLayout.TabIndex = 0
        Me.BtDuplicateLayout.Text = "Dupliquer le dernier onglet"
        Me.BtDuplicateLayout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dupliquer + incrémenter le dernier onglet"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtDuplicateLayout)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 82)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Outils onglets"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtDistancePanV)
        Me.GroupBox2.Controls.Add(Me.BtDistancePanH)
        Me.GroupBox2.Controls.Add(Me.TxtPanV)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BtPanV)
        Me.GroupBox2.Controls.Add(Me.TxtPanH)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BtPanH)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 191)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Déplacements des vues dans les fenêtres"
        '
        'BtDistancePanV
        '
        Me.BtDistancePanV.Location = New System.Drawing.Point(120, 120)
        Me.BtDistancePanV.Name = "BtDistancePanV"
        Me.BtDistancePanV.Size = New System.Drawing.Size(59, 20)
        Me.BtDistancePanV.TabIndex = 7
        Me.BtDistancePanV.Text = "Distance"
        Me.BtDistancePanV.UseVisualStyleBackColor = True
        '
        'BtDistancePanH
        '
        Me.BtDistancePanH.Location = New System.Drawing.Point(120, 36)
        Me.BtDistancePanH.Name = "BtDistancePanH"
        Me.BtDistancePanH.Size = New System.Drawing.Size(59, 20)
        Me.BtDistancePanH.TabIndex = 6
        Me.BtDistancePanH.Text = "Distance"
        Me.BtDistancePanH.UseVisualStyleBackColor = True
        '
        'TxtPanV
        '
        Me.TxtPanV.Location = New System.Drawing.Point(6, 120)
        Me.TxtPanV.Name = "TxtPanV"
        Me.TxtPanV.Size = New System.Drawing.Size(108, 20)
        Me.TxtPanV.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.CausesValidation = False
        Me.Label3.Location = New System.Drawing.Point(3, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Valeur du Pan vertical :"
        '
        'BtPanV
        '
        Me.BtPanV.Location = New System.Drawing.Point(6, 146)
        Me.BtPanV.Name = "BtPanV"
        Me.BtPanV.Size = New System.Drawing.Size(108, 23)
        Me.BtPanV.TabIndex = 3
        Me.BtPanV.Text = "Pan Vertical"
        Me.BtPanV.UseVisualStyleBackColor = True
        '
        'TxtPanH
        '
        Me.TxtPanH.Location = New System.Drawing.Point(6, 36)
        Me.TxtPanH.Name = "TxtPanH"
        Me.TxtPanH.Size = New System.Drawing.Size(108, 20)
        Me.TxtPanH.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valeur du Pan horizontal :"
        '
        'BtPanH
        '
        Me.BtPanH.Location = New System.Drawing.Point(6, 62)
        Me.BtPanH.Name = "BtPanH"
        Me.BtPanH.Size = New System.Drawing.Size(108, 23)
        Me.BtPanH.TabIndex = 0
        Me.BtPanH.Text = "Pan Horizontal"
        Me.BtPanH.UseVisualStyleBackColor = True
        '
        'BtAbout
        '
        Me.BtAbout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtAbout.Location = New System.Drawing.Point(0, 437)
        Me.BtAbout.Name = "BtAbout"
        Me.BtAbout.Size = New System.Drawing.Size(265, 23)
        Me.BtAbout.TabIndex = 5
        Me.BtAbout.Text = "A propos"
        Me.BtAbout.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Image = Global.PaletteLayouts.My.Resources.Resources.Eiffage_Métal_2400_01_colour_RGB
        Me.PictureBox1.Location = New System.Drawing.Point(0, 460)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(265, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Container1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.BtAbout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Container1"
        Me.Size = New System.Drawing.Size(265, 508)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtDuplicateLayout As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents TxtPanV As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents BtPanV As Windows.Forms.Button
    Friend WithEvents TxtPanH As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents BtPanH As Windows.Forms.Button
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents BtDistancePanV As Windows.Forms.Button
    Friend WithEvents BtDistancePanH As Windows.Forms.Button
    Friend WithEvents BtAbout As Windows.Forms.Button
End Class
