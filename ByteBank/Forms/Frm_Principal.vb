Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        Me.Text = "Principal"
        Lbl_Principal.Text = "Principal"

    End Sub

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_click_Click(sender As Object, e As EventArgs) Handles btn_click.Click
        Dim funcionario As New Funcionario
        funcionario.nome = "Matheus"
        funcionario.cpf = "111.222.333-50"
        funcionario.salario = 10000

        MsgBox("O salario do " + funcionario.nome + " é " + funcionario.salario.ToString)
        MsgBox("A bonificação dele será de " + funcionario.ObterBoficacao.ToString)
    End Sub
End Class
