' (C) Copyright 2019 by Matthieu Niess

Public Class Container1
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        TxtPanH.Text = "0"
        TxtPanV.Text = "0"
        Height = 508
        Width = 269

    End Sub

    Private Sub BtDuplicateLayout_Click(sender As Object, e As EventArgs) Handles BtDuplicateLayout.Click

        DuplicateLayout.IncrémenterOnglet()

    End Sub

    Private Sub BtPanH_Click(sender As Object, e As EventArgs) Handles BtPanH.Click

        Pan.PanH(CDbl(TxtPanH.Text))

    End Sub

    Private Sub BtPanV_Click(sender As Object, e As EventArgs) Handles BtPanV.Click

        Pan.PanV(CDbl(TxtPanH.Text))

    End Sub

    Private Sub TxtPanH_TextChanged(sender As Object, e As EventArgs) Handles TxtPanH.TextChanged

        If Not IsNumeric(TxtPanH.Text) Then
            MsgBox("La saisie ne correspond pas à une valeur décimale" & vbCrLf & "Veuillez saisir une valeur correcte.", vbCritical + vbOKOnly, "Erreur de saisie")
        End If

    End Sub

    Private Sub TxtPanV_TextChanged(sender As Object, e As EventArgs) Handles TxtPanV.TextChanged

        If Not IsNumeric(TxtPanV.Text) Then
            MsgBox("La saisie ne correspond pas à une valeur décimale" & vbCrLf & "Veuillez saisir une valeur correcte.", vbCritical + vbOKOnly, "Erreur de saisie")
        End If

    End Sub

    Private Sub BtDistancePanH_Click(sender As Object, e As EventArgs) Handles BtDistancePanH.Click

        TxtPanH.Text = GetDistance.GetDistance(True).ToString

    End Sub

    Private Sub BtDistancePanV_Click(sender As Object, e As EventArgs) Handles BtDistancePanV.Click

        TxtPanV.Text = GetDistance.GetDistance(False).ToString

    End Sub

    Private Sub BtAbout_Click(sender As Object, e As EventArgs) Handles BtAbout.Click

        Dim MaFenêtreAPropos As New AboutBox1
        MaFenêtreAPropos.Show()

    End Sub

End Class
