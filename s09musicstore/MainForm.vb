Public Class MainForm

    Private Total As Double = 0
    Private ComprarC1 As Boolean = True
    Private ComprarC2 As Boolean = True
    Private ComprarC3 As Boolean = True
    Private ComprarC4 As Boolean = True


    ''' <summary>
    ''' Ver - Adventure Of A Lifetime 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnVerC1_Click(sender As Object, e As EventArgs) Handles btnVerC1.Click

        lblTitulo.Text = "Adventure Of A Lifetime"
        lblArtista.Text = "Coldplay"
        lblPrecio.Text = "S/. 3.99"
        pbCover.Image = ImageList1.Images.Item(0)

    End Sub

    ''' <summary>
    ''' Ver - Thinking Out Loud
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnVerC2_Click(sender As Object, e As EventArgs) Handles btnVerC2.Click

        lblTitulo.Text = "Thinking Out Loud"
        lblArtista.Text = "Ed Sheeran"
        lblPrecio.Text = "S/. 3.20"
        pbCover.Image = ImageList1.Images.Item(1)

    End Sub

    ''' <summary>
    ''' Ver - When We Were Young
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnVerC3_Click(sender As Object, e As EventArgs) Handles btnVerC3.Click

        lblTitulo.Text = "When We Were Young"
        lblArtista.Text = "Adele"
        lblPrecio.Text = "S/. 3.50"
        pbCover.Image = ImageList1.Images.Item(2)

    End Sub

    ''' <summary>
    ''' Ver - Going Through Changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnVerC4_Click(sender As Object, e As EventArgs) Handles btnVerC4.Click

        lblTitulo.Text = "Going Through Changes"
        lblArtista.Text = "Eminem"
        lblPrecio.Text = "S/. 4.30"
        pbCover.Image = ImageList1.Images.Item(3)

    End Sub

    Private Sub btnComprarC1_Click(sender As Object, e As EventArgs) Handles btnComprarC1.Click

        If ComprarC1 Then
            Total = Total + 3.99
            btnComprarC1.Text = "Quitar"
        Else
            Total = Total - 3.99
            btnComprarC1.Text = "Comprar"
        End If
        lblTotal.Text = String.Format("S/. 0.00", Total)

    End Sub

    Private Sub btnComprarC2_Click(sender As Object, e As EventArgs) Handles btnComprarC2.Click
        If ComprarC2 Then
            Total = Total + 3.2
            btnComprarC2.Text = "Quitar"
        Else
            Total = Total - 3.2
            btnComprarC2.Text = "Comprar"
        End If
        lblTotal.Text = String.Format("S/. 0.00", Total)

    End Sub

    Private Sub btnComprarC3_Click(sender As Object, e As EventArgs) Handles btnComprarC3.Click
        If ComprarC3 Then
            Total = Total + 3.5
            btnComprarC3.Text = "Quitar"
        Else
            Total = Total - 3.5
            btnComprarC3.Text = "Comprar"
        End If
        lblTotal.Text = String.Format("S/. 0.00", Total)

    End Sub

    Private Sub btnComprarC4_Click(sender As Object, e As EventArgs) Handles btnComprarC4.Click
        If ComprarC4 Then
            Total = Total + 4.3
            btnComprarC4.Text = "Quitar"
        Else
            Total = Total - 4.3
            btnComprarC4.Text = "Comprar"
        End If
        lblTotal.Text = String.Format("S/. 0.00", Total)
    End Sub
End Class