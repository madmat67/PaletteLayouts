' (C) Copyright 2019 by Matthieu Niess

Imports Autodesk.AutoCAD.Runtime

' This line is not mandatory, but improves loading performances
<Assembly: ExtensionApplication(GetType(PaletteLayouts.MyPlugin))>

Namespace PaletteLayouts

    Public Class MyPlugin
        Implements IExtensionApplication

        Public Sub Initialize() Implements IExtensionApplication.Initialize

        End Sub

        Public Sub Terminate() Implements IExtensionApplication.Terminate

        End Sub
    End Class

End Namespace