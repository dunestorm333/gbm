﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.gMonTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.gMonTrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.gMonTrayNotification = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTrayShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTraySep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.gMonTrayMon = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTraySettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTraySetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTraySetupAddWizard = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTraySetupGameManager = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTraySetupTags = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTraySetupProcessManager = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTraySetupCustomVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTrayTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTrayToolsCompact = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTrayToolsLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTrayLogClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTrayLogSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTrayToolsSessions = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTrayToolsSyncGameID = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTrayToolsSyncGameIDOfficial = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTrayToolsSyncGameIDFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTraySep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.gMonTrayExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.bwMonitor = New System.ComponentModel.BackgroundWorker()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.gMonStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.gMonStripAdminButton = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gMonStripTxtStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gMonStripStatusButton = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gMonMainMenu = New System.Windows.Forms.MenuStrip()
        Me.gMonFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonFileMonitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonMonitorSep = New System.Windows.Forms.ToolStripSeparator()
        Me.gMonFileSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonExitSep = New System.Windows.Forms.ToolStripSeparator()
        Me.gMonFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonSetupGameManager = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonSetupAddWizard = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonSetupTags = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonSetupProcessManager = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonSetupCustomVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonToolsCompact = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonToolsLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonLogClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonLogSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonToolsSessions = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonToolsSyncGameID = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonToolsSyncGameIDOfficial = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonToolsSyncGameIDFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonHelpWebSite = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonHelpManual = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonHelpCheckforUpdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.gMonNotification = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.lblGameTitle = New System.Windows.Forms.Label()
        Me.lblLastAction = New System.Windows.Forms.Label()
        Me.lblLastActionTitle = New System.Windows.Forms.Label()
        Me.lblTimeSpent = New System.Windows.Forms.Label()
        Me.btnCancelOperation = New System.Windows.Forms.Button()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.lblStatus2 = New System.Windows.Forms.Label()
        Me.lblStatus3 = New System.Windows.Forms.Label()
        Me.pbTime = New System.Windows.Forms.PictureBox()
        Me.gMonTrayMenu.SuspendLayout()
        Me.gMonStatusStrip.SuspendLayout()
        Me.gMonMainMenu.SuspendLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gMonTray
        '
        Me.gMonTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.gMonTray.BalloonTipTitle = "GBM"
        Me.gMonTray.ContextMenuStrip = Me.gMonTrayMenu
        Me.gMonTray.Icon = CType(resources.GetObject("gMonTray.Icon"), System.Drawing.Icon)
        Me.gMonTray.Text = "GBM"
        Me.gMonTray.Visible = True
        '
        'gMonTrayMenu
        '
        Me.gMonTrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gMonTrayNotification, Me.gMonTrayShow, Me.gMonTraySep2, Me.gMonTrayMon, Me.gMonTraySettings, Me.gMonTraySetup, Me.gMonTrayTools, Me.gMonTraySep1, Me.gMonTrayExit})
        Me.gMonTrayMenu.Name = "gMonTrayMenu"
        Me.gMonTrayMenu.Size = New System.Drawing.Size(162, 170)
        '
        'gMonTrayNotification
        '
        Me.gMonTrayNotification.Name = "gMonTrayNotification"
        Me.gMonTrayNotification.Size = New System.Drawing.Size(161, 22)
        Me.gMonTrayNotification.Text = "Notification"
        Me.gMonTrayNotification.Visible = False
        '
        'gMonTrayShow
        '
        Me.gMonTrayShow.Name = "gMonTrayShow"
        Me.gMonTrayShow.Size = New System.Drawing.Size(161, 22)
        Me.gMonTrayShow.Text = "S&how / Hide"
        '
        'gMonTraySep2
        '
        Me.gMonTraySep2.Name = "gMonTraySep2"
        Me.gMonTraySep2.Size = New System.Drawing.Size(158, 6)
        '
        'gMonTrayMon
        '
        Me.gMonTrayMon.Name = "gMonTrayMon"
        Me.gMonTrayMon.Size = New System.Drawing.Size(161, 22)
        Me.gMonTrayMon.Text = "S&tart Monitoring"
        '
        'gMonTraySettings
        '
        Me.gMonTraySettings.Name = "gMonTraySettings"
        Me.gMonTraySettings.Size = New System.Drawing.Size(161, 22)
        Me.gMonTraySettings.Text = "S&ettings"
        '
        'gMonTraySetup
        '
        Me.gMonTraySetup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gMonTraySetupAddWizard, Me.gMonTraySetupGameManager, Me.gMonTraySetupTags, Me.gMonTraySetupProcessManager, Me.gMonTraySetupCustomVariables})
        Me.gMonTraySetup.Name = "gMonTraySetup"
        Me.gMonTraySetup.Size = New System.Drawing.Size(161, 22)
        Me.gMonTraySetup.Text = "&Setup"
        '
        'gMonTraySetupAddWizard
        '
        Me.gMonTraySetupAddWizard.Name = "gMonTraySetupAddWizard"
        Me.gMonTraySetupAddWizard.Size = New System.Drawing.Size(201, 22)
        Me.gMonTraySetupAddWizard.Text = "Add Game &Wizard..."
        '
        'gMonTraySetupGameManager
        '
        Me.gMonTraySetupGameManager.Name = "gMonTraySetupGameManager"
        Me.gMonTraySetupGameManager.Size = New System.Drawing.Size(201, 22)
        Me.gMonTraySetupGameManager.Text = "&Game Manager..."
        '
        'gMonTraySetupTags
        '
        Me.gMonTraySetupTags.Name = "gMonTraySetupTags"
        Me.gMonTraySetupTags.Size = New System.Drawing.Size(201, 22)
        Me.gMonTraySetupTags.Text = "&Tag Manager..."
        '
        'gMonTraySetupProcessManager
        '
        Me.gMonTraySetupProcessManager.Name = "gMonTraySetupProcessManager"
        Me.gMonTraySetupProcessManager.Size = New System.Drawing.Size(201, 22)
        Me.gMonTraySetupProcessManager.Text = "&Process Manager..."
        '
        'gMonTraySetupCustomVariables
        '
        Me.gMonTraySetupCustomVariables.Name = "gMonTraySetupCustomVariables"
        Me.gMonTraySetupCustomVariables.Size = New System.Drawing.Size(201, 22)
        Me.gMonTraySetupCustomVariables.Text = "Custom Path &Variables..."
        '
        'gMonTrayTools
        '
        Me.gMonTrayTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gMonTrayToolsCompact, Me.gMonTrayToolsLog, Me.gMonTrayToolsSessions, Me.gMonTrayToolsSyncGameID})
        Me.gMonTrayTools.Name = "gMonTrayTools"
        Me.gMonTrayTools.Size = New System.Drawing.Size(161, 22)
        Me.gMonTrayTools.Text = "&Tools"
        '
        'gMonTrayToolsCompact
        '
        Me.gMonTrayToolsCompact.Name = "gMonTrayToolsCompact"
        Me.gMonTrayToolsCompact.Size = New System.Drawing.Size(179, 22)
        Me.gMonTrayToolsCompact.Text = "&Compact Databases"
        '
        'gMonTrayToolsLog
        '
        Me.gMonTrayToolsLog.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gMonTrayLogClear, Me.gMonTrayLogSave})
        Me.gMonTrayToolsLog.Name = "gMonTrayToolsLog"
        Me.gMonTrayToolsLog.Size = New System.Drawing.Size(179, 22)
        Me.gMonTrayToolsLog.Text = "&Log"
        '
        'gMonTrayLogClear
        '
        Me.gMonTrayLogClear.Name = "gMonTrayLogClear"
        Me.gMonTrayLogClear.Size = New System.Drawing.Size(101, 22)
        Me.gMonTrayLogClear.Text = "&Clear"
        '
        'gMonTrayLogSave
        '
        Me.gMonTrayLogSave.Name = "gMonTrayLogSave"
        Me.gMonTrayLogSave.Size = New System.Drawing.Size(101, 22)
        Me.gMonTrayLogSave.Text = "&Save"
        '
        'gMonTrayToolsSessions
        '
        Me.gMonTrayToolsSessions.Name = "gMonTrayToolsSessions"
        Me.gMonTrayToolsSessions.Size = New System.Drawing.Size(179, 22)
        Me.gMonTrayToolsSessions.Text = "&Session Viewer..."
        '
        'gMonTrayToolsSyncGameID
        '
        Me.gMonTrayToolsSyncGameID.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gMonTrayToolsSyncGameIDOfficial, Me.gMonTrayToolsSyncGameIDFile})
        Me.gMonTrayToolsSyncGameID.Name = "gMonTrayToolsSyncGameID"
        Me.gMonTrayToolsSyncGameID.Size = New System.Drawing.Size(179, 22)
        Me.gMonTrayToolsSyncGameID.Text = "S&ync Game IDs"
        '
        'gMonTrayToolsSyncGameIDOfficial
        '
        Me.gMonTrayToolsSyncGameIDOfficial.Name = "gMonTrayToolsSyncGameIDOfficial"
        Me.gMonTrayToolsSyncGameIDOfficial.Size = New System.Drawing.Size(142, 22)
        Me.gMonTrayToolsSyncGameIDOfficial.Text = "&Official List..."
        '
        'gMonTrayToolsSyncGameIDFile
        '
        Me.gMonTrayToolsSyncGameIDFile.Name = "gMonTrayToolsSyncGameIDFile"
        Me.gMonTrayToolsSyncGameIDFile.Size = New System.Drawing.Size(142, 22)
        Me.gMonTrayToolsSyncGameIDFile.Text = "&File..."
        '
        'gMonTraySep1
        '
        Me.gMonTraySep1.Name = "gMonTraySep1"
        Me.gMonTraySep1.Size = New System.Drawing.Size(158, 6)
        '
        'gMonTrayExit
        '
        Me.gMonTrayExit.Name = "gMonTrayExit"
        Me.gMonTrayExit.Size = New System.Drawing.Size(161, 22)
        Me.gMonTrayExit.Text = "E&xit"
        '
        'bwMonitor
        '
        Me.bwMonitor.WorkerSupportsCancellation = True
        '
        'txtLog
        '
        Me.txtLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.Location = New System.Drawing.Point(-1, 184)
        Me.txtLog.MaxLength = 524288
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(525, 195)
        Me.txtLog.TabIndex = 10
        Me.txtLog.TabStop = False
        '
        'gMonStatusStrip
        '
        Me.gMonStatusStrip.BackColor = System.Drawing.Color.Transparent
        Me.gMonStatusStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gMonStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gMonStripAdminButton, Me.gMonStripTxtStatus, Me.gMonStripStatusButton})
        Me.gMonStatusStrip.Location = New System.Drawing.Point(0, 379)
        Me.gMonStatusStrip.Name = "gMonStatusStrip"
        Me.gMonStatusStrip.ShowItemToolTips = True
        Me.gMonStatusStrip.Size = New System.Drawing.Size(524, 22)
        Me.gMonStatusStrip.SizingGrip = False
        Me.gMonStatusStrip.TabIndex = 3
        '
        'gMonStripAdminButton
        '
        Me.gMonStripAdminButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.gMonStripAdminButton.Image = Global.GBM.My.Resources.Resources.Icon_User
        Me.gMonStripAdminButton.Name = "gMonStripAdminButton"
        Me.gMonStripAdminButton.Size = New System.Drawing.Size(16, 17)
        Me.gMonStripAdminButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'gMonStripTxtStatus
        '
        Me.gMonStripTxtStatus.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.gMonStripTxtStatus.Name = "gMonStripTxtStatus"
        Me.gMonStripTxtStatus.Size = New System.Drawing.Size(400, 22)
        Me.gMonStripTxtStatus.Spring = True
        Me.gMonStripTxtStatus.Text = "Monitor Status"
        Me.gMonStripTxtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gMonStripStatusButton
        '
        Me.gMonStripStatusButton.Name = "gMonStripStatusButton"
        Me.gMonStripStatusButton.Size = New System.Drawing.Size(88, 17)
        Me.gMonStripStatusButton.Text = "Monitor Status:"
        Me.gMonStripStatusButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'gMonMainMenu
        '
        Me.gMonMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gMonFile, Me.gMonSetup, Me.gMonTools, Me.gMonHelp, Me.gMonNotification})
        Me.gMonMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.gMonMainMenu.Name = "gMonMainMenu"
        Me.gMonMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.gMonMainMenu.Size = New System.Drawing.Size(524, 24)
        Me.gMonMainMenu.TabIndex = 0
        Me.gMonMainMenu.Text = "MenuStrip1"
        '
        'gMonFile
        '
        Me.gMonFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gMonFileMonitor, Me.gMonMonitorSep, Me.gMonFileSettings, Me.gMonExitSep, Me.gMonFileExit})
        Me.gMonFile.Name = "gMonFile"
        Me.gMonFile.Size = New System.Drawing.Size(37, 20)
        Me.gMonFile.Text = "&File"
        '
        'gMonFileMonitor
        '
        Me.gMonFileMonitor.Name = "gMonFileMonitor"
        Me.gMonFileMonitor.Size = New System.Drawing.Size(161, 22)
        Me.gMonFileMonitor.Text = "Start &Monitoring"
        '
        'gMonMonitorSep
        '
        Me.gMonMonitorSep.Name = "gMonMonitorSep"
        Me.gMonMonitorSep.Size = New System.Drawing.Size(158, 6)
        '
        'gMonFileSettings
        '
        Me.gMonFileSettings.Name = "gMonFileSettings"
        Me.gMonFileSettings.Size = New System.Drawing.Size(161, 22)
        Me.gMonFileSettings.Text = "&Settings..."
        '
        'gMonExitSep
        '
        Me.gMonExitSep.Name = "gMonExitSep"
        Me.gMonExitSep.Size = New System.Drawing.Size(158, 6)
        '
        'gMonFileExit
        '
        Me.gMonFileExit.Name = "gMonFileExit"
        Me.gMonFileExit.Size = New System.Drawing.Size(161, 22)
        Me.gMonFileExit.Text = "E&xit"
        '
        'gMonSetup
        '
        Me.gMonSetup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gMonSetupGameManager, Me.gMonSetupAddWizard, Me.gMonSetupTags, Me.gMonSetupProcessManager, Me.gMonSetupCustomVariables})
        Me.gMonSetup.Name = "gMonSetup"
        Me.gMonSetup.Size = New System.Drawing.Size(49, 20)
        Me.gMonSetup.Text = "&Setup"
        '
        'gMonSetupGameManager
        '
        Me.gMonSetupGameManager.Name = "gMonSetupGameManager"
        Me.gMonSetupGameManager.Size = New System.Drawing.Size(201, 22)
        Me.gMonSetupGameManager.Text = "&Game Manager..."
        '
        'gMonSetupAddWizard
        '
        Me.gMonSetupAddWizard.Name = "gMonSetupAddWizard"
        Me.gMonSetupAddWizard.Size = New System.Drawing.Size(201, 22)
        Me.gMonSetupAddWizard.Text = "Add Game &Wizard..."
        '
        'gMonSetupTags
        '
        Me.gMonSetupTags.Name = "gMonSetupTags"
        Me.gMonSetupTags.Size = New System.Drawing.Size(201, 22)
        Me.gMonSetupTags.Text = "&Tag Manager..."
        '
        'gMonSetupProcessManager
        '
        Me.gMonSetupProcessManager.Name = "gMonSetupProcessManager"
        Me.gMonSetupProcessManager.Size = New System.Drawing.Size(201, 22)
        Me.gMonSetupProcessManager.Text = "&Process Manager..."
        '
        'gMonSetupCustomVariables
        '
        Me.gMonSetupCustomVariables.Name = "gMonSetupCustomVariables"
        Me.gMonSetupCustomVariables.Size = New System.Drawing.Size(201, 22)
        Me.gMonSetupCustomVariables.Text = "Custom Path &Variables..."
        '
        'gMonTools
        '
        Me.gMonTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gMonToolsCompact, Me.gMonToolsLog, Me.gMonToolsSessions, Me.gMonToolsSyncGameID})
        Me.gMonTools.Name = "gMonTools"
        Me.gMonTools.Size = New System.Drawing.Size(47, 20)
        Me.gMonTools.Text = "&Tools"
        '
        'gMonToolsCompact
        '
        Me.gMonToolsCompact.Name = "gMonToolsCompact"
        Me.gMonToolsCompact.Size = New System.Drawing.Size(179, 22)
        Me.gMonToolsCompact.Text = "&Compact Databases"
        '
        'gMonToolsLog
        '
        Me.gMonToolsLog.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gMonLogClear, Me.gMonLogSave})
        Me.gMonToolsLog.Name = "gMonToolsLog"
        Me.gMonToolsLog.Size = New System.Drawing.Size(179, 22)
        Me.gMonToolsLog.Text = "&Log"
        '
        'gMonLogClear
        '
        Me.gMonLogClear.Name = "gMonLogClear"
        Me.gMonLogClear.Size = New System.Drawing.Size(101, 22)
        Me.gMonLogClear.Text = "&Clear"
        '
        'gMonLogSave
        '
        Me.gMonLogSave.Name = "gMonLogSave"
        Me.gMonLogSave.Size = New System.Drawing.Size(101, 22)
        Me.gMonLogSave.Text = "&Save"
        '
        'gMonToolsSessions
        '
        Me.gMonToolsSessions.Name = "gMonToolsSessions"
        Me.gMonToolsSessions.Size = New System.Drawing.Size(179, 22)
        Me.gMonToolsSessions.Text = "&Session Viewer..."
        '
        'gMonToolsSyncGameID
        '
        Me.gMonToolsSyncGameID.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gMonToolsSyncGameIDOfficial, Me.gMonToolsSyncGameIDFile})
        Me.gMonToolsSyncGameID.Name = "gMonToolsSyncGameID"
        Me.gMonToolsSyncGameID.Size = New System.Drawing.Size(179, 22)
        Me.gMonToolsSyncGameID.Text = "S&ync Game IDs"
        '
        'gMonToolsSyncGameIDOfficial
        '
        Me.gMonToolsSyncGameIDOfficial.Name = "gMonToolsSyncGameIDOfficial"
        Me.gMonToolsSyncGameIDOfficial.Size = New System.Drawing.Size(142, 22)
        Me.gMonToolsSyncGameIDOfficial.Text = "&Official List..."
        '
        'gMonToolsSyncGameIDFile
        '
        Me.gMonToolsSyncGameIDFile.Name = "gMonToolsSyncGameIDFile"
        Me.gMonToolsSyncGameIDFile.Size = New System.Drawing.Size(142, 22)
        Me.gMonToolsSyncGameIDFile.Text = "&File..."
        '
        'gMonHelp
        '
        Me.gMonHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gMonHelpWebSite, Me.gMonHelpManual, Me.gMonHelpCheckforUpdates, Me.gMonHelpAbout})
        Me.gMonHelp.Name = "gMonHelp"
        Me.gMonHelp.Size = New System.Drawing.Size(44, 20)
        Me.gMonHelp.Text = "&Help"
        '
        'gMonHelpWebSite
        '
        Me.gMonHelpWebSite.Name = "gMonHelpWebSite"
        Me.gMonHelpWebSite.Size = New System.Drawing.Size(180, 22)
        Me.gMonHelpWebSite.Text = "&Official Web Site..."
        '
        'gMonHelpManual
        '
        Me.gMonHelpManual.Name = "gMonHelpManual"
        Me.gMonHelpManual.Size = New System.Drawing.Size(180, 22)
        Me.gMonHelpManual.Text = "Online &Manual..."
        '
        'gMonHelpCheckforUpdates
        '
        Me.gMonHelpCheckforUpdates.Name = "gMonHelpCheckforUpdates"
        Me.gMonHelpCheckforUpdates.Size = New System.Drawing.Size(180, 22)
        Me.gMonHelpCheckforUpdates.Text = "&Check for Updates..."
        '
        'gMonHelpAbout
        '
        Me.gMonHelpAbout.Name = "gMonHelpAbout"
        Me.gMonHelpAbout.Size = New System.Drawing.Size(180, 22)
        Me.gMonHelpAbout.Text = "&About"
        '
        'gMonNotification
        '
        Me.gMonNotification.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.gMonNotification.Name = "gMonNotification"
        Me.gMonNotification.Size = New System.Drawing.Size(82, 20)
        Me.gMonNotification.Text = "Notification"
        Me.gMonNotification.Visible = False
        '
        'pbIcon
        '
        Me.pbIcon.Location = New System.Drawing.Point(12, 36)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(48, 48)
        Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbIcon.TabIndex = 9
        Me.pbIcon.TabStop = False
        '
        'lblGameTitle
        '
        Me.lblGameTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGameTitle.AutoEllipsis = True
        Me.lblGameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTitle.Location = New System.Drawing.Point(66, 36)
        Me.lblGameTitle.Name = "lblGameTitle"
        Me.lblGameTitle.Size = New System.Drawing.Size(446, 16)
        Me.lblGameTitle.TabIndex = 1
        Me.lblGameTitle.Text = "Game Title"
        '
        'lblLastAction
        '
        Me.lblLastAction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastAction.AutoEllipsis = True
        Me.lblLastAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastAction.Location = New System.Drawing.Point(12, 165)
        Me.lblLastAction.Name = "lblLastAction"
        Me.lblLastAction.Size = New System.Drawing.Size(419, 13)
        Me.lblLastAction.TabIndex = 9
        Me.lblLastAction.Text = "Last Action"
        '
        'lblLastActionTitle
        '
        Me.lblLastActionTitle.AutoSize = True
        Me.lblLastActionTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastActionTitle.Location = New System.Drawing.Point(12, 147)
        Me.lblLastActionTitle.Name = "lblLastActionTitle"
        Me.lblLastActionTitle.Size = New System.Drawing.Size(75, 13)
        Me.lblLastActionTitle.TabIndex = 8
        Me.lblLastActionTitle.Text = "Last Action:"
        '
        'lblTimeSpent
        '
        Me.lblTimeSpent.AutoEllipsis = True
        Me.lblTimeSpent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeSpent.Location = New System.Drawing.Point(66, 110)
        Me.lblTimeSpent.Name = "lblTimeSpent"
        Me.lblTimeSpent.Size = New System.Drawing.Size(446, 16)
        Me.lblTimeSpent.TabIndex = 5
        Me.lblTimeSpent.Text = "0 Hours"
        '
        'btnCancelOperation
        '
        Me.btnCancelOperation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelOperation.Location = New System.Drawing.Point(437, 155)
        Me.btnCancelOperation.Name = "btnCancelOperation"
        Me.btnCancelOperation.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelOperation.TabIndex = 6
        Me.btnCancelOperation.Text = "&Cancel"
        Me.btnCancelOperation.UseVisualStyleBackColor = True
        '
        'lblStatus1
        '
        Me.lblStatus1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus1.AutoEllipsis = True
        Me.lblStatus1.Location = New System.Drawing.Point(66, 58)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(446, 13)
        Me.lblStatus1.TabIndex = 2
        '
        'lblStatus2
        '
        Me.lblStatus2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus2.AutoEllipsis = True
        Me.lblStatus2.Location = New System.Drawing.Point(66, 74)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.Size = New System.Drawing.Size(446, 13)
        Me.lblStatus2.TabIndex = 3
        '
        'lblStatus3
        '
        Me.lblStatus3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus3.AutoEllipsis = True
        Me.lblStatus3.Location = New System.Drawing.Point(66, 90)
        Me.lblStatus3.Name = "lblStatus3"
        Me.lblStatus3.Size = New System.Drawing.Size(446, 13)
        Me.lblStatus3.TabIndex = 4
        '
        'pbTime
        '
        Me.pbTime.Location = New System.Drawing.Point(36, 106)
        Me.pbTime.Name = "pbTime"
        Me.pbTime.Size = New System.Drawing.Size(24, 24)
        Me.pbTime.TabIndex = 18
        Me.pbTime.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 401)
        Me.Controls.Add(Me.pbTime)
        Me.Controls.Add(Me.lblStatus3)
        Me.Controls.Add(Me.lblStatus2)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.btnCancelOperation)
        Me.Controls.Add(Me.lblTimeSpent)
        Me.Controls.Add(Me.lblLastActionTitle)
        Me.Controls.Add(Me.lblLastAction)
        Me.Controls.Add(Me.lblGameTitle)
        Me.Controls.Add(Me.pbIcon)
        Me.Controls.Add(Me.gMonStatusStrip)
        Me.Controls.Add(Me.gMonMainMenu)
        Me.Controls.Add(Me.txtLog)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.gMonMainMenu
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Backup Monitor"
        Me.gMonTrayMenu.ResumeLayout(False)
        Me.gMonStatusStrip.ResumeLayout(False)
        Me.gMonStatusStrip.PerformLayout()
        Me.gMonMainMenu.ResumeLayout(False)
        Me.gMonMainMenu.PerformLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gMonTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents gMonTrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents gMonTrayExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonTrayShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonTraySep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bwMonitor As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents gMonTrayMon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents gMonStripTxtStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents gMonTraySettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonTraySep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gMonTraySetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonMainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents gMonFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonFileMonitor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonMonitorSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gMonFileSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonExitSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gMonFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonTraySetupGameManager As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonTraySetupCustomVariables As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblGameTitle As System.Windows.Forms.Label
    Friend WithEvents lblLastAction As System.Windows.Forms.Label
    Friend WithEvents lblLastActionTitle As System.Windows.Forms.Label
    Friend WithEvents gMonTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonTrayTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonSetupAddWizard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonTraySetupAddWizard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTimeSpent As System.Windows.Forms.Label
    Friend WithEvents gMonSetupGameManager As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonSetupCustomVariables As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonToolsCompact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonTrayToolsCompact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonHelpManual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonHelpCheckforUpdates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCancelOperation As System.Windows.Forms.Button
    Friend WithEvents gMonTraySetupTags As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonSetupTags As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents lblStatus2 As Label
    Friend WithEvents lblStatus3 As Label
    Friend WithEvents gMonNotification As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonTrayNotification As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gMonHelpWebSite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbTime As System.Windows.Forms.PictureBox
    Friend WithEvents gMonToolsLog As ToolStripMenuItem
    Friend WithEvents gMonLogClear As ToolStripMenuItem
    Friend WithEvents gMonLogSave As ToolStripMenuItem
    Friend WithEvents gMonTrayToolsLog As ToolStripMenuItem
    Friend WithEvents gMonTrayLogClear As ToolStripMenuItem
    Friend WithEvents gMonTrayLogSave As ToolStripMenuItem
    Friend WithEvents gMonStripAdminButton As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents gMonStripStatusButton As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents gMonToolsSessions As ToolStripMenuItem
    Friend WithEvents gMonTrayToolsSessions As ToolStripMenuItem
    Friend WithEvents gMonToolsSyncGameID As ToolStripMenuItem
    Friend WithEvents gMonToolsSyncGameIDOfficial As ToolStripMenuItem
    Friend WithEvents gMonToolsSyncGameIDFile As ToolStripMenuItem
    Friend WithEvents gMonTrayToolsSyncGameID As ToolStripMenuItem
    Friend WithEvents gMonTrayToolsSyncGameIDOfficial As ToolStripMenuItem
    Friend WithEvents gMonTrayToolsSyncGameIDFile As ToolStripMenuItem
    Friend WithEvents gMonTraySetupProcessManager As ToolStripMenuItem
    Friend WithEvents gMonSetupProcessManager As ToolStripMenuItem
End Class
