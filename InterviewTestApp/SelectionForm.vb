Public Class SelectionForm
    Private Sub BtnTops_Click(sender As Object, e As EventArgs) Handles btnTops.Click
        Dim btnTops_Window As FTops = New FTops
        btnTops_Window.Show()
    End Sub

    Private Sub BtnHats_Click(sender As Object, e As EventArgs) Handles btnHats.Click
        Dim btnHats_Window As FHats = New FHats
        btnHats_Window.Show()
    End Sub
End Class
