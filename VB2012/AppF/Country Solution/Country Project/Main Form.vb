﻿' Name:         Country Project
' Purpose:      Demonstrate a multiple-form application
'               using a main form and a splash screen
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
