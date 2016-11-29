'=============Description==============
'Started on: 11/26/2016
'Started by: Alex Easter
'
'UI for the Start Menu
'======================================

Public Class frmYahtzeeStartLoad
    Dim sngSpace As Single = 10
    Dim shtPlayerCount As Short


    Private Sub frmYahtzeeStartLoad_Load(sender As Object,
                                         e As EventArgs) Handles Me.Load
        '======================================================================
        '               -Description/Written: By Alex Easter-
        '
        'Load all necessary data
        'Align all objects in pnlStartMenuTitle
        '======================================================================


        'btnConfirm.Visible = False
        'pnlChoosePlayers.Visible = False

        'Load data_highscore

        'If data is null Then
        'lblHighScore.Text = "Highscore: " + "0"
        'End If


        lblStartMenuTitle.Left = (pnlStartLoad.Width / 2) -
            (lblStartMenuTitle.Width / 2)
        lblStartMenuTitle.Top = sngSpace

        btnLoad.Left = (pnlStartLoad.Width / 2) - btnLoad.Width -
            (sngSpace / 2)
        btnLoad.Top = (pnlStartLoad.Height / 4)

        btnStartNewGame.Left = btnLoad.Left + btnLoad.Width + sngSpace
        btnStartNewGame.Top = btnLoad.Top

        btnExit.Left = btnLoad.Left + (btnLoad.Width / 2) + (sngSpace / 2)
        btnExit.Top = btnLoad.Top + btnLoad.Height + sngSpace

        pnlChoosePlayers.Left = (pnlStartLoad.Width / 2) -
            (pnlChoosePlayers.Width / 2)
        pnlChoosePlayers.Top = pnlStartLoad.Height * (3 / 4) -
            pnlChoosePlayers.Height / 2

        lblHighScore.Left = btnLoad.Left
        lblHighScore.Top = btnExit.Top + btnExit.Height + sngSpace

        lblChoosePlayers.Left = (pnlChoosePlayers.Width / 2) -
            (lblChoosePlayers.Width / 2)
        lblChoosePlayers.Top = sngSpace

        rad1P.Width = pnlChoosePlayers.Width / 7
        rad2P.Size = rad1P.Size
        rad3P.Size = rad1P.Size
        rad4P.Size = rad1P.Size
        rad5P.Size = rad1P.Size
        rad6P.Size = rad1P.Size
        rad7P.Size = rad1P.Size

        rad1P.Left = sngSpace / 4
        rad2P.Left = rad1P.Left + rad1P.Width * 1
        rad3P.Left = rad1P.Left + rad1P.Width * 2
        rad4P.Left = rad1P.Left + rad1P.Width * 3
        rad5P.Left = rad1P.Left + rad1P.Width * 4
        rad6P.Left = rad1P.Left + rad1P.Width * 5
        rad7P.Left = rad1P.Left + rad1P.Width * 6
        rad1P.Top = pnlChoosePlayers.Height / 2 - rad1P.Height / 2
        rad2P.Top = rad1P.Top
        rad3P.Top = rad1P.Top
        rad4P.Top = rad1P.Top
        rad5P.Top = rad1P.Top
        rad6P.Top = rad1P.Top
        rad7P.Top = rad1P.Top

        btnConfirm.Left = (pnlChoosePlayers.Width / 2) -
            (btnConfirm.Width / 2)
        btnConfirm.Top = pnlChoosePlayers.Height * (3 / 4) - (btnConfirm.Height / 2)

    End Sub

    Private Sub btnExit_Click(sender As Object,
                              e As EventArgs) Handles btnExit.Click
        '======================================================================
        '               -Description/Written: By Alex Easter-
        'Save(??) and close the program
        '======================================================================
        Me.Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object,
                              e As EventArgs) Handles btnLoad.Click
        '======================================================================
        '               -Description/Written: By Alex Easter-
        'Load previously saved game, and starts game were it was last left off
        '======================================================================

    End Sub

    Private Sub btnStartNewGame_Click(sender As Object,
                                  e As EventArgs) Handles btnStartNewGame.Click
        '======================================================================
        '               -Description/Written: By Alex Easter-
        'Open window asking for number of players
        '======================================================================
        If pnlChoosePlayers.Visible = False Then
            pnlChoosePlayers.Visible = True
        End If
    End Sub

    Private Sub rad1P_CheckedChanged(sender As Object,
                                   e As EventArgs) Handles rad1P.CheckedChanged
        '======================================================================
        '               -Description/Written: By Alex Easter-
        'When rad is checked, set btnConfirm visible
        'Also set sngPlayerCount value to corresponding value
        '======================================================================
        btnConfirm.Visible = True
        shtPlayerCount = 1
    End Sub
    Private Sub rad2P_CheckedChanged(sender As Object,
                                   e As EventArgs) Handles rad2P.CheckedChanged
        '======================================================================
        '               -Description/Written: By Alex Easter-
        'When rad is checked, set btnConfirm visible
        'Also set sngPlayerCount value to corresponding value
        '======================================================================
        btnConfirm.Visible = True
        shtPlayerCount = 2
    End Sub
    Private Sub rad3P_CheckedChanged(sender As Object,
                                   e As EventArgs) Handles rad3P.CheckedChanged
        '======================================================================
        '               -Description/Written: By Alex Easter-
        'When rad is checked, set btnConfirm visible
        'Also set sngPlayerCount value to corresponding value
        '======================================================================
        btnConfirm.Visible = True
        shtPlayerCount = 3
    End Sub
    Private Sub rad4P_CheckedChanged(sender As Object,
                                   e As EventArgs) Handles rad4P.CheckedChanged
        '======================================================================
        '               -Description/Written: By Alex Easter-
        'When rad is checked, set btnConfirm visible
        'Also set sngPlayerCount value to corresponding value
        '======================================================================
        btnConfirm.Visible = True
        shtPlayerCount = 4
    End Sub
    Private Sub rad5P_CheckedChanged(sender As Object,
                                   e As EventArgs) Handles rad5P.CheckedChanged
        '======================================================================
        '               -Description/Written: By Alex Easter-
        'When rad is checked, set btnConfirm visible
        'Also set sngPlayerCount value to corresponding value
        '======================================================================
        btnConfirm.Visible = True
        shtPlayerCount = 5
    End Sub
    Private Sub rad6P_CheckedChanged(sender As Object,
                                   e As EventArgs) Handles rad6P.CheckedChanged
        '======================================================================
        '               -Description/Written: By Alex Easter-
        'When rad is checked, set btnConfirm visible
        'Also set sngPlayerCount value to corresponding value
        '======================================================================
        btnConfirm.Visible = True
        shtPlayerCount = 6
    End Sub
    Private Sub rad7P_CheckedChanged(sender As Object,
                                   e As EventArgs) Handles rad7P.CheckedChanged
        '======================================================================
        '               -Description/Written: By Alex Easter-
        'When rad is checked, set btnConfirm visible
        'Also set sngPlayerCount value to corresponding value
        '======================================================================
        btnConfirm.Visible = True
        shtPlayerCount = 7
    End Sub
End Class


'======================================================================
'               -Description/Written: By Alex Easter-
'
'======================================================================