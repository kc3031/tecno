Imports entidad
Imports datos
Public Class Form1
    Dim fu As New fusuario
    Dim eu As New eusuario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click

        Try

            If txt_contrasena.Text <> "" And txt_usuario.Text <> "" Then
                Dim dt As New DataTable

                eu._usuario = txt_usuario.Text
                eu._contrasena = txt_contrasena.Text
                dt = fu.validarusuario(eu)
                If dt.Rows.Count > 0 Then
                    Timer1.Start()

                    Dim roll As String
                    roll = dt.Rows(0)("roll")
                    If roll = "usuario" Then
                        My.Forms.MDIParent1.msmantenimineto.Enabled = False
                    ElseIf roll = "administrador" Then

                        My.Forms.MDIParent1.MenuStrip.Enabled = True
                    End If
                Else
                    Static intento As Integer

                    intento = intento + 1
                    MsgBox("estimado usuario te quedan " & (3 - intento) & " intentos")
                    If intento = 3 Then
                        MsgBox("el sistema se cerrara, gracias", MsgBoxStyle.Critical, "SISTEMA")

                        Me.Close()
                        'inicio de proceso de apagado
                        'Process.Start("shutdiw.exe", "-s -t 00")

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            MsgBox("Bienvenido al sistema cliente" & txt_usuario.Text)
            MDIParent1.Show()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class
