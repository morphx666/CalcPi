<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.LabelCalcPi = New System.Windows.Forms.Label()
        Me.LabelPercent = New System.Windows.Forms.Label()
        Me.LabelDif = New System.Windows.Forms.Label()
        Me.LabelMathPi = New System.Windows.Forms.Label()
        Me.LabelElapsed = New System.Windows.Forms.Label()
        Me.LabelIter = New System.Windows.Forms.Label()
        Me.PictureBoxFormula = New System.Windows.Forms.PictureBox()
        Me.PanelHideDot = New System.Windows.Forms.Panel()
        CType(Me.PictureBoxFormula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelCalcPi
        '
        Me.LabelCalcPi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelCalcPi.AutoSize = True
        Me.LabelCalcPi.Location = New System.Drawing.Point(14, 51)
        Me.LabelCalcPi.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelCalcPi.Name = "LabelCalcPi"
        Me.LabelCalcPi.Size = New System.Drawing.Size(82, 24)
        Me.LabelCalcPi.TabIndex = 0
        Me.LabelCalcPi.Text = "CalcPi"
        '
        'LabelPercent
        '
        Me.LabelPercent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelPercent.AutoSize = True
        Me.LabelPercent.Location = New System.Drawing.Point(14, 99)
        Me.LabelPercent.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelPercent.Name = "LabelPercent"
        Me.LabelPercent.Size = New System.Drawing.Size(94, 24)
        Me.LabelPercent.TabIndex = 1
        Me.LabelPercent.Text = "Percent"
        '
        'LabelDif
        '
        Me.LabelDif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelDif.AutoSize = True
        Me.LabelDif.Location = New System.Drawing.Point(14, 123)
        Me.LabelDif.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelDif.Name = "LabelDif"
        Me.LabelDif.Size = New System.Drawing.Size(130, 24)
        Me.LabelDif.TabIndex = 2
        Me.LabelDif.Text = "Difference"
        '
        'LabelMathPi
        '
        Me.LabelMathPi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelMathPi.AutoSize = True
        Me.LabelMathPi.Location = New System.Drawing.Point(14, 75)
        Me.LabelMathPi.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelMathPi.Name = "LabelMathPi"
        Me.LabelMathPi.Size = New System.Drawing.Size(82, 24)
        Me.LabelMathPi.TabIndex = 0
        Me.LabelMathPi.Text = "MathPi"
        '
        'LabelElapsed
        '
        Me.LabelElapsed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelElapsed.AutoSize = True
        Me.LabelElapsed.Location = New System.Drawing.Point(496, 123)
        Me.LabelElapsed.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelElapsed.Name = "LabelElapsed"
        Me.LabelElapsed.Size = New System.Drawing.Size(286, 24)
        Me.LabelElapsed.TabIndex = 2
        Me.LabelElapsed.Text = "00h : 00m : 00s : 000ms"
        '
        'LabelIter
        '
        Me.LabelIter.AutoSize = True
        Me.LabelIter.Location = New System.Drawing.Point(14, 9)
        Me.LabelIter.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelIter.Name = "LabelIter"
        Me.LabelIter.Size = New System.Drawing.Size(58, 24)
        Me.LabelIter.TabIndex = 2
        Me.LabelIter.Text = "Iter"
        '
        'PictureBoxFormula
        '
        Me.PictureBoxFormula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxFormula.Image = CType(resources.GetObject("PictureBoxFormula.Image"), System.Drawing.Image)
        Me.PictureBoxFormula.Location = New System.Drawing.Point(558, 9)
        Me.PictureBoxFormula.Name = "PictureBoxFormula"
        Me.PictureBoxFormula.Size = New System.Drawing.Size(226, 108)
        Me.PictureBoxFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxFormula.TabIndex = 3
        Me.PictureBoxFormula.TabStop = False
        '
        'PanelHideDot
        '
        Me.PanelHideDot.Location = New System.Drawing.Point(774, 61)
        Me.PanelHideDot.Name = "PanelHideDot"
        Me.PanelHideDot.Size = New System.Drawing.Size(13, 12)
        Me.PanelHideDot.TabIndex = 4
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 160)
        Me.Controls.Add(Me.PanelHideDot)
        Me.Controls.Add(Me.PictureBoxFormula)
        Me.Controls.Add(Me.LabelElapsed)
        Me.Controls.Add(Me.LabelIter)
        Me.Controls.Add(Me.LabelDif)
        Me.Controls.Add(Me.LabelPercent)
        Me.Controls.Add(Me.LabelMathPi)
        Me.Controls.Add(Me.LabelCalcPi)
        Me.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CalcPi"
        CType(Me.PictureBoxFormula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCalcPi As System.Windows.Forms.Label
    Friend WithEvents LabelPercent As System.Windows.Forms.Label
    Friend WithEvents LabelDif As System.Windows.Forms.Label
    Friend WithEvents LabelMathPi As Label
    Friend WithEvents LabelElapsed As Label
    Friend WithEvents LabelIter As Label
    Friend WithEvents PictureBoxFormula As PictureBox
    Friend WithEvents PanelHideDot As Panel
End Class
