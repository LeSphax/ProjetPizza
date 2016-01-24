Public Class Coupon

    Enum State
        INACTIVE
        BLINKING
        ACTIVE
    End Enum

    Private CouponState As State
    Private NbPizza As Integer

    Public Sub New()
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        LabelCoupon.Text = ""
        LabelBlink.Text = ""
        LabelBlink.Visible = False
        CouponState = State.INACTIVE
        NbPizza = 0
    End Sub

    Public Sub Init()
        Select Case CouponState
            Case State.INACTIVE
                PanelCoupon.BackColor = Color.White
            Case State.BLINKING
                PanelCoupon.BackColor = Color.White
            Case State.ACTIVE
                PanelCoupon.BackColor = Color.Green
        End Select
    End Sub

    Public Sub SetTextCoupon(TextCoupon As String)
        LabelCoupon.Text = TextCoupon
    End Sub


    Public Sub SetTextBlink(TextBlink As String)
        LabelBlink.Text = TextBlink
    End Sub

    Public Sub UpdateCouponAdd(Pizza As Pizza)
        NbPizza += 1
        Select Case CouponState
            Case State.INACTIVE
                If NbPizza < 2 Then
                    CouponState = State.INACTIVE
                End If
                If NbPizza = 2 Then
                    Blink()
                    CouponState = State.BLINKING
                End If
                Init()

            Case State.BLINKING
                StopBlinking()
                Form1.SetReduc(Pizza.Price)
                CouponState = State.ACTIVE
                Init()

            Case State.ACTIVE
                CouponState = State.ACTIVE
                Init()
        End Select
    End Sub

    Public Sub UpdateCouponRemoveOnePizza()
        NbPizza -= 1

        Select Case CouponState
            Case State.INACTIVE
            Case State.BLINKING
                If NbPizza < 2 Then
                    StopBlinking()
                    CouponState = State.INACTIVE
                End If
                Init()

            Case State.ACTIVE

                If NbPizza = 2 Then
                    LabelBlink.Show()
                    Blink()
                    Form1.ResetReduc(0)
                    CouponState = State.BLINKING
                End If
                If NbPizza < 2 Then
                    StopBlinking()
                    Form1.ResetReduc(0)
                    CouponState = State.INACTIVE
                End If
                Init()

        End Select
    End Sub

    Public Sub UpdateCouponDeletePizzas(Pizza As Pizza)
        NbPizza -= Pizza.Number

        Select Case CouponState
            Case State.INACTIVE
            Case State.BLINKING
                If NbPizza < 2 Then
                    StopBlinking()
                    CouponState = State.INACTIVE
                End If
                Init()

            Case State.ACTIVE
                If NbPizza = 2 Then
                    LabelBlink.Show()
                    Blink()
                    Form1.ResetReduc(0)
                    CouponState = State.BLINKING
                End If
                If NbPizza < 2 Then
                    StopBlinking()
                    Form1.ResetReduc(0)
                    CouponState = State.INACTIVE
                End If
                Init()
        End Select
    End Sub
    Public Sub UpdateCouponEmptyCart()
        NbPizza = 0
        Select Case CouponState
            Case State.INACTIVE
            Case State.BLINKING
                StopBlinking()
                CouponState = State.INACTIVE
                Init()
            Case State.ACTIVE
                Form1.ResetReduc(0)
                CouponState = State.INACTIVE
                Init()

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
