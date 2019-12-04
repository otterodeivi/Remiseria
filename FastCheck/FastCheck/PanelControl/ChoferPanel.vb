Public Class ChoferPanel

    Private Sub ChoferPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Dim activo As Form = Nothing

    Private Sub openChildForm(ByVal childForm As Form)
        activo = Nothing

        If activo IsNot Nothing Then
            activo.Close()
        Else

            activo = childForm
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            childForm.Dock = DockStyle.Fill
            Panel1.Controls.Add(childForm)
            Panel1.Tag = childForm
            childForm.BringToFront()
            childForm.Show()




        End If


    End Sub
End Class