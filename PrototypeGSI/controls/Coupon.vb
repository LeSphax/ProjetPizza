Public Class Coupon

    Enum State
        INACTIVE
        BLINKING
        ACTIVE
    End Enum

    Private CouponState As State

    Public Sub New()
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        LabelCoupon.Text = ""
        LabelBlink.Text = ""
        LabelBlink.Visible = False
        CouponState = State.INACTIVE
    End Sub

    Public Sub Reset()
        CouponState = State.INACTIVE
    End Sub

    Public Sub SetTextCoupon(TextCoupon As String)
        LabelCoupon.Text = TextCoupon
    End Sub


    Public Sub SetTextBlink(TextBlink As String)
        LabelBlink.Text = TextBlink
    End Sub

    Public Sub UpdateCouponAdd(NbPizza As Integer, Pizza As Pizza)
        Select Case CouponState
            Case State.INACTIVE
                If NbPizza = 2 Then
                    Blink()
                    CouponState = State.BLINKING
                End If

            Case State.BLINKING
                If NbPizza = 3 Then
                    StopBlinking()
                    CouponState = State.ACTIVE
                    PanelCoupon.BackColor = Color.Green
                    Form1.SetReduc(Pizza.Price)
                End If

            Case State.ACTIVE

        End Select
    End Sub

    Public Sub UpdateCouponSuppr(NbPizza As Integer, Pizza As Pizza)
        Select Case CouponState
            Case State.INACTIVE

            Case State.BLINKING
                If NbPizza < 2 Then
                    StopBlinking()
                    PanelCoupon.BackColor = Color.White
                    Form1.ResetReduc(0)
                    CouponState = State.INACTIVE
                End If

            Case State.ACTIVE
                If NbPizza = 2 Then
                    LabelBlink.Show()
                    Blink()
                    PanelCoupon.BackColor = Color.White
                    Form1.ResetReduc(0)
                    CouponState = State.BLINKING
                End If
                If NbPizza < 2 Then
                    StopBlinking()
                    PanelCoupon.BackColor = Color.White
                    Form1.ResetReduc(0)
                    CouponState = State.INACTIVE
                End If


        End Select
    End Sub

    Private Sub Blink()
        Timer1.Interval = 1500
        Timer1.Start()
    End Sub
    Private Sub StopBlinking()
        Timer1.Stop()
        LabelBlink.Visible = False

    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not LabelBlink.Visible Then
            LabelBlink.Visible = True
        Else
            LabelBlink.Visible = False
        End If
    End Sub
End Class
