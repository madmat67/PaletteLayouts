' (C) Copyright 2019 by Matthieu Niess

Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Geometry

Public Class Pan

    Public Shared Sub PanV(ByVal PanValue As Double)

        Dim acDoc As Document = Application.DocumentManager.MdiActiveDocument
        Dim acCurDb As Database = acDoc.Database
        Dim myEd = acDoc.Editor
        Dim vtr As ViewTableRecord = Nothing
        Dim myVector As New Vector2d(CDbl(0), PanValue)
        Using acTrans As Transaction = acCurDb.TransactionManager.StartTransaction()
            '' Get the current view
            Using acView As ViewTableRecord = acDoc.Editor.GetCurrentView()
                acView.CenterPoint = acView.CenterPoint + myVector
                acDoc.Editor.SetCurrentView(acView)
            End Using
            '' Commit the changes
            acTrans.Commit()
        End Using

        'vtr.CenterPoint = vtr.CenterPoint + myVector
        'myEd.SetCurrentView(vtr)
        myEd.WriteMessage(vbCrLf & "Pan vertical effectué.")

    End Sub

    Public Shared Sub PanH(ByVal PanValue As Double)

        Dim acDoc As Document = Application.DocumentManager.MdiActiveDocument
        Dim acCurDb As Database = acDoc.Database
        Dim myEd = acDoc.Editor
        Dim vtr As ViewTableRecord = Nothing
        Dim myVector As New Vector2d(PanValue, CDbl(0))

        Using acTrans As Transaction = acCurDb.TransactionManager.StartTransaction()
            '' Get the current view
            Using acView As ViewTableRecord = acDoc.Editor.GetCurrentView()
                acView.CenterPoint = acView.CenterPoint + myVector
                acDoc.Editor.SetCurrentView(acView)
            End Using
            '' Commit the changes
            acTrans.Commit()
        End Using

        'vtr.CenterPoint = vtr.CenterPoint + myVector
        'myEd.SetCurrentView(vtr)

        myEd.WriteMessage(vbCrLf & "Pan horizontal effectué.")

    End Sub

End Class
