Module Program
    Private m_frmHome As frmHome

    Public ReadOnly Property frmHome() As frmHome
        Get
            Return m_frmHome
        End Get
    End Property

    Public Sub Main()
        m_frmHome = New frmHome()
        Application.Run(m_frmHome)
    End Sub
End Module
