Option Strict On
Option Explicit Off
Module ModuloPrincipal
   

    Public ProvinciasList As New ProvinciasCollection
    Public ClienteList As New ClientesCollection

    Public Sub main()
        Application.Run(ClientesGrid)

    End Sub
End Module


