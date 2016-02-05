Public Class CouponView

    Enum State
        INACTIVE
        BLINKING
        ACTIVE
    End Enum

    Private CouponState As State
    Private NbPizza As Integer
    Private NbCoupons As Integer
    Public Sub New()
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
    End Sub

    Public Sub AddCoupon(Coupon As Coupon)
        LabelCoupon.Text = Coupon.GetDescription
        LabelBlink.Text = Coupon.GetCatchPhrase
        LabelBlink.Visible = False
        CouponState = State.INACTIVE
        NbPizza = 0
        NbCoupons = 0
        ChangeLabelCouponText(0)
    End Sub

    Public Sub Init()
        Select Case CouponState
            Case State.INACTIVE
                ChangeCouponColor(Color.White)
            Case State.BLINKING
                ChangeCouponColor(Color.White)
            Case State.ACTIVE
                ChangeCouponColor(Color.Green)
        End Select
    End Sub

      Public Sub UpdateCouponAdd(Pizza As Pizza)
        NbPizza += 1
        Select Case CouponState
            Case State.INACTIVE
                If NbPizza Mod 3 = 1 Then
                    CouponState = State.INACTIVE
                End If
                If NbPizza Mod 3 = 2 Then
                    Blink()
                    CouponState = State.BLINKING
                End If
                Init()
            Case State.BLINKING
                StopBlinking()
                NbCoupons += 1
                ChangeLabelCouponText(NbCoupons)
                Form1.SetReduc(5.0)
                CouponState = State.ACTIVE
                Init()

            Case State.ACTIVE
                CouponState = State.INACTIVE
                Init()
        End Select
    End Sub

    Public Sub UpdateCouponDeleteOnePizza()
        NbPizza -= 1
        Select Case CouponState
            Case State.INACTIVE
                If NbPizza Mod 3 = 2 Then
                    ShowLabelBlink()
                    Blink()
                    NbCoupons -= 1
                    ChangeLabelCouponText(NbCoupons)
                    Form1.ResetReduc(5 * NbCoupons)
                    CouponState = State.BLINKING
                End If
                Init()
            Case State.BLINKING
                If NbPizza Mod 3 = 2 Then
                    StopBlinking()
                    CouponState = State.INACTIVE
                End If
                Init()

            Case State.ACTIVE
                ShowLabelBlink()
                Blink()
                NbCoupons -= 1
                ChangeLabelCouponText(NbCoupons)
                Form1.ResetReduc(5 * NbCoupons)
                CouponState = State.BLINKING
                Init()

        End Select
    End Sub

    Public Sub UpdateCouponDeletePizzas(Pizza As Pizza)
        NbPizza -= Pizza.Number
        Select Case CouponState
            Case State.INACTIVE
                ShowLabelBlink()
                Blink()
                NbCoupons = Int(NbPizza / 3)
                ChangeLabelCouponText(NbCoupons)
                Form1.ResetReduc(5 * NbCoupons)
                CouponState = State.BLINKING
                Init()
            Case State.BLINKING
                If NbPizza Mod 3 = 2 Then
                    StopBlinking()
                    CouponState = State.INACTIVE
                End If
                Init()

            Case State.ACTIVE
                If NbPizza Mod 3 = 2 Then
                    ShowLabelBlink()
                    Blink()
                    NbCoupons = Int(NbPizza / 3)
                    ChangeLabelCouponText(NbCoupons)
                    Form1.ResetReduc(5 * NbCoupons)
                    CouponState = State.BLINKING
                End If
                If NbPizza Mod 3 = 0 Or NbPizza Mod 3 = 1 Then
                    StopBlinking()
                    NbCoupons = Int(NbPizza / 3)
                    ChangeLabelCouponText(NbCoupons)
                    Form1.ResetReduc(5 * NbCoupons)
                    CouponState = State.INACTIVE
                End If
                Init()

        End Select
    End Sub

    Public Sub UpdateCouponEmptyCart()
        NbPizza = 0
        Select Case CouponState
            Case State.INACTIVE
                NbCoupons = 0
                ChangeLabelCouponText(NbCoupons)
                Form1.ResetReduc(0)
                CouponState = State.INACTIVE
                Init()
            Case State.BLINKING
                StopBlinking()
                CouponState = State.INACTIVE
                Init()
            Case State.ACTIVE
                NbCoupons = 0
                ChangeLabelCouponText(NbCoupons)
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

    Private Sub ChangeCouponColor(Color As Color)
        PanelCoupon.BackColor = Color
    End Sub

    Private Sub ChangeLabelCouponText(Text As String)
        LabelNbCoupons.Text = Text
    End Sub

    Private Sub ShowLabelBlink()
        LabelBlink.Show()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not LabelBlink.Visible Then
            LabelBlink.Visible = True
        Else
            LabelBlink.Visible = False
        End If
    End Sub
End Class
