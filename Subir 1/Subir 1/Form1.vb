Public Class Form1
    Dim mat(3, 4) As Integer
    Dim ran As New Random()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar(mat)
        txtImprimir.Text = Imprimir(mat)
    End Sub
    Function Inicializar(mat(,) As Integer) As Integer(,)
        For i = 0 To mat.GetUpperBound(0)
            For j = 0 To mat.GetUpperBound(1)
                mat(i, j) = ran.Next(0, 3)
            Next
        Next
        Return mat
    End Function
    Function Imprimir(mat(,) As Integer) As String
        Dim cadena As String = ""
        For i = 0 To mat.GetUpperBound(0)
            cadena += " | "
            For j = 0 To mat.GetUpperBound(1)
                cadena += mat(i, j).ToString() + " | "
            Next
            cadena += vbCrLf
        Next
        Return cadena
    End Function
    Function subir_1(mat(,) As Integer) As Integer(,)
        Dim aux As Integer
        Dim ultimo As Integer = mat.GetUpperBound(0) - 1
        For i = mat.GetUpperBound(1) To mat.GetLowerBound(1)
            For j = mat.GetUpperBound(0) To mat.GetLowerBound(0)

                If mat(i, j) = 1 Then
                    mat(i, j - 1) = aux
                    mat(i, j) = mat(i, j - 1)
                    aux = mat(i, j)
                End If

            Next

        Next
        Return mat
    End Function

    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        txtResultado.Text = Imprimir(subir_1(mat))
    End Sub
End Class