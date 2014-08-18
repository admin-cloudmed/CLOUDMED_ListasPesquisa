Partial Class WebForm1
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Insert(1, "12/12/2002", "14:00", "1111", "vista", "10,00")

    End Sub

    Function Insert(ByVal NumeroTransacao As Integer, ByVal Data As String, ByVal Hora As String, ByVal SerialMiFare As String, ByVal TipoPagamento As String, ByVal Valor As String) As Boolean
        Try
            Dim Connection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CAMINHODOBANCOCOMPLETO")
            Dim Command As New System.Data.OleDb.OleDbCommand
            Command.CommandText = "INSERT INTO transacoes(numerotransacao, data, hora, serialmifare, tipopagamento, valor) VALUES (?,?,?,?,?,?)"
            Command.Connection = Connection
            Command.Parameters.Add(New System.Data.OleDb.OleDbParameter("numerotransacao", System.Data.OleDb.OleDbType.Integer, 4, "numerotransacao"))
            Command.Parameters.Add(New System.Data.OleDb.OleDbParameter("data", System.Data.OleDb.OleDbType.VarWChar, 50, "data"))
            Command.Parameters.Add(New System.Data.OleDb.OleDbParameter("hora", System.Data.OleDb.OleDbType.VarWChar, 50, "hora"))
            Command.Parameters.Add(New System.Data.OleDb.OleDbParameter("serialmifare", System.Data.OleDb.OleDbType.VarWChar, 50, "serialmifare"))
            Command.Parameters.Add(New System.Data.OleDb.OleDbParameter("tipopagamento", System.Data.OleDb.OleDbType.Integer, 4, "tipopagamento"))
            Command.Parameters.Add(New System.Data.OleDb.OleDbParameter("valor", System.Data.OleDb.OleDbType.VarWChar, 50, "valor"))

            Command.Parameters("numerotransacao").Value = numerotransacao
            Command.Parameters("data").Value = Data
            Command.Parameters("hora").Value = hora
            Command.Parameters("serialmifare").Value = serialmifare
            Command.Parameters("tipopagamento").Value = tipopagamento
            Command.Parameters("valor").Value = valor
            Command.Connection.Open()
            Command.ExecuteNonQuery()
            Command.Connection.Close()
        Catch
            Return False
        End Try
    End Function




End Class
