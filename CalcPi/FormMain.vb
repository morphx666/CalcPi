Imports System.Threading

' https://wikimedia.org/api/rest_v1/media/math/render/svg/664617be29449b83fe4c47625907f1713ec4b523
' Sum from n=1 to Inf. of 1/n^2 = Pi^2/6
' Image from Wikipedia: https://en.wikipedia.org/wiki/Basel_problem

Public Class FormMain

    Private calcThread As Thread
    Private abortThread As Boolean

    Private Sub FormMain_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.FormClosing, Sub()
                                       abortThread = True
                                       Application.DoEvents()
                                   End Sub

        LabelMathPi.Text = " " + Math.PI.ToString()

        calcThread = New Thread(Sub()
                                    Const refreshRate As Integer = CInt(97856 * 1.5)
                                    Dim i As Decimal = 0D
                                    Dim n As ULong = 0
                                    Dim r As Decimal
                                    Dim lr As Decimal
                                    Dim sw As New Stopwatch()

                                    sw.Start()

                                    Do
                                        n += 1UL
                                        i += 1D / (n * n)

                                        If n Mod refreshRate = 0 Then
                                            r = CDec(Math.Sqrt(i * 6D))

                                            Me.Invoke(New MethodInvoker(Sub()
                                                                            LabelIter.Text = n.ToString("N0")

                                                                            LabelCalcPi.Text = " " + r.ToString("F14")
                                                                            LabelPercent.Text = $"{(r / Math.PI * 100):F14}%"
                                                                            LabelDif.Text = " " + (Math.Abs(r - Math.PI)).ToString("F21")
                                                                            LabelElapsed.Text = $"{sw.Elapsed.Hours:00}h : {sw.Elapsed.Minutes:00}m : {sw.Elapsed.Seconds:00}s : {sw.Elapsed.Milliseconds:000}ms"
                                                                        End Sub))

                                            If r = lr Then Exit Do
                                            lr = r
                                        End If
                                    Loop Until abortThread
                                    sw.Stop()
                                End Sub) With {.IsBackground = True}
        calcThread.Start()
    End Sub
End Class
