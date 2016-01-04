Public Class UserControl1
    Inherits TableLayoutPanel

    Private Declare Function ShowScrollBar Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal wBar As Integer, ByVal bShow As Boolean) As Boolean
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Try
            ShowScrollBar(Handle, 0, False)
        Catch ex As Exception
        End Try
        MyBase.WndProc(m)
    End Sub

End Class
