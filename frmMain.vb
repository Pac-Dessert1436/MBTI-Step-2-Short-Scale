#Disable Warning IDE1006
Imports System.Diagnostics.CodeAnalysis

Public Class frmMain
    <STAThread()>
    Friend Shared Sub Main()
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New frmMain)
    End Sub

    Private questions As New List(Of Question)
    Private shuffledQuestions As New List(Of Question)
    Private currentQuestionIndex As Integer = 0
    Private scores As New Dictionary(Of String, Integer) From {
        {"Se", 0}, {"Si", 0}, {"Ne", 0}, {"Ni", 0},
        {"Te", 0}, {"Ti", 0}, {"Fe", 0}, {"Fi", 0}
    }
    Private answers As New List(Of Answer)()
    Private selectedOptionIndex As Integer = -1
    Private currentOptionButtons As New List(Of RadioButton)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        InitializeQuestions()
        ShowIntroPanel()
    End Sub

    <SuppressMessage("Performance", "CA1861")>
    Private Sub InitializeQuestions()
        questions.Clear()

        questions.Add(New Question("Se", "When you enter a new environment, what do you notice first?", {
            "Specific details (lighting, sounds, smells, layout)",
            "Overall atmosphere and potential possibilities",
            "Logical structure and operation of the environment",
            "Interpersonal relationships and emotional atmosphere in the environment"
        }))

        questions.Add(New Question("Se", "When solving problems, you tend to:", {
            "Take immediate action, learning through trial and error",
            "Review past experiences to find similar cases",
            "Explore multiple possible innovative solutions",
            "Deeply analyze the underlying principles of the problem"
        }))

        questions.Add(New Question("Se", "Activities you enjoy more are:", {
            "Sports, crafts, live performances and other sensory experiences",
            "Reading history, collecting, traditional crafts",
            "Brainstorming, creative writing, exploring new fields",
            "Strategic planning, philosophical thinking, long-term planning"
        }))

        questions.Add(New Question("Se", "When facing stress, you usually:", {
            "Release stress through specific activities (exercise, food, travel)",
            "Rely on familiar routines and past experiences to comfort yourself",
            "Imagine various possibilities to distract attention",
            "Re-understand the source of stress from a higher perspective"
        }))

        questions.Add(New Question("Se", "Your way of learning new skills is usually:", {
            "Learn by doing, master through body memory",
            "Learn according to traditional methods and standard steps",
            "Try multiple different learning paths",
            "Understand the underlying principles before practicing"
        }))

        questions.Add(New Question("Si", "You usually remember past experiences by:", {
            "Specific sensory details (weather, clothing, smells at the time)",
            "Extracting abstract concepts and patterns",
            "Associating with other possible development paths",
            "Analyzing the causal relationships behind events"
        }))

        questions.Add(New Question("Si", "At work, you value more:", {
            "Following verified standard procedures",
            "Creating completely new working methods",
            "Adapting to team harmony",
            "Establishing clear logical systems"
        }))

        questions.Add(New Question("Si", "Your view on health management is:", {
            "Adjust lifestyle habits based on past body reactions",
            "Try various novel health methods",
            "Refer to authoritative medical advice and statistical data",
            "Adjust flexibly based on internal body feelings"
        }))

        questions.Add(New Question("Si", "When traveling, you prefer:", {
            "Revisiting familiar places, looking for traces of the past",
            "Exploring completely unfamiliar destinations",
            "Establishing deep emotional connections with locals",
            "Understanding local historical and cultural context"
        }))

        questions.Add(New Question("Si", "When making decisions, you rely more on:", {
            "Results of similar past situations and personal experience",
            "Intuitive possibilities and inspiration",
            "Objective data and logical analysis",
            "Current emotional value and interpersonal relationships"
        }))

        questions.Add(New Question("Ne", "In brainstorming, you usually:", {
            "Quickly generate many different ideas with jumping associations",
            "Deeply explore the deeper meaning of one idea",
            "Focus on the practical feasibility of ideas",
            "Evaluate the impact of ideas on team emotions"
        }))

        questions.Add(New Question("Ne", "Topics you are more interested in are:", {
            "Cross-disciplinary connections, future trends, innovative concepts",
            "Specific technical details and operation manuals",
            "Subtle emotional changes in interpersonal interactions",
            "Systematic theoretical framework construction"
        }))

        questions.Add(New Question("Ne", "When reading articles, you often:", {
            "Associate with many other related or unrelated viewpoints",
            "Carefully remember specific facts in the article",
            "Analyze whether the article's argumentation logic is rigorous",
            "Experience the author's emotional attitude and values"
        }))

        questions.Add(New Question("Ne", "Your way of planning the future is:", {
            "Stay open, adjust direction anytime based on new opportunities",
            "Make detailed long-term plans and execute strictly",
            "Predict future trends based on past experience",
            "Determine life direction starting from core values"
        }))

        questions.Add(New Question("Ne", "In social situations, you tend to:", {
            "Jump between different topics, connecting various ideas",
            "Deeply discuss details of a specific topic",
            "Focus on current sensory experiences and atmosphere",
            "Maintain harmonious interpersonal relationship atmosphere"
        }))

        questions.Add(New Question("Ni", "Your way of generating inspiration is usually:", {
            "Sudden epiphany, seeing hidden patterns behind things",
            "Generating associations through massive external information stimulation",
            "Sudden enlightenment based on accumulated past experience",
            "Drawing conclusions through logical deduction"
        }))

        questions.Add(New Question("Ni", "Your view of the future is:", {
            "A vague certainty, knowing the general direction",
            "Full of various open possibilities",
            "Specific predictions based on current trends",
            "Focus on current practical experiences"
        }))

        questions.Add(New Question("Ni", "In complex situations, you trust more:", {
            "Inner intuition and premonitions",
            "Observable facts and data",
            "Verified traditional methods",
            "Logical analysis and causal reasoning"
        }))

        questions.Add(New Question("Ni", "Your way of expressing viewpoints is usually:", {
            "Using metaphors and symbols, hard to express but meaningful",
            "Listing many specific examples",
            "Building rigorous logical arguments",
            "Directly stating emotional positions"
        }))

        questions.Add(New Question("Ni", "The goals you pursue are:", {
            "Realizing inner visions and life missions",
            "Gaining rich sensory experiences",
            "Mastering objective knowledge and skills",
            "Maintaining important interpersonal relationships"
        }))

        questions.Add(New Question("Te", "Your way of organizing work is:", {
            "Setting clear goals, processes, and measurable standards",
            "Adjusting flexibly based on team harmony",
            "Exploring multiple possible execution plans",
            "Deeply understanding the principles behind work"
        }))

        questions.Add(New Question("Te", "You think good decisions should:", {
            "Be based on objective data and verifiable results",
            "Consider the emotional impact on all relevant personnel",
            "Maintain openness and adaptability",
            "Conform to internal logical consistency"
        }))

        questions.Add(New Question("Te", "In arguments, you value more:", {
            "Which side has a more efficient and executable plan",
            "Which side better maintains relationship harmony",
            "Which side has more unique and innovative viewpoints",
            "Which side has more rigorous and self-consistent logic"
        }))

        questions.Add(New Question("Te", "Your criteria for evaluating others are:", {
            "Their achievements, efficiency, and actual output",
            "Their sincerity and value consistency",
            "Their creativity and unique perspectives",
            "Their knowledge depth and logical ability"
        }))

        questions.Add(New Question("Te", "Facing chaotic situations, you first:", {
            "Establish order, assign tasks, set deadlines",
            "Soothe all parties' emotions, seek consensus",
            "Look for hidden opportunities and possibilities",
            "Analyze the root causes of chaos"
        }))

        questions.Add(New Question("Ti", "When understanding new things, you value most:", {
            "Whether its internal logic is self-consistent and classification is precise",
            "Its practical application value and efficiency",
            "Its significance to personal emotions",
            "Its connection possibilities with the external world"
        }))

        questions.Add(New Question("Ti", "The reason you stick to your views is:", {
            "After rigorous logical deduction, believing the viewpoint itself is correct",
            "Emotionally unable to accept other options",
            "Intuitively feeling it should be so",
            "Past experience proves this is effective"
        }))

        questions.Add(New Question("Ti", "Your preference for learning theories is:", {
            "Building precise classification systems and conceptual frameworks",
            "Learning practical skills that can be directly applied",
            "Exploring various application possibilities of theories",
            "Understanding the deep meaning of theories for life"
        }))

        questions.Add(New Question("Ti", "When analyzing problems, you tend to:", {
            "Break down to the most basic elements, redefine concepts",
            "Find the fastest and most effective solution",
            "Consider multiple possible interpretation angles",
            "Focus on the impact of problems on people"
        }))

        questions.Add(New Question("Ti", "Your view on ""truth"" is:", {
            "A system that is logically self-consistent and internally consistent",
            "Experience verified through practice",
            "Beliefs that align with personal values",
            "Multiple interpretations that change with context"
        }))

        questions.Add(New Question("Fe", "In team decision-making, you focus most on:", {
            "Ensuring everyone's feelings are considered, maintaining team harmony",
            "Objective rationality and efficiency of decisions",
            "Whether decisions conform to logical truth",
            "Whether decisions reflect unique innovation"
        }))

        questions.Add(New Question("Fe", "Your way of expressing criticism is usually:", {
            "Subtle hints, considering the other person's face, avoiding hurting relationships",
            "Directly pointing out problems, focusing on facts themselves",
            "Analyzing why it's wrong from a principle level",
            "Using humor or changing topics to resolve"
        }))

        questions.Add(New Question("Fe", "You believe your responsibility to others is:", {
            "Maintaining the group's emotional atmosphere and moral consensus",
            "Helping others solve practical problems",
            "Inspiring others to see new possibilities",
            "Respecting others' inner uniqueness"
        }))

        questions.Add(New Question("Fe", "In social activities, you:", {
            "Keenly perceive group emotions, actively adjust the atmosphere",
            "Focus on factual accuracy in conversations",
            "Introduce novel topics to stimulate discussion",
            "Observe but don't easily intervene in others' interactions"
        }))

        questions.Add(New Question("Fe", "When making moral judgments, you base on:", {
            "Impact on group harmony and well-being",
            "Universally applicable logical principles",
            "Personal unique value experiences",
            "Long-term historical development trends"
        }))

        questions.Add(New Question("Fi", "Your way of forming values is:", {
            "Gradually internalizing through profound personal experience, very unique",
            "Adapting to social norms and others' expectations",
            "Based on logical analysis and objective facts",
            "Staying open and changing with context"
        }))

        questions.Add(New Question("Fi", "When others ask for help, you first consider:", {
            "Whether this aligns with my core values and true feelings",
            "What is the most effective solution",
            "Various possible ways to help",
            "Group expectations and conventional practices"
        }))

        questions.Add(New Question("Fi", "Your way of expressing emotions is:", {
            "Selectively showing deep emotions to trusted people",
            "Natural expression, adapting to social occasion atmosphere",
            "Expressing through actions and practical help",
            "Transforming emotions into artistic creation or conceptual expression"
        }))

        questions.Add(New Question("Fi", "Your understanding of ""being yourself"" is:", {
            "Faithful to inner values, even if contrary to worldly norms",
            "Playing a unique role in the group",
            "Mastering unique skills and knowledge",
            "Staying open and adapting to various roles"
        }))

        questions.Add(New Question("Fi", "When facing conflict, you usually:", {
            "Avoid surface arguments but stick to inner positions",
            "Face conflict directly, solve problems quickly",
            "Look for win-win innovative solutions",
            "Analyze the essential causes of conflict"
        }))
    End Sub

    Private Sub ShowIntroPanel()
        pnlIntro.Visible = True
        pnlProgress.Visible = False
        pnlQuestions.Visible = False
        pnlResults.Visible = False
    End Sub

    Private Sub ShowProgressPanel()
        pnlIntro.Visible = False
        pnlProgress.Visible = True
        pnlQuestions.Visible = True
        pnlResults.Visible = False
    End Sub

    Private Sub ShowResultsPanel()
        pnlIntro.Visible = False
        pnlProgress.Visible = False
        pnlQuestions.Visible = False
        pnlResults.Visible = True
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartAssessment()
    End Sub

    Private Sub StartAssessment()
        ResetAssessment()
        ShuffleQuestions()
        ShowProgressPanel()
        RenderQuestion()
    End Sub

    Private Sub ResetAssessment()
        currentQuestionIndex = 0
        For Each key In scores.Keys
            scores(key) = 0
        Next
        answers.Clear()
        selectedOptionIndex = -1
    End Sub

    Private Sub ShuffleQuestions()
        shuffledQuestions = questions.ToList()
        Dim random As New Random()

        For i As Integer = shuffledQuestions.Count - 1 To 1 Step -1
            Dim j As Integer = random.Next(i + 1)
            Dim temp As Question = shuffledQuestions(i)
            shuffledQuestions(i) = shuffledQuestions(j)
            shuffledQuestions(j) = temp
        Next
    End Sub

    Private Sub RenderQuestion()
        If currentQuestionIndex >= shuffledQuestions.Count Then
            ShowResults()
            Return
        End If

        Dim currentQ As Question = shuffledQuestions(currentQuestionIndex)
        Dim dimensionNames As New Dictionary(Of String, String) From {
            {"Se", "Extraverted Sensing (Se)"}, {"Si", "Introverted Sensing (Si)"},
            {"Ne", "Extraverted Intuition (Ne)"}, {"Ni", "Introverted Intuition (Ni)"},
            {"Te", "Extraverted Thinking (Te)"}, {"Ti", "Introverted Thinking (Ti)"},
            {"Fe", "Extraverted Feeling (Fe)"}, {"Fi", "Introverted Feeling (Fi)"}
        }

        lblQuestionNumber.Text = $"{dimensionNames(currentQ.Dimension)} · Question {currentQuestionIndex + 1}/{shuffledQuestions.Count}"
        lblQuestionText.Text = currentQ.Text

        pnlOptions.Controls.Clear()
        currentOptionButtons.Clear()
        selectedOptionIndex = -1

        Dim yOffset As Integer = 10
        For i As Integer = 0 To currentQ.Options.Length - 1
            Dim rb As New RadioButton() With {
                .Text = currentQ.Options(i),
                .Location = New Point(5, yOffset),
                .Size = New Size(760, 50),
                .Font = New Font("Segoe UI", 12, FontStyle.Regular),
                .AutoSize = False
            }
            AddHandler rb.CheckedChanged, AddressOf Option_CheckedChanged
            pnlOptions.Controls.Add(rb)
            currentOptionButtons.Add(rb)
            yOffset += 35
        Next

        UpdateProgress()
        UpdateNavigationButtons()
    End Sub

    Private Sub Option_CheckedChanged(sender As Object, e As EventArgs)
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        If rb.Checked Then
            selectedOptionIndex = currentOptionButtons.IndexOf(rb)
            UpdateNavigationButtons()
        End If
    End Sub

    Private Sub UpdateProgress()
        Dim percent As Integer = CInt(Math.Round((currentQuestionIndex / shuffledQuestions.Count) * 100))
        progressBar.Value = percent
        lblProgressPercent.Text = $"{percent}%"
    End Sub

    Private Sub UpdateNavigationButtons()
        btnPrevious.Enabled = currentQuestionIndex > 0
        btnNext.Enabled = selectedOptionIndex >= 0
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If selectedOptionIndex < 0 Then Return

        Dim currentQ As Question = shuffledQuestions(currentQuestionIndex)
        Dim points As Integer = If(selectedOptionIndex = 0, 4, If(selectedOptionIndex = 1, 2, 1))

        scores(currentQ.Dimension) += points
        answers.Add(New Answer(currentQ.Dimension, selectedOptionIndex, points))

        currentQuestionIndex += 1
        selectedOptionIndex = -1

        If currentQuestionIndex < shuffledQuestions.Count Then
            RenderQuestion()
        Else
            ShowResults()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentQuestionIndex > 0 Then
            currentQuestionIndex -= 1
            Dim lastAnswer As Answer = answers.Last()
            scores(lastAnswer.Dimension) -= lastAnswer.Points
            answers.RemoveAt(answers.Count - 1)
            selectedOptionIndex = -1
            RenderQuestion()
        End If
    End Sub

    Private Sub ShowResults()
        ShowResultsPanel()
        RenderChart()
        RenderFunctionStack()
        RenderInterpretation()
    End Sub

    Private Sub RenderChart()
        pnlChart.Controls.Clear()

        Dim dimensions As New List(Of DimensionInfo)()
        dimensions.Add(New DimensionInfo("Se", "Extraverted Sensing Se", "se"))
        dimensions.Add(New DimensionInfo("Si", "Introverted Sensing Si", "si"))
        dimensions.Add(New DimensionInfo("Ne", "Extraverted Intuition Ne", "ne"))
        dimensions.Add(New DimensionInfo("Ni", "Introverted Intuition Ni", "ni"))
        dimensions.Add(New DimensionInfo("Te", "Extraverted Thinking Te", "te"))
        dimensions.Add(New DimensionInfo("Ti", "Introverted Thinking Ti", "ti"))
        dimensions.Add(New DimensionInfo("Fe", "Extraverted Feeling Fe", "fe"))
        dimensions.Add(New DimensionInfo("Fi", "Introverted Feeling Fi", "fi"))

        Dim maxScore As Integer = 20
        Dim yOffset As Integer = 10

        For Each [dim] In dimensions
            Dim score As Integer = scores([dim].Key)
            Dim percent As Double = (score / maxScore) * 100

            Dim pnlBar As New Panel() With {
                .Location = New Point(5, yOffset),
                .Size = New Size(740, 22),
                .BorderStyle = BorderStyle.FixedSingle
            }

            Dim lblName As New Label() With {
                .Text = [dim].Name,
                .Location = New Point(5, 2),
                .Size = New Size(180, 18),
                .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            }
            pnlBar.Controls.Add(lblName)

            Dim lblScore As New Label() With {
                .Text = $"{score}/20 ({CInt(percent)}%)",
                .Location = New Point(560, 2),
                .Size = New Size(175, 18),
                .Font = New Font("Segoe UI", 8),
                .TextAlign = ContentAlignment.MiddleRight
            }
            pnlBar.Controls.Add(lblScore)

            Dim pnlFill As New Panel() With {
                .Location = New Point(190, 2),
                .Size = New Size(CInt(365 * percent / 100), 18),
                .BackColor = GetDimensionColor([dim].Color)
            }
            pnlBar.Controls.Add(pnlFill)

            pnlChart.Controls.Add(pnlBar)
            yOffset += 25
        Next
    End Sub

    Private Function GetDimensionColor(colorName As String) As Color
        Select Case colorName
            Case "se" : Return Color.FromArgb(237, 137, 54)
            Case "si" : Return Color.FromArgb(104, 211, 145)
            Case "ne" : Return Color.FromArgb(99, 179, 237)
            Case "ni" : Return Color.FromArgb(159, 122, 234)
            Case "te" : Return Color.FromArgb(252, 129, 129)
            Case "ti" : Return Color.FromArgb(79, 209, 197)
            Case "fe" : Return Color.FromArgb(246, 135, 179)
            Case "fi" : Return Color.FromArgb(246, 224, 94)
            Case Else : Return Color.Gray
        End Select
    End Function

    Private Sub RenderFunctionStack()
        pnlFunctionStack.Controls.Clear()

        Dim sortedDims As List(Of String) = scores.OrderByDescending(Function(x) x.Value).Select(Function(x) x.Key).ToList()
        Dim positions As String() = {"Dominant Function", "Auxiliary Function", "Tertiary Function", "Inferior Function"}
        Dim descriptions As New Dictionary(Of String, String) From {
            {"Se", "Living in the present, experiencing reality directly through senses, strong action ability, adapting to environmental changes"},
            {"Si", "Relying on past experiences, valuing details and accuracy, maintaining traditions and stability"},
            {"Ne", "Exploring possibilities, rich associations, good at discovering potential connections and innovative solutions"},
            {"Ni", "Insight into deep patterns, foreseeing future trends, pursuing inner visions and meaning"},
            {"Te", "Focusing on efficiency and results, good at organizing resources, setting objective standards to achieve goals"},
            {"Ti", "Pursuing precise classification and logical self-consistency, analyzing principles, building internal knowledge systems"},
            {"Fe", "Maintaining group harmony, keenly perceiving others' emotions, making value judgments based on consensus"},
            {"Fi", "Faithful to inner values, deeply experiencing personal emotions, pursuing authentic self-expression"}
        }

        Dim yOffset As Integer = 10
        For i As Integer = 0 To Math.Min(3, sortedDims.Count - 1)
            Dim [dim] As String = sortedDims(i)
            Dim pnlCard As New Panel() With {
                .Location = New Point(5, yOffset),
                .Size = New Size(740, 42),
                .BackColor = GetFunctionStackColor(i),
                .BorderStyle = BorderStyle.FixedSingle
            }

            Dim lblTitle As New Label() With {
                .Text = $"{positions(i)}: {[dim]} ({scores([dim])} points)",
                .Location = New Point(5, 4),
                .Size = New Size(730, 16),
                .Font = New Font("Segoe UI", 9, FontStyle.Bold)
            }
            pnlCard.Controls.Add(lblTitle)

            Dim lblDesc As New Label() With {
                .Text = descriptions([dim]),
                .Location = New Point(5, 22),
                .Size = New Size(730, 16),
                .Font = New Font("Segoe UI", 8)
            }
            pnlCard.Controls.Add(lblDesc)

            pnlFunctionStack.Controls.Add(pnlCard)
            yOffset += 47
        Next
    End Sub

    Private Function GetFunctionStackColor(index As Integer) As Color
        Select Case index
            Case 0 : Return Color.FromArgb(250, 245, 255)
            Case 1 : Return Color.FromArgb(235, 248, 255)
            Case 2 : Return Color.FromArgb(240, 255, 244)
            Case 3 : Return Color.FromArgb(255, 250, 240)
            Case Else : Return Color.White
        End Select
    End Function

    Private Sub RenderInterpretation()
        Dim e As Integer = scores("Se") + scores("Ne") + scores("Te") + scores("Fe")
        Dim i As Integer = scores("Si") + scores("Ni") + scores("Ti") + scores("Fi")
        Dim s As Integer = scores("Se") + scores("Si")
        Dim n As Integer = scores("Ne") + scores("Ni")
        Dim t As Integer = scores("Te") + scores("Ti")
        Dim f As Integer = scores("Fe") + scores("Fi")
        Dim j As Integer = scores("Te") + scores("Fe") + scores("Si") + scores("Ni")
        Dim p As Integer = scores("Ti") + scores("Fi") + scores("Se") + scores("Ne")

        Dim type As String = (If(e > i, "E", "I")) + (If(s > n, "S", "N")) + (If(t > f, "T", "F")) + (If(j > p, "J", "P"))

        Dim perceiving As String = If(scores("Se") > scores("Si"), "Se", "Si")
        Dim perceiving2 As String = If(scores("Ne") > scores("Ni"), "Ne", "Ni")
        Dim judging As String = If(scores("Te") > scores("Ti"), "Te", "Ti")
        Dim judging2 As String = If(scores("Fe") > scores("Fi"), "Fe", "Fi")

        Dim dominantP As String = If(scores(perceiving) > scores(perceiving2), perceiving, perceiving2)
        Dim dominantJ As String = If(scores(judging) > scores(judging2), judging, judging2)
        Dim dominant As String = If(scores(dominantP) > scores(dominantJ), dominantP, dominantJ)

        Dim interpretation As New Text.StringBuilder
        interpretation.AppendLine($"Possible Type Tendency: {type} (For reference only, cognitive functions describe you better than four-letter labels)")
        interpretation.AppendLine()
        interpretation.AppendLine("Core Cognitive Pattern Analysis:")
        interpretation.AppendLine()
        interpretation.AppendLine($"Your dominant function appears to be {dominant}, which means your most natural and trusted cognitive method is " +
                             $"{If(dominant.StartsWith("S"c) OrElse dominant.StartsWith("N"c), "Perceiving", "Judging")} " +
                             $"{If(dominant.StartsWith("E"c), "Extraverted", "Introverted")} mode.")
        interpretation.AppendLine()
        interpretation.AppendLine("Development Suggestions:")
        interpretation.AppendLine("1. Strengthen dominant function: Continue developing your most skilled " & dominant & " ability, this is your core advantage.")
        interpretation.AppendLine("2. Cultivate inferior function: Consciously exercise the lowest-scoring function to achieve cognitive balance.")
        interpretation.AppendLine("3. Avoid over-identification: Jung emphasized the wholeness of personality, avoid over-developing one function while suppressing others.")
        interpretation.AppendLine()
        interpretation.AppendLine("Note: This interpretation is based on Jungian analytical psychology principles. The essence of Step 2 assessment is understanding the dynamic interaction of cognitive functions, not static labels. Your cognitive function stack may present different aspects in different contexts and life stages.")

        txtInterpretation.Text = interpretation.ToString()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        StartAssessment()
    End Sub

    Private Class Question
        Public Property Dimension As String
        Public Property Text As String
        Public Property Options As String()

        Public Sub New(dimension As String, text As String, options As String())
            Me.Dimension = dimension
            Me.Text = text
            Me.Options = options
        End Sub
    End Class

    Private Class Answer
        Public Property Dimension As String
        Public Property Choice As Integer
        Public Property Points As Integer

        Public Sub New(dimension As String, choice As Integer, points As Integer)
            Me.Dimension = dimension
            Me.Choice = choice
            Me.Points = points
        End Sub
    End Class

    Private Class DimensionInfo
        Public Property Key As String
        Public Property Name As String
        Public Property Color As String

        Public Sub New(key As String, name As String, color As String)
            Me.Key = key
            Me.Name = name
            Me.Color = color
        End Sub
    End Class
End Class
#Enable Warning IDE1006