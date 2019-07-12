Public Class FHats
    Private Sub On_Load(sender As Object, e As EventArgs) Handles MyBase.Load

       If rbStyle_000.Enabled Then rbStyle_000.Select
       If rbColor_000.Enabled Then rbColor_000.Select

    End Sub

    Private Sub On_Changed(sender As Object, e As EventArgs) Handles rbStyle_000.Click, rbStyle_001.Click, rbStyle_002.Click, rbColor_000.Click, rbColor_001.Click, rbColor_002.Click, rbColor_003.Click, rbColor_004.Click, rbColor_005.Click, rbColor_006.Click, rbColor_007.Click, rbColor_008.Click, rbColor_009.Click, rbColor_010.Click

        Dim selectedStyle = WhatRadioIsSelected(gbStyles)
        Dim styleNumber As Integer = selectedStyle.Substring(8)

        Dim ctl As Control
        For Each ctl In gbColor.Controls
            Dim selectedColor As String = ctl.Name
            Dim colorNumber As Integer = selectedColor.Substring(8)
            ctl.Enabled = ValidHatColorsByStyle(styleNumber, colorNumber)
        Next

        If ValidateRadioButtons()

        End If


    End Sub

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        If Not ValidateRadioButtons() Then
            Exit Sub
        End If

        Dim selectedStyle = WhatRadioIsSelected(gbStyles)
        Dim selectedColor = WhatRadioIsSelected(gbColor)
        If selectedStyle.Equals("") Or selectedColor.Equals("") Then
            MessageBox.Show("Must choose a selection!")
            Else
            MessageBox.Show("Order Sent!")
            Me.Close
        End If

    End Sub

    Private Function ValidateRadioButtons() As Boolean
        For Each rb As RadioButton In gbColor.Controls
            If Not rb.Enabled AndAlso rb.Checked Then
                MessageBox.Show("Invalid Option is Selected! Please change Selection!")
                Return False
            End If
        Next

        Return True
    End Function
End Class