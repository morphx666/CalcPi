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
        Me.LabelError = New System.Windows.Forms.Label()
        Me.LabelDif = New System.Windows.Forms.Label()
        Me.LabelMathPi = New System.Windows.Forms.Label()
        Me.LabelElapsed = New System.Windows.Forms.Label()
        Me.LabelIter = New System.Windows.Forms.Label()
        Me.PictureBoxFormula = New System.Windows.Forms.PictureBox()
        Me.PanelHideDot = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxFormula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelCalcPi
        '
        Me.LabelCalcPi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelCalcPi.AutoSize = True
        Me.LabelCalcPi.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LabelCalcPi.Location = New System.Drawing.Point(155, 76)
        Me.LabelCalcPi.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelCalcPi.Name = "LabelCalcPi"
        Me.LabelCalcPi.Size = New System.Drawing.Size(82, 24)
        Me.LabelCalcPi.TabIndex = 0
        Me.LabelCalcPi.Text = "CalcPi"
        '
        'LabelError
        '
        Me.LabelError.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelError.AutoSize = True
        Me.LabelError.ForeColor = System.Drawing.Color.OrangeRed
        Me.LabelError.Location = New System.Drawing.Point(155, 100)
        Me.LabelError.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(70, 24)
        Me.LabelError.TabIndex = 1
        Me.LabelError.Text = "Error"
        '
        'LabelDif
        '
        Me.LabelDif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelDif.AutoSize = True
        Me.LabelDif.ForeColor = System.Drawing.Color.DarkSalmon
        Me.LabelDif.Location = New System.Drawing.Point(155, 124)
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
        Me.LabelMathPi.ForeColor = System.Drawing.Color.Green
        Me.LabelMathPi.Location = New System.Drawing.Point(155, 52)
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
        Me.LabelIter.ForeColor = System.Drawing.Color.DimGray
        Me.LabelIter.Location = New System.Drawing.Point(155, 10)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Iteration:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Approximation:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Math.PI:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Error:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Difference:"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 160)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelHideDot)
        Me.Controls.Add(Me.PictureBoxFormula)
        Me.Controls.Add(Me.LabelElapsed)
        Me.Controls.Add(Me.LabelIter)
        Me.Controls.Add(Me.LabelDif)
        Me.Controls.Add(Me.LabelError)
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
    Friend WithEvents LabelError As System.Windows.Forms.Label
    Friend WithEvents LabelDif As System.Windows.Forms.Label
    Friend WithEvents LabelMathPi As Label
    Friend WithEvents LabelElapsed As Label
    Friend WithEvents LabelIter As Label
    Friend WithEvents PictureBoxFormula As PictureBox
    Friend WithEvents PanelHideDot As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
