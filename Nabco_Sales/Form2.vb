Imports Telerik.WinControls.UI

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim autoCompleteItems As RadListDataItemCollection = Me.RadDropDownList1.Items
        autoCompleteItems.Add(New RadListDataItem("Luke"))
        autoCompleteItems.Add(New RadListDataItem("Max"))
        autoCompleteItems.Add(New RadListDataItem("Adam"))
        autoCompleteItems.Add(New RadListDataItem("Henry"))
        autoCompleteItems.Add(New RadListDataItem("Jack"))
        autoCompleteItems.Add(New RadListDataItem("Ben"))
        autoCompleteItems.Add(New RadListDataItem("Tyler"))
        autoCompleteItems.Add(New RadListDataItem("Ethan"))
        autoCompleteItems.Add(New RadListDataItem("David"))
        autoCompleteItems.Add(New RadListDataItem("Mike"))
        RadDropDownList1.AutoCompleteMode = AutoCompleteMode.Suggest
        ' autoCompleteItems = RadDropDownList1.AutoCompleteDataSource
    End Sub

    Private Sub txtu2_TextChanged(sender As Object, e As EventArgs) Handles txtu2.TextChanged

    End Sub

    Private Sub txtu2_GotFocus(sender As Object, e As EventArgs) Handles txtu2.GotFocus
        Dim rec As Rectangle
        txtu2.RectangleToClient(rec)

        txtu2.TextBoxElement.AutoCompleteDropDown.ShowPopup(rec)
        '   txtu2.AutoCompleteDataSource
        '  txtu2.TextBoxElement.AutoCompleteDropDown.Show(txtu2)
    End Sub



    '   Private Sub autocompletedropdown_show(sender As Object, e As )
End Class