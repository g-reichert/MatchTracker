﻿Public Class frmGame

    Private points() As String = {"0", "15", "30", "40", "AD"}
    Private intcurrentPoint1 As Integer
    Private intcurrentPoint2 As Integer


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblP1Score.Click

    End Sub

    Private Sub btnP1Point_Click(sender As Object, e As EventArgs) Handles btnP1Point.Click
        intWonLastPoint = 1
        frmPoint.Show()

        If lblP1Score.Text = "40" AndAlso lblP2Score.Text = "40" Then
            intcurrentPoint1 = 4
            lblP1Score.Text = points(intcurrentPoint1)
        ElseIf lblP1Score.Text = "40" AndAlso lblP2Score.Text = "AD" Then
            intcurrentPoint2 = 3
            lblP2Score.Text = points(intcurrentPoint2)
        ElseIf lblP1Score.Text = "40" AndAlso lblP2Score.Text <> "40" Then
            intcurrentPoint1 = 3
            lblP1Score.Text = points(intcurrentPoint1)
            chkPlayer1.Checked = True

        ElseIf lblP1Score.Text = "AD" Xor lblP2Score.Text = "AD" Then
            chkPlayer1.Checked = True
        Else
            intcurrentPoint1 = intcurrentPoint1 + 1
            lblP1Score.Text = points(intcurrentPoint1)
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnGameSubmit_Click(sender As Object, e As EventArgs) Handles btnGameSubmit.Click
        'check which player's winner box is checked, then add one to their game score in the current set
        If chkPlayer1.Checked = True Then
            If intCurrentSet = 1 Then
                intP1S1Score = intP1S1Score + 1
                frmMain.lblP1S1.Text = intP1S1Score.ToString()
            ElseIf intCurrentSet = 2 Then
                intP1S2Score = intP1S2Score + 1
                frmMain.lblP1S2.Text = intP1S2Score.ToString()
            ElseIf intCurrentSet = 3 Then
                intP1S3Score = intP1S3Score + 1
                frmMain.lblP1S3.Text = intP1S3Score.ToString()
            End If
        ElseIf chkPlayer2.Checked = True Then
            If intCurrentSet = 1 Then
                intP2S1Score = intP2S1Score + 1
                frmMain.lblP2S1.Text = intP2S1Score.ToString()
            ElseIf intCurrentSet = 2 Then
                intP2S2Score = intP2S2Score + 1
                frmMain.lblP2S2.Text = intP2S2Score.ToString()
            ElseIf intCurrentSet = 3 Then
                intP2S3Score = intP2S3Score + 1
                frmMain.lblP2S3.Text = intP2S3Score.ToString()
            End If
        End If

        intP1TotalPoints = intP1TotalPoints + intP1Points
        frmMain.lblP1Stat1.Text = intP1TotalPoints.ToString()

        intP2TotalPoints = intP2TotalPoints + intP2Points
        frmMain.lblP2Stat1.Text = intP2TotalPoints.ToString()

        Me.Close()
    End Sub

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPlayer1.Text = strPlayer1
        lblPlayer2.Text = strPlayer2
        intP1Points = 0
        intP2Points = 0
    End Sub

    Private Sub btnP2Point_Click(sender As Object, e As EventArgs) Handles btnP2Point.Click
        intWonLastPoint = 2
        frmPoint.Show()

        If lblP1Score.Text = "40" AndAlso lblP2Score.Text = "40" Then
            intcurrentPoint2 = 4
            lblP2Score.Text = points(intcurrentPoint2)
        ElseIf lblP1Score.Text = "AD" AndAlso lblP2Score.Text = "40" Then
            intcurrentPoint1 = 3
            lblP1Score.Text = points(intcurrentPoint1)
        ElseIf lblP1Score.Text <> "40" AndAlso lblP2Score.Text = "40" Then
            chkPlayer2.Checked = True
        ElseIf lblP1Score.Text = "AD" Xor lblP2Score.Text = "AD" Then
            chkPlayer2.Checked = True
        Else
            intcurrentPoint2 = intcurrentPoint2 + 1
            lblP2Score.Text = points(intcurrentPoint2)
        End If


    End Sub

    Private Sub btnP1FirstServe_Click(sender As Object, e As EventArgs) Handles btnP1FirstServe.Click
        ' add 1 to number of first serves
        intP1FirstServe = intP1FirstServe + 1
        ' add 1 to total number of serves
        intP1Serves = intP1Serves + 1
        ' update first serve percentage
        frmStat.lblStatPageP1FirstServePerc.Text = intP1FirstServe & "/" & intP1Serves & " (" & (intP1FirstServe / intP1Serves).ToString("p1") & ")"
        btnP1FirstServe.BackColor = Color.DarkSlateGray
        btnP1FirstServe.ForeColor = Color.White

    End Sub

    Private Sub btnP1SecondServe_Click(sender As Object, e As EventArgs) Handles btnP1SecondServe.Click
        intP1SecondServe = intP1SecondServe + 1
        intP1Serves = intP1Serves + 1

        btnP1SecondServe.BackColor = Color.DarkSlateGray
        btnP1SecondServe.ForeColor = Color.White
    End Sub

    Private Sub btnP2FirstServe_Click(sender As Object, e As EventArgs) Handles btnP2FirstServe.Click
        ' add 1 o number of first serves
        intP2FirstServe = intP2FirstServe + 1
        ' add 1 to total number of serves
        intP2Serves = intP2Serves + 1
        ' update first serve percentage
        frmStat.lblStatPageP2FirstServePerc.Text = intP2FirstServe & "/" & intP2Serves & " (" & (intP2FirstServe / intP2Serves).ToString("p1") & ")"

        btnP2FirstServe.BackColor = Color.DarkSlateGray
        btnP2FirstServe.ForeColor = Color.White
    End Sub

    Private Sub btnP2SecondServe_Click(sender As Object, e As EventArgs) Handles btnP2SecondServe.Click
        intP2SecondServe = intP2SecondServe + 1
        intP2Serves = intP2Serves + 1

        btnP2SecondServe.BackColor = Color.DarkSlateGray
        btnP2SecondServe.ForeColor = Color.White
    End Sub

End Class