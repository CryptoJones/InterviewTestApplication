﻿Public Module CommonFunctions
Public Function WhatRadioIsSelected(ByVal grp As GroupBox) As String
    Dim rbtn As RadioButton
    Dim rbtnName As String = String.Empty
    Try
        Dim ctl As Control
        For Each ctl In grp.Controls
            If TypeOf ctl Is RadioButton Then
                rbtn = DirectCast(ctl, RadioButton)
                If rbtn.Checked Then
                    rbtnName = rbtn.Name
                    Exit For
                End If
            End If
        Next
    Catch ex As Exception
        Dim stackframe As New Diagnostics.StackFrame(1)
        Throw New Exception("An error occurred in routine, '" & stackframe.GetMethod.ReflectedType.Name & "." & System.Reflection.MethodInfo.GetCurrentMethod.Name & "'." & Environment.NewLine & "  Message was: '" & ex.Message & "'")
    End Try
    Return rbtnName
End Function

End Module
