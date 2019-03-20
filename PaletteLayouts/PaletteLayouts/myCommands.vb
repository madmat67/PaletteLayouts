' (C) Copyright 2019 by Matthieu Niess

Imports Autodesk.AutoCAD.Runtime

' This line is not mandatory, but improves loading performances
<Assembly: CommandClass(GetType(PaletteLayouts.MyCommands))>
Namespace PaletteLayouts

    Public Class MyCommands

        'ensure single instance of this app...
        Friend Shared m_ps As Autodesk.AutoCAD.Windows.PaletteSet = Nothing

        <CommandMethod("PaletteLayouts", CommandFlags.Modal)>
        Public Sub PaletteLayouts()

            If m_ps Is Nothing Then
                'no so create it
                m_ps = New Autodesk.AutoCAD.Windows.PaletteSet("Outils de présentations")
                'create new instance of user control
                m_ps.Size = New System.Drawing.Size(269, 508)
                Dim myPalette As Container1 = New Container1()
                'add it to the paletteset
                m_ps.Size = New System.Drawing.Size(270, 510)
                m_ps.Add("Outils de présentations", myPalette)
                m_ps.Size = New System.Drawing.Size(275, 515)
            End If
            'turn it on
            m_ps.Visible = True
        End Sub

    End Class

End Namespace