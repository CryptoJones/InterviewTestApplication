Public Class FTops
    Private Sub On_Load(sender As Object, e As EventArgs) Handles MyBase.Load
           
       If rbCat_000.Enabled Then rbCat_000.Select
       If rbType_000.Enabled Then rbType_000.Select
       If rbSize_000.Enabled Then rbSize_000.Select
       If rbColor_000.Enabled Then rbColor_000.Select

      On_Changed(New Object, New EventArgs)
   
    End Sub

    Private Sub On_Changed(sender As Object, e As EventArgs) Handles _
            rbCat_000.Click, rbCat_001.Click, rbCat_002.Click, rbCat_003.Click, rbCat_004.Click, rbCat_005.Click, _
            rbType_000.Click, rbType_001.Click, rbType_002.Click, rbType_003.Click, rbType_004.Click, _
            rbSize_000.Click, rbSize_001.Click, rbSize_002.Click, rbSize_003.Click, rbSize_004.Click, _
            rbSize_005.Click, rbSize_006.Click, rbSize_007.Click, rbSize_008.Click, rbSize_009.Click, _
            rbSize_010.Click, rbSize_011.Click, rbSize_012.Click, rbSize_013.Click, rbSize_014.Click, _
            rbSize_015.Click, rbSize_016.Click, _
            rbColor_000.Click, rbColor_001.Click, rbColor_002.Click, rbColor_003.Click, rbColor_004.Click, _
            rbColor_005.Click, rbColor_006.Click, rbColor_007.CLick, rbColor_008.Click, rbColor_009.Click, _
            rbColor_010.Click

        Dim selectedType = WhatRadioIsSelected(gbType)
        If selectedType = "" Then Exit Sub
        Dim typeNumber As Integer = selectedType.Substring(8)

        Dim selectedCat = WhatRadioIsSelected(gbCat)
        If selectedCat = "" Then Exit Sub
        Dim catNumber As Integer = selectedCat.Substring(8)

        Dim selectedSize = WhatRadioIsSelected(gbSize)
        If selectedSize = "" Then Exit Sub
        Dim sizeNumber As Integer = selectedSize.Substring(7)

        Dim selectedColor = WhatRadioIsSelected(gbColor)
        If selectedColor = "" Then Exit Sub
        Dim colorNumber As Integer = selectedColor.Substring(8)

        Dim ctl As Control

        For Each ctl In gbCat.Controls
            Dim thisNumber As Integer = ctl.Name.Substring(8)
            ctl.Enabled = ValidTopCatByType(thisNumber, typeNumber)
        Next

        For Each ctl In gbSize.Controls
            Dim thisNumber As Integer = ctl.Name.Substring(7)
            ctl.Enabled = ValidTopSizeByType(thisNumber, typeNumber)
        Next

        For Each ctl In gbColor.Controls
            Dim thisNumber As Integer = ctl.Name.Substring(8)
            ctl.Enabled = ValidTopColorBySizeTypeAndCat(thisNumber, sizeNumber, typeNumber, catNumber)
        Next

        
       If ValidateRadioButtons() Then

       End If

    End Sub

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        If Not ValidateRadioButtons() Then
            Exit Sub
        End If

        Dim selectedCat = WhatRadioIsSelected(gbCat)
        Dim selectedType = WhatRadioIsSelected(gbType)
        Dim selectedSize = WhatRadioIsSelected(gbSize)
        Dim selectedColor = WhatRadioIsSelected(gbColor)

        If selectedCat.Equals("") Or selectedType.Equals("") Or _
           selectedSize.Equals("") Or selectedColor.Equals("") Then
            MessageBox.Show("Must choose a selection!")
        Else
            MessageBox.Show("Order Sent!")
            Me.Close
        End If

    End Sub

    Private Function ValidateRadioButtons() As Boolean
        For Each rb As RadioButton In gbType.Controls
            If Not rb.Enabled AndAlso rb.Checked Then
                MessageBox.Show("Invalid Type Option is Selected! Please change Selection!")
                Return False
            End If
        Next

        For Each rb As RadioButton In gbCat.Controls
            If Not rb.Enabled AndAlso rb.Checked Then
                MessageBox.Show("Invalid Category Option is Selected! Please change Selection!")
                Return False
            End If
        Next

        For Each rb As RadioButton In gbColor.Controls
            If Not rb.Enabled AndAlso rb.Checked Then
                MessageBox.Show("Invalid Color Option is Selected! Please change Selection!")
                Return False
            End If
        Next

        For Each rb As RadioButton In gbSize.Controls
            If Not rb.Enabled AndAlso rb.Checked Then
                MessageBox.Show("Invalid Size Option is Selected! Please change Selection!")
               Return False
            End If
        Next

        Return True
    End Function

End Class