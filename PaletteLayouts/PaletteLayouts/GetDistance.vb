' (C) Copyright 2019 by Matthieu Niess

Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Geometry
Imports Autodesk.AutoCAD.EditorInput

Public Class GetDistance

    Public Shared Function GetDistance(ByVal Horizontal As Boolean) As Double

        Dim acDoc As Document = Application.DocumentManager.MdiActiveDocument
        Dim acCurDb As Database = acDoc.Database
        Dim myEd = acDoc.Editor

        Dim pPtRes As PromptPointResult
        Dim pPtOpts As PromptPointOptions = New PromptPointOptions("")

        '' Prompt for 1st point
        pPtOpts.Message = vbLf & "Distance du Pan - Sélectionnez le 1er point : "
        pPtRes = acDoc.Editor.GetPoint(pPtOpts)
        Dim ptStart As Point3d = pPtRes.Value

        '' Exit if the user presses ESC or cancels the command
        If pPtRes.Status = PromptStatus.Cancel Then
            GetDistance = 0
            Exit Function
        End If

        '' Prompt for 2nd point
        pPtOpts.Message = vbLf & "Sélectionnez le 2nd point : "
        pPtOpts.UseBasePoint = True
        pPtOpts.BasePoint = ptStart
        pPtRes = acDoc.Editor.GetPoint(pPtOpts)
        Dim ptEnd As Point3d = pPtRes.Value

        '' Exit if the user presses ESC or cancels the command
        If pPtRes.Status = PromptStatus.Cancel Then
            GetDistance = 0
            Exit Function
        End If

        Select Case Horizontal
            Case True
                GetDistance = ptEnd.X - ptStart.X
            Case False
                GetDistance = ptEnd.Y - ptStart.Y
        End Select

        'GetDistance = ptStart.GetVectorTo(ptEnd).Length

        myEd.WriteMessage(vbCrLf & "Distance récupérée avec succès.")

    End Function

End Class
