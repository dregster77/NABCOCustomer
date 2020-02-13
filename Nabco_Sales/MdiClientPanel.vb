Public Class MdiClientPanel
    Inherits Panel

    Private _ctlClient As MdiClient = New MdiClient()
    Public Delegate Sub ActivateHandler(ByVal sender As Object, ByVal child As MdiClientForm)
    Public Event OnChildActivated As ActivateHandler
    Public Property ActiveMDIWnd As Form
    Public ChildForms As List(Of MdiClientForm) = New List(Of MdiClientForm)()

    Public Sub New()
        MyBase.Controls.Add(_ctlClient)
    End Sub

    Private _mdiForm As Form = Nothing

    Public ReadOnly Property MdiForm As Form
        Get

            If _mdiForm Is Nothing Then
                _mdiForm = New Form()
                Dim field As System.Reflection.FieldInfo = GetType(Form).GetField("ctlClient", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
                field.SetValue(_mdiForm, _ctlClient)
            End If

            Return _mdiForm
        End Get
    End Property

    Private Sub InitializeComponent()
        SuspendLayout()
        ResumeLayout(False)
    End Sub

    Public Function AddChild(ByVal child As MdiClientForm) As MdiClientForm
        child.MyMdiContainer = Me
        child.MdiParent = MdiForm
        ChildForms.Add(child)
        Return child
    End Function

    Public Sub RestoreChildForms()
        For Each child As MdiClientForm In ChildForms
            child.WindowState = FormWindowState.Normal
            child.MaximizeBox = True
            child.MinimizeBox = True
        Next
    End Sub

    Public Sub ChildActivated(ByVal child As MdiClientForm)
        ActiveMDIWnd = child
        RaiseEvent OnChildActivated(Me, child)
    End Sub

    Public Sub ChildClosed(ByVal child As MdiClientForm)
        ChildForms.Remove(child)
    End Sub
End Class

Public Class MdiClientForm
    Inherits Form

    Public Property MyMdiContainer As MdiClientPanel




End Class

