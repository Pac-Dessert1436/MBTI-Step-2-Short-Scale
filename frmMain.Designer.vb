<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlResults = New System.Windows.Forms.Panel()
        Me.lblResultsTitle = New System.Windows.Forms.Label()
        Me.lblResultsSubtitle = New System.Windows.Forms.Label()
        Me.grpChart = New System.Windows.Forms.GroupBox()
        Me.lblChartTitle = New System.Windows.Forms.Label()
        Me.pnlChart = New System.Windows.Forms.Panel()
        Me.grpFunctionStack = New System.Windows.Forms.GroupBox()
        Me.lblFunctionStackTitle = New System.Windows.Forms.Label()
        Me.pnlFunctionStack = New System.Windows.Forms.Panel()
        Me.grpInterpretation = New System.Windows.Forms.GroupBox()
        Me.lblInterpretationTitle = New System.Windows.Forms.Label()
        Me.txtInterpretation = New System.Windows.Forms.TextBox()
        Me.lblDisclaimer = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.pnlQuestions = New System.Windows.Forms.Panel()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.lblQuestionText = New System.Windows.Forms.Label()
        Me.pnlOptions = New System.Windows.Forms.Panel()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pnlProgress = New System.Windows.Forms.Panel()
        Me.lblProgressText = New System.Windows.Forms.Label()
        Me.lblProgressPercent = New System.Windows.Forms.Label()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.pnlIntro = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblNotice = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pnlMain.SuspendLayout()
        Me.pnlResults.SuspendLayout()
        Me.grpChart.SuspendLayout()
        Me.grpFunctionStack.SuspendLayout()
        Me.grpInterpretation.SuspendLayout()
        Me.pnlQuestions.SuspendLayout()
        Me.pnlProgress.SuspendLayout()
        Me.pnlIntro.SuspendLayout()
        Me.SuspendLayout()
        
        Me.pnlMain.Controls.Add(Me.pnlResults)
        Me.pnlMain.Controls.Add(Me.pnlQuestions)
        Me.pnlMain.Controls.Add(Me.pnlProgress)
        Me.pnlMain.Controls.Add(Me.pnlIntro)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(800, 600)
        Me.pnlMain.TabIndex = 0
        
        Me.pnlResults.Controls.Add(Me.lblResultsTitle)
        Me.pnlResults.Controls.Add(Me.lblResultsSubtitle)
        Me.pnlResults.Controls.Add(Me.grpChart)
        Me.pnlResults.Controls.Add(Me.grpFunctionStack)
        Me.pnlResults.Controls.Add(Me.grpInterpretation)
        Me.pnlResults.Controls.Add(Me.lblDisclaimer)
        Me.pnlResults.Controls.Add(Me.btnRestart)
        Me.pnlResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlResults.Location = New System.Drawing.Point(0, 0)
        Me.pnlResults.Name = "pnlResults"
        Me.pnlResults.Size = New System.Drawing.Size(800, 600)
        Me.pnlResults.TabIndex = 3
        Me.pnlResults.Visible = False
        
        Me.lblResultsTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResultsTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultsTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblResultsTitle.Name = "lblResultsTitle"
        Me.lblResultsTitle.Size = New System.Drawing.Size(770, 35)
        Me.lblResultsTitle.TabIndex = 0
        Me.lblResultsTitle.Text = "Your Cognitive Function Profile"
        Me.lblResultsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        
        Me.lblResultsSubtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResultsSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultsSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblResultsSubtitle.Location = New System.Drawing.Point(15, 50)
        Me.lblResultsSubtitle.Name = "lblResultsSubtitle"
        Me.lblResultsSubtitle.Size = New System.Drawing.Size(770, 20)
        Me.lblResultsSubtitle.TabIndex = 1
        Me.lblResultsSubtitle.Text = "Based on Jungian Eight-Dimensional Theory Function Strength Distribution"
        Me.lblResultsSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        
        Me.grpChart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpChart.Controls.Add(Me.lblChartTitle)
        Me.grpChart.Controls.Add(Me.pnlChart)
        Me.grpChart.Location = New System.Drawing.Point(15, 75)
        Me.grpChart.Name = "grpChart"
        Me.grpChart.Size = New System.Drawing.Size(770, 200)
        Me.grpChart.TabIndex = 2
        Me.grpChart.TabStop = False
        Me.grpChart.Text = "Cognitive Function Strength Chart"
        
        Me.lblChartTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChartTitle.Location = New System.Drawing.Point(10, 15)
        Me.lblChartTitle.Name = "lblChartTitle"
        Me.lblChartTitle.Size = New System.Drawing.Size(750, 18)
        Me.lblChartTitle.TabIndex = 0
        Me.lblChartTitle.Text = "Eight-Dimensional Cognitive Function Strength (Maximum 20 points)"
        Me.lblChartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        
        Me.pnlChart.AutoScroll = True
        Me.pnlChart.Location = New System.Drawing.Point(10, 38)
        Me.pnlChart.Name = "pnlChart"
        Me.pnlChart.Size = New System.Drawing.Size(750, 150)
        Me.pnlChart.TabIndex = 1
        
        Me.grpFunctionStack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFunctionStack.Controls.Add(Me.lblFunctionStackTitle)
        Me.grpFunctionStack.Controls.Add(Me.pnlFunctionStack)
        Me.grpFunctionStack.Location = New System.Drawing.Point(15, 280)
        Me.grpFunctionStack.Name = "grpFunctionStack"
        Me.grpFunctionStack.Size = New System.Drawing.Size(770, 140)
        Me.grpFunctionStack.TabIndex = 3
        Me.grpFunctionStack.TabStop = False
        Me.grpFunctionStack.Text = "Your Cognitive Function Stack Analysis"
        
        Me.lblFunctionStackTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunctionStackTitle.Location = New System.Drawing.Point(10, 15)
        Me.lblFunctionStackTitle.Name = "lblFunctionStackTitle"
        Me.lblFunctionStackTitle.Size = New System.Drawing.Size(750, 18)
        Me.lblFunctionStackTitle.TabIndex = 0
        Me.lblFunctionStackTitle.Text = "According to Jungian theory, personality consists of four main cognitive functions: Dominant, Auxiliary, Tertiary, and Inferior."
        
        Me.pnlFunctionStack.AutoScroll = True
        Me.pnlFunctionStack.Location = New System.Drawing.Point(10, 38)
        Me.pnlFunctionStack.Name = "pnlFunctionStack"
        Me.pnlFunctionStack.Size = New System.Drawing.Size(750, 90)
        Me.pnlFunctionStack.TabIndex = 1
        
        Me.grpInterpretation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInterpretation.Controls.Add(Me.lblInterpretationTitle)
        Me.grpInterpretation.Controls.Add(Me.txtInterpretation)
        Me.grpInterpretation.Location = New System.Drawing.Point(15, 425)
        Me.grpInterpretation.Name = "grpInterpretation"
        Me.grpInterpretation.Size = New System.Drawing.Size(770, 100)
        Me.grpInterpretation.TabIndex = 4
        Me.grpInterpretation.TabStop = False
        Me.grpInterpretation.Text = "Detailed Dimension Interpretation"
        
        Me.lblInterpretationTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterpretationTitle.Location = New System.Drawing.Point(10, 15)
        Me.lblInterpretationTitle.Name = "lblInterpretationTitle"
        Me.lblInterpretationTitle.Size = New System.Drawing.Size(750, 18)
        Me.lblInterpretationTitle.TabIndex = 0
        Me.lblInterpretationTitle.Text = "Core Cognitive Pattern Analysis"
        
        Me.txtInterpretation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInterpretation.BackColor = System.Drawing.Color.White
        Me.txtInterpretation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInterpretation.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterpretation.Location = New System.Drawing.Point(10, 38)
        Me.txtInterpretation.Multiline = True
        Me.txtInterpretation.Name = "txtInterpretation"
        Me.txtInterpretation.ReadOnly = True
        Me.txtInterpretation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInterpretation.Size = New System.Drawing.Size(750, 50)
        Me.txtInterpretation.TabIndex = 1
        Me.txtInterpretation.Text = ""
        
        Me.lblDisclaimer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisclaimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblDisclaimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisclaimer.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisclaimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblDisclaimer.Location = New System.Drawing.Point(15, 530)
        Me.lblDisclaimer.Name = "lblDisclaimer"
        Me.lblDisclaimer.Size = New System.Drawing.Size(770, 20)
        Me.lblDisclaimer.TabIndex = 5
        Me.lblDisclaimer.Text = "Disclaimer: This assessment result is for reference only and does not represent professional psychological diagnosis."
        Me.lblDisclaimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        
        Me.btnRestart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestart.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestart.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.ForeColor = System.Drawing.Color.White
        Me.btnRestart.Location = New System.Drawing.Point(600, 555)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(185, 35)
        Me.btnRestart.TabIndex = 6
        Me.btnRestart.Text = "Restart Assessment"
        Me.btnRestart.UseVisualStyleBackColor = False
        
        Me.pnlQuestions.Controls.Add(Me.lblQuestionNumber)
        Me.pnlQuestions.Controls.Add(Me.lblQuestionText)
        Me.pnlQuestions.Controls.Add(Me.pnlOptions)
        Me.pnlQuestions.Controls.Add(Me.btnPrevious)
        Me.pnlQuestions.Controls.Add(Me.btnNext)
        Me.pnlQuestions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlQuestions.Location = New System.Drawing.Point(0, 70)
        Me.pnlQuestions.Name = "pnlQuestions"
        Me.pnlQuestions.Size = New System.Drawing.Size(800, 530)
        Me.pnlQuestions.TabIndex = 2
        Me.pnlQuestions.Visible = False
        
        Me.lblQuestionNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuestionNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblQuestionNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNumber.Location = New System.Drawing.Point(15, 70)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(770, 25)
        Me.lblQuestionNumber.TabIndex = 0
        Me.lblQuestionNumber.Text = "Question 1/40"
        Me.lblQuestionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        
        Me.lblQuestionText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuestionText.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionText.Location = New System.Drawing.Point(15, 100)
        Me.lblQuestionText.Name = "lblQuestionText"
        Me.lblQuestionText.Size = New System.Drawing.Size(770, 50)
        Me.lblQuestionText.TabIndex = 1
        Me.lblQuestionText.Text = "Question text will appear here"
        
        Me.pnlOptions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOptions.AutoScroll = True
        Me.pnlOptions.Location = New System.Drawing.Point(15, 200)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(770, 400)
        Me.pnlOptions.TabIndex = 2
        
        Me.btnPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnPrevious.Location = New System.Drawing.Point(15, 460)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(150, 45)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnNext.Enabled = False
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(635, 460)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(150, 45)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        
        Me.pnlProgress.Controls.Add(Me.lblProgressText)
        Me.pnlProgress.Controls.Add(Me.lblProgressPercent)
        Me.pnlProgress.Controls.Add(Me.progressBar)
        Me.pnlProgress.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlProgress.Location = New System.Drawing.Point(0, 0)
        Me.pnlProgress.Name = "pnlProgress"
        Me.pnlProgress.Size = New System.Drawing.Size(800, 70)
        Me.pnlProgress.TabIndex = 1
        Me.pnlProgress.Visible = False
        
        Me.lblProgressText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgressText.Location = New System.Drawing.Point(15, 12)
        Me.lblProgressText.Name = "lblProgressText"
        Me.lblProgressText.Size = New System.Drawing.Size(180, 20)
        Me.lblProgressText.TabIndex = 0
        Me.lblProgressText.Text = "Assessment Progress"
        
        Me.lblProgressPercent.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgressPercent.Location = New System.Drawing.Point(605, 12)
        Me.lblProgressPercent.Name = "lblProgressPercent"
        Me.lblProgressPercent.Size = New System.Drawing.Size(180, 20)
        Me.lblProgressPercent.TabIndex = 1
        Me.lblProgressPercent.Text = "0%"
        Me.lblProgressPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        
        Me.progressBar.Location = New System.Drawing.Point(15, 38)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(770, 20)
        Me.progressBar.TabIndex = 2
        
        Me.pnlIntro.Controls.Add(Me.lblTitle)
        Me.pnlIntro.Controls.Add(Me.lblSubtitle)
        Me.pnlIntro.Controls.Add(Me.lblDescription)
        Me.pnlIntro.Controls.Add(Me.lblNotice)
        Me.pnlIntro.Controls.Add(Me.btnStart)
        Me.pnlIntro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlIntro.Location = New System.Drawing.Point(0, 0)
        Me.pnlIntro.Name = "pnlIntro"
        Me.pnlIntro.Size = New System.Drawing.Size(800, 600)
        Me.pnlIntro.TabIndex = 0
        
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(15, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(770, 40)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "MBTI Step 2 Cognitive Function Assessment"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        
        Me.lblSubtitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(15, 70)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(770, 20)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Based on Carl Jung's Psychological Type Theory · Non-Commercial Academic Tool"
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        
        Me.lblDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(15, 100)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(770, 120)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "This assessment uses Jungian Eight-Dimensional Cognitive Function Model (Se/Si/Ne/Ni/Te/Ti/Fe/Fi), with 5 situational questions per dimension, totaling 40 questions." & vbCrLf & vbCrLf & "Unlike Step 1's simple four-dimensional labels, this assessment focuses on your Cognitive Function Stack, helping you understand the psychological mechanisms behind your thinking preferences rather than fixed personality labels."
        
        Me.lblNotice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNotice.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.lblNotice.Location = New System.Drawing.Point(15, 230)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(770, 100)
        Me.lblNotice.TabIndex = 3
        Me.lblNotice.Text = "⚠️ Important Notice: This tool is a non-commercial academic reference tool developed by psychology enthusiasts based on Jung's original work ""Psychological Types"" and MBTI Step 2 theoretical framework, intended for self-exploration purposes only. It does not constitute psychological diagnosis and does not infringe on any commercial assessment copyrights."
        
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(520, 380)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(265, 50)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start Assessment (8-10 minutes)"
        Me.btnStart.UseVisualStyleBackColor = False
        
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.pnlMain)
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MBTI Step 2 - Cognitive Function Assessment"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlResults.ResumeLayout(False)
        Me.grpChart.ResumeLayout(False)
        Me.grpFunctionStack.ResumeLayout(False)
        Me.grpInterpretation.ResumeLayout(False)
        Me.grpInterpretation.PerformLayout()
        Me.pnlQuestions.ResumeLayout(False)
        Me.pnlProgress.ResumeLayout(False)
        Me.pnlIntro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlResults As Panel
    Friend WithEvents pnlQuestions As Panel
    Friend WithEvents pnlProgress As Panel
    Friend WithEvents pnlIntro As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblNotice As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents lblProgressText As Label
    Friend WithEvents lblProgressPercent As Label
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents lblQuestionNumber As Label
    Friend WithEvents lblQuestionText As Label
    Friend WithEvents pnlOptions As Panel
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblResultsTitle As Label
    Friend WithEvents lblResultsSubtitle As Label
    Friend WithEvents grpChart As GroupBox
    Friend WithEvents lblChartTitle As Label
    Friend WithEvents pnlChart As Panel
    Friend WithEvents grpFunctionStack As GroupBox
    Friend WithEvents lblFunctionStackTitle As Label
    Friend WithEvents pnlFunctionStack As Panel
    Friend WithEvents grpInterpretation As GroupBox
    Friend WithEvents lblInterpretationTitle As Label
    Friend WithEvents txtInterpretation As TextBox
    Friend WithEvents lblDisclaimer As Label
    Friend WithEvents btnRestart As Button
End Class