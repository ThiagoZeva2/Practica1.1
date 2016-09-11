Public Class MainForm

    Dim cant1 As Double
    Dim cant2 As Double
    Dim cant3 As Double
    Dim cant4 As Double
    Dim prec1 As Double
    Dim prec2 As Double
    Dim prec3 As Double
    Dim prec4 As Double




    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub





    Private Sub lhombres_MouseHover(sender As Object, e As EventArgs) Handles lhombres.MouseHover
        lhombres.ForeColor = Color.Blue

    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles lhombres.MouseLeave
        lhombres.ForeColor = Color.Black

    End Sub

    Private Sub lmujeres_MouseHover(sender As Object, e As EventArgs) Handles lmujeres.MouseHover
        lmujeres.ForeColor = Color.Blue

    End Sub

    Private Sub lmujeres_MouseLeave(sender As Object, e As EventArgs) Handles lmujeres.MouseLeave
        lmujeres.ForeColor = Color.Black

    End Sub




    Private Sub lcalzado_MouseHover(sender As Object, e As EventArgs) Handles lcalzado.MouseHover
        lcalzado.ForeColor = Color.Blue

    End Sub

    Private Sub lcalzado_MouseLeave(sender As Object, e As EventArgs) Handles lcalzado.MouseLeave
        lcalzado.ForeColor = Color.Black

    End Sub


    Private Sub laccesorios_MouseHover(sender As Object, e As EventArgs) Handles laccesorios.MouseHover
        laccesorios.ForeColor = Color.SteelBlue


    End Sub

    Private Sub laccesorios_MouseLeave(sender As Object, e As EventArgs) Handles laccesorios.MouseLeave
        laccesorios.ForeColor = Color.Black

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lprecios.Text = "120"
        img.Image = ilProductos.Images.Item(0)
        lblTituloProducto.Text = "CAMISA DE ALGODÓN"


    End Sub

    Private Sub fl2_Click(sender As Object, e As EventArgs) Handles fl21.Click
        If cantidad1.Text > "0" Or cantidad1.Text < "10" Then

            cantidad1.Text = cantidad1.Text + 1

        Else
            cantidad1.Enabled = False
        End If



    End Sub

    Private Sub fl1_Click(sender As Object, e As EventArgs) Handles fl11.Click


        If cantidad1.Text > "0" Or cantidad1.Text < "10" Then

            cantidad1.Text = cantidad1.Text - 1
        Else
            fl11.Enabled = True
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles fl12.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        lprecios.Text = "240"
        img.Image = ilProductos.Images.Item(1)
        lblTituloProducto.Text = "BLAZER MEZCLA DE LANA"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        lprecios.Text = "160"
        img.Image = ilProductos.Images.Item(2)
        lblTituloProducto.Text = "JERSEY CUELLO DE PICO"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        lprecios.Text = "70"
        img.Image = ilProductos.Images.Item(3)
        lblTituloProducto.Text = "POLO CUELLO REDONDO
"
    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cantidad1.Text = CDbl(cant1)
        cantidad2.Text = CDbl(cant2)
        cantidad3.Text = CDbl(cant3)
        cantidad4.Text = CDbl(cant4)
        precio1.Text = CDbl(prec1)
        precio2.Text = CDbl(prec2)
        precio3.Text = CDbl(prec3)
        precio4.Text = CDbl(prec4)

        Label32.Text = cant1 * prec1 + cant2 * prec2 + cant3 * prec3 + cant4 * prec4
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub cantidad1_Move(sender As Object, e As EventArgs) Handles cantidad1.Move

    End Sub

    Private Sub MainForm_Move(sender As Object, e As EventArgs) Handles Me.Move
        cantidad1.Text = CDbl(cant1)
        cantidad2.Text = CDbl(cant2)
        cantidad3.Text = CDbl(cant3)
        cantidad4.Text = CDbl(cant4)
        precio1.Text = CDbl(prec1)
        precio2.Text = CDbl(prec2)
        precio3.Text = CDbl(prec3)
        precio4.Text = CDbl(prec4)

        Label32.Text = cant1 * prec1 + cant2 * prec2 + cant3 * prec3 + cant4 * prec4
    End Sub
End Class