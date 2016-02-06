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
        ChangeLabelCouponText_Presentation(0)
    End Sub

    Public Sub Init_Dialog()
        Select Case CouponState
            Case State.INACTIVE
                ChangeCouponColor_Presentation(Color.White)
            Case State.BLINKING
                ChangeCouponColor_Presentation(Color.White)
            Case State.ACTIVE
                ChangeCouponColor_Presentation(Color.Green)
        End Select
    End Sub

    Public Sub UpdateCouponAdd(Pizza As Pizza)
        NbPizza += 1
        Select Case CouponState
            Case State.INACTIVE
                If NbPizza < 2 Then
                    CouponState = State.INACTIVE
                End If
                If NbPizza >= 2 Then
                    ShowLabelBlink_Presentation()
                    Blink()
                    CouponState = State.BLINKING
                End If
                Init_Dialog()
            Case State.BLINKING
                StopBlinking_Dialog()
                NbCoupons += 1
                ChangeLabelCouponText_Presentation(NbCoupons)
                Form1.IncrementReducBy_Dialog(5.0)
                CouponState = State.ACTIVE
                Init_Dialog()

            Case State.ACTIVE
                If NbPizza Mod 3 = 2 Then
                    ShowLabelBlink_Presentation()
                    Blink()
                    CouponState = State.BLINKING
                End If
                Init_Dialog()
        End Select
    End Sub

    Public Sub UpdateCouponDeleteOnePizza()
        NbPizza -= 1
        Select Case CouponState
            Case State.INACTIVE
            Case State.BLINKING
                If NbPizza < 2 Then
                    StopBlinking_Dialog()
                    CouponState = State.INACTIVE
                End If
                If NbPizza >= 2 And NbPizza Mod 3 = 0 Then
                    StopBlinking_Dialog()
                    CouponState = State.ACTIVE
                End If
                Init_Dialog()
            Case State.ACTIVE
                If NbPizza < 2 Then
                    NbCoupons = 0
                    ChangeLabelCouponText_Presentation(NbCoupons)
                    Form1.SetReduc_Dialog(0)
                    CouponState = State.INACTIVE
                End If
                If NbPizza >= 2 And NbPizza Mod 3 = 2 Then
                    NbCoupons -= 1
                    ChangeLabelCouponText_Presentation(NbCoupons)
                    Form1.SetReduc_Dialog(5 * NbCoupons)
                    ShowLabelBlink_Presentation()
                    Blink()
                    CouponState = State.BLINKING
                End If
                Init_Dialog()

        End Select
    End Sub

    Public Sub UpdateCouponDeletePizzas_Dialog(Pizza As Pizza)
        NbPizza -= Pizza.Number
        Select Case CouponState
            Case State.INACTIVE
            Case State.BLINKING
                If NbPizza < 2 Then
                    StopBlinking_Dialog()
                    CouponState = State.INACTIVE
                End If
                If NbPizza >= 2 Then
                    StopBlinking_Dialog()
                    CouponState = State.ACTIVE
                End If
                Init_Dialog()

            Case State.ACTIVE
                If NbPizza < 2 Then
                    NbCoupons = 0
                    ChangeLabelCouponText_Presentation(NbCoupons)
                    Form1.SetReduc_Dialog(0)
                    CouponState = State.INACTIVE

                ElseIf NbPizza >= 2 And NbPizza Mod 3 = 2 Then
                    ShowLabelBlink_Presentation()
                    Blink()
                    NbCoupons = Int(NbPizza / 3)
                    ChangeLabelCouponText_Presentation(NbCoupons)
                    Form1.SetReduc_Dialog(5 * NbCoupons)
                    CouponState = State.BLINKING

                Else
                    NbCoupons = Int(NbPizza / 3)
                    ChangeLabelCouponText_Presentation(NbCoupons)
                    Form1.SetReduc_Dialog(5 * NbCoupons)
                    CouponState = State.ACTIVE
                End If

                Init_Dialog()

        End Select
    End Sub

    Public Sub UpdateCouponEmptyCart_Dialog()
        NbPizza = 0
        Select Case CouponState
            Case State.INACTIVE
            Case State.BLINKING
                StopBlinking_Dialog()
                NbCoupons = 0
                ChangeLabelCouponText_Presentation(NbCoupons)
                Form1.SetReduc_Dialog(0)
                CouponState = State.INACTIVE
                Init_Dialog()
            Case State.ACTIVE
                NbCoupons = 0
                ChangeLabelCouponText_Presentation(NbCoupons)
                Form1.SetReduc_Dialog(0)
                CouponState = State.INACTIVE
                Init_Dialog()
        End Select
    End Sub

    Private Sub Blink()
        Timer1.Interval = 1500
        Timer1.Start()
    End Sub
    Private Sub StopBlinking_Dialog()
        Timer1.Stop()
        SetNotVisibleLabelBlink_Presentation()
    End Sub

    Private Sub SetNotVisibleLabelBlink_Presentation()
        LabelBlink.Visible = False
    End Sub

    Private Sub ChangeCouponColor_Presentation(Color As Color)
        PanelCoupon.BackColor = Color
    End Sub

    Private Sub ChangeLabelCouponText_Presentation(Text As String)
        LabelNbCoupons.Text = Text
    End Sub

    Private Sub ShowLabelBlink_Presentation()
        LabelBlink.Show()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LabelBlinkingTimerHandler_Dialog()
    End Sub

    Private Sub LabelBlinkingTimerHandler_Dialog()
        ChangeLabelBlinkVisibility_Presentation()
    End Sub

    Private Sub ChangeLabelBlinkVisibility_Presentation()
        If Not LabelBlink.Visible Then
            LabelBlink.Visible = True
        Else
            LabelBlink.Visible = False
        End If
    End Sub
End Class
