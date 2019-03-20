' (C) Copyright 2019 by Matthieu Niess

Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices

Public Class DuplicateLayout

    Public Shared Sub IncrémenterOnglet()

        '----------On liste tous les Layouts---------- 
        ' On récupère la BD
        Dim acDoc As Document = Application.DocumentManager.MdiActiveDocument
        Dim acCurDb As Database = acDoc.Database

        'Quelques déclarations
        Dim Max As String = "0"
        Dim myListeDeLayouts As New List(Of String)

        'On récupère le dictionnaire des Layouts dans la BD
        Using acTrans As Transaction = acCurDb.TransactionManager.StartTransaction()
            Dim lays As DBDictionary =
            acTrans.GetObject(acCurDb.LayoutDictionaryId, OpenMode.ForRead)

            'Boucle traitant chaque Layout récupéré dans la BD
            For Each item As DBDictionaryEntry In lays
                myListeDeLayouts.Add(item.Key.ToString)
            Next

            'On annule la transaction vu que l'on n'a rien modifié dans le fichier pour l'instant
            acTrans.Abort()
        End Using

        'On traite la liste des Layouts
        For Each s As String In myListeDeLayouts
            If IsNumeric(s) = True Then
                If s > Max Then Max = s
            End If
        Next

        '----------On copie la dernière page et on crée la page suivante avec le numéro +1----------
        Dim newLayoutName As String = (CInt(Max) + 1).ToString
        Dim copyLayoutName As String = Max

        Using acDoc.LockDocument
            ' Get the layout and plot settings of the named pagesetup
            Using acTrans As Transaction = acCurDb.TransactionManager.StartTransaction()


                'On déclare le gestionnaire de Layouts
                Dim acLayoutMgr As LayoutManager = LayoutManager.Current

                'Copie du dernier Layout, avec le nouveau nom +1 (voir déclaration + haut)
                acLayoutMgr.CopyLayout(copyLayoutName, newLayoutName)

                'Décalartion : On met le Layout crée en mémoire
                Dim acLayout As Layout = acTrans.GetObject(acLayoutMgr.GetLayoutId(newLayoutName), OpenMode.ForWrite)

                'On active le Layout mis en mémoire
                acLayoutMgr.CurrentLayout = newLayoutName

                'On enregistre les modifications avant de quitter la transaction
                acTrans.Commit()
            End Using
        End Using

    End Sub

End Class
