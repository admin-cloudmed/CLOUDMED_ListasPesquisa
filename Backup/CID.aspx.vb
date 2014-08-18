Partial Class consulta_cid
    Inherits System.Web.UI.Page

    Protected WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Protected WithEvents ADAPTER_CAPITULO As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents ADAPTER_GRUPO As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Protected WithEvents ADAPTER_CID_3 As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand4 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand4 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand4 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand4 As System.Data.OleDb.OleDbCommand
    Protected WithEvents ADAPTER_CID_4 As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents DataSet11 As ListasPesquisa.DataSet1
    'Dim perfil As Perfil
#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.ADAPTER_CAPITULO = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.ADAPTER_GRUPO = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.ADAPTER_CID_3 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand4 = New System.Data.OleDb.OleDbCommand
        Me.ADAPTER_CID_4 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet11 = New ListasPesquisa.DataSet1
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CAPITULO_CID_FINAL, CAPITULO_CID_INICIAL, CAPITULO_CODIGO, capitulo_descri" & _
        "cao FROM CID_CAPITULO"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Inetpub" & _
        "\wwwroot\ListasPesquisa\Dados\Informacoes_Basicas.mdb;Mode=Share Deny None;Exten" & _
        "ded Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OL" & _
        "EDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode" & _
        "=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet " & _
        "OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:" & _
        "Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Co" & _
        "mpact Without Replica Repair=False;Jet OLEDB:SFP=False"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO CID_CAPITULO(CAPITULO_CID_FINAL, CAPITULO_CID_INICIAL, CAPITULO_CODIG" & _
        "O, capitulo_descricao) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CAPITULO_CID_FINAL", System.Data.OleDb.OleDbType.VarWChar, 50, "CAPITULO_CID_FINAL"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CAPITULO_CID_INICIAL", System.Data.OleDb.OleDbType.VarWChar, 50, "CAPITULO_CID_INICIAL"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CAPITULO_CODIGO", System.Data.OleDb.OleDbType.VarWChar, 50, "CAPITULO_CODIGO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("capitulo_descricao", System.Data.OleDb.OleDbType.VarWChar, 100, "capitulo_descricao"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE CID_CAPITULO SET CAPITULO_CID_FINAL = ?, CAPITULO_CID_INICIAL = ?, CAPITUL" & _
        "O_CODIGO = ?, capitulo_descricao = ? WHERE (CAPITULO_CODIGO = ?) AND (CAPITULO_C" & _
        "ID_FINAL = ?) AND (CAPITULO_CID_INICIAL = ?) AND (capitulo_descricao = ?)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CAPITULO_CID_FINAL", System.Data.OleDb.OleDbType.VarWChar, 50, "CAPITULO_CID_FINAL"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CAPITULO_CID_INICIAL", System.Data.OleDb.OleDbType.VarWChar, 50, "CAPITULO_CID_INICIAL"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CAPITULO_CODIGO", System.Data.OleDb.OleDbType.VarWChar, 50, "CAPITULO_CODIGO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("capitulo_descricao", System.Data.OleDb.OleDbType.VarWChar, 100, "capitulo_descricao"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CAPITULO_CODIGO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAPITULO_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CAPITULO_CID_FINAL", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAPITULO_CID_FINAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CAPITULO_CID_INICIAL", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAPITULO_CID_INICIAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_capitulo_descricao", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "capitulo_descricao", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM CID_CAPITULO WHERE (CAPITULO_CODIGO = ?) AND (CAPITULO_CID_FINAL = ?)" & _
        " AND (CAPITULO_CID_INICIAL = ?) AND (capitulo_descricao = ?)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CAPITULO_CODIGO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAPITULO_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CAPITULO_CID_FINAL", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAPITULO_CID_FINAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CAPITULO_CID_INICIAL", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAPITULO_CID_INICIAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_capitulo_descricao", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "capitulo_descricao", System.Data.DataRowVersion.Original, Nothing))
        '
        'ADAPTER_CAPITULO
        '
        Me.ADAPTER_CAPITULO.DeleteCommand = Me.OleDbDeleteCommand1
        Me.ADAPTER_CAPITULO.InsertCommand = Me.OleDbInsertCommand1
        Me.ADAPTER_CAPITULO.SelectCommand = Me.OleDbSelectCommand1
        Me.ADAPTER_CAPITULO.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CID_CAPITULO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CAPITULO_CODIGO", "CAPITULO_CODIGO"), New System.Data.Common.DataColumnMapping("capitulo_descricao", "capitulo_descricao"), New System.Data.Common.DataColumnMapping("CAPITULO_CID_INICIAL", "CAPITULO_CID_INICIAL"), New System.Data.Common.DataColumnMapping("CAPITULO_CID_FINAL", "CAPITULO_CID_FINAL")})})
        Me.ADAPTER_CAPITULO.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT CG_CID_FINAL, CG_CID_INICIAL, CG_CODIGO, CG_DESCRICAO FROM CID_GRUPO"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO CID_GRUPO(CG_CID_FINAL, CG_CID_INICIAL, CG_CODIGO, CG_DESCRICAO) VALU" & _
        "ES (?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CG_CID_FINAL", System.Data.OleDb.OleDbType.VarWChar, 10, "CG_CID_FINAL"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CG_CID_INICIAL", System.Data.OleDb.OleDbType.VarWChar, 10, "CG_CID_INICIAL"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CG_CODIGO", System.Data.OleDb.OleDbType.VarWChar, 10, "CG_CODIGO"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CG_DESCRICAO", System.Data.OleDb.OleDbType.VarWChar, 150, "CG_DESCRICAO"))
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE CID_GRUPO SET CG_CID_FINAL = ?, CG_CID_INICIAL = ?, CG_CODIGO = ?, CG_DESC" & _
        "RICAO = ? WHERE (CG_DESCRICAO = ?) AND (CG_CID_FINAL = ? OR ? IS NULL AND CG_CID" & _
        "_FINAL IS NULL) AND (CG_CID_INICIAL = ? OR ? IS NULL AND CG_CID_INICIAL IS NULL)" & _
        " AND (CG_CODIGO = ?)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CG_CID_FINAL", System.Data.OleDb.OleDbType.VarWChar, 10, "CG_CID_FINAL"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CG_CID_INICIAL", System.Data.OleDb.OleDbType.VarWChar, 10, "CG_CID_INICIAL"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CG_CODIGO", System.Data.OleDb.OleDbType.VarWChar, 10, "CG_CODIGO"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CG_DESCRICAO", System.Data.OleDb.OleDbType.VarWChar, 150, "CG_DESCRICAO"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CG_DESCRICAO", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CG_DESCRICAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CG_CID_FINAL", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CG_CID_FINAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CG_CID_FINAL1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CG_CID_FINAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CG_CID_INICIAL", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CG_CID_INICIAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CG_CID_INICIAL1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CG_CID_INICIAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CG_CODIGO", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CG_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM CID_GRUPO WHERE (CG_DESCRICAO = ?) AND (CG_CID_FINAL = ? OR ? IS NULL" & _
        " AND CG_CID_FINAL IS NULL) AND (CG_CID_INICIAL = ? OR ? IS NULL AND CG_CID_INICI" & _
        "AL IS NULL) AND (CG_CODIGO = ?)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CG_DESCRICAO", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CG_DESCRICAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CG_CID_FINAL", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CG_CID_FINAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CG_CID_FINAL1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CG_CID_FINAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CG_CID_INICIAL", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CG_CID_INICIAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CG_CID_INICIAL1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CG_CID_INICIAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CG_CODIGO", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CG_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        '
        'ADAPTER_GRUPO
        '
        Me.ADAPTER_GRUPO.DeleteCommand = Me.OleDbDeleteCommand2
        Me.ADAPTER_GRUPO.InsertCommand = Me.OleDbInsertCommand2
        Me.ADAPTER_GRUPO.SelectCommand = Me.OleDbSelectCommand2
        Me.ADAPTER_GRUPO.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CID_GRUPO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CG_CODIGO", "CG_CODIGO"), New System.Data.Common.DataColumnMapping("CG_DESCRICAO", "CG_DESCRICAO"), New System.Data.Common.DataColumnMapping("CG_CID_INICIAL", "CG_CID_INICIAL"), New System.Data.Common.DataColumnMapping("CG_CID_FINAL", "CG_CID_FINAL")})})
        Me.ADAPTER_GRUPO.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT cd_grupo_codigo, cd_grupo_descricao FROM CID_3"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO CID_3(cd_grupo_codigo, cd_grupo_descricao) VALUES (?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("cd_grupo_codigo", System.Data.OleDb.OleDbType.VarWChar, 4, "cd_grupo_codigo"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("cd_grupo_descricao", System.Data.OleDb.OleDbType.VarWChar, 82, "cd_grupo_descricao"))
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE CID_3 SET cd_grupo_codigo = ?, cd_grupo_descricao = ? WHERE (cd_grupo_codi" & _
        "go = ?) AND (cd_grupo_descricao = ? OR ? IS NULL AND cd_grupo_descricao IS NULL)" & _
        ""
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("cd_grupo_codigo", System.Data.OleDb.OleDbType.VarWChar, 4, "cd_grupo_codigo"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("cd_grupo_descricao", System.Data.OleDb.OleDbType.VarWChar, 82, "cd_grupo_descricao"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_cd_grupo_codigo", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cd_grupo_codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_cd_grupo_descricao", System.Data.OleDb.OleDbType.VarWChar, 82, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cd_grupo_descricao", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_cd_grupo_descricao1", System.Data.OleDb.OleDbType.VarWChar, 82, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cd_grupo_descricao", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM CID_3 WHERE (cd_grupo_codigo = ?) AND (cd_grupo_descricao = ? OR ? IS" & _
        " NULL AND cd_grupo_descricao IS NULL)"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_cd_grupo_codigo", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cd_grupo_codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_cd_grupo_descricao", System.Data.OleDb.OleDbType.VarWChar, 82, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cd_grupo_descricao", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_cd_grupo_descricao1", System.Data.OleDb.OleDbType.VarWChar, 82, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cd_grupo_descricao", System.Data.DataRowVersion.Original, Nothing))
        '
        'ADAPTER_CID_3
        '
        Me.ADAPTER_CID_3.DeleteCommand = Me.OleDbDeleteCommand3
        Me.ADAPTER_CID_3.InsertCommand = Me.OleDbInsertCommand3
        Me.ADAPTER_CID_3.SelectCommand = Me.OleDbSelectCommand3
        Me.ADAPTER_CID_3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CID_3", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cd_grupo_codigo", "cd_grupo_codigo"), New System.Data.Common.DataColumnMapping("cd_grupo_descricao", "cd_grupo_descricao")})})
        Me.ADAPTER_CID_3.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbSelectCommand4
        '
        Me.OleDbSelectCommand4.CommandText = "SELECT codigo_cid, descricao_cid FROM CID_4"
        Me.OleDbSelectCommand4.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand4
        '
        Me.OleDbInsertCommand4.CommandText = "INSERT INTO CID_4(codigo_cid, descricao_cid) VALUES (?, ?)"
        Me.OleDbInsertCommand4.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("codigo_cid", System.Data.OleDb.OleDbType.VarWChar, 5, "codigo_cid"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("descricao_cid", System.Data.OleDb.OleDbType.VarWChar, 54, "descricao_cid"))
        '
        'OleDbUpdateCommand4
        '
        Me.OleDbUpdateCommand4.CommandText = "UPDATE CID_4 SET codigo_cid = ?, descricao_cid = ? WHERE (codigo_cid = ?) AND (de" & _
        "scricao_cid = ? OR ? IS NULL AND descricao_cid IS NULL)"
        Me.OleDbUpdateCommand4.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("codigo_cid", System.Data.OleDb.OleDbType.VarWChar, 5, "codigo_cid"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("descricao_cid", System.Data.OleDb.OleDbType.VarWChar, 54, "descricao_cid"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_codigo_cid", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "codigo_cid", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_descricao_cid", System.Data.OleDb.OleDbType.VarWChar, 54, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descricao_cid", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_descricao_cid1", System.Data.OleDb.OleDbType.VarWChar, 54, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descricao_cid", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand4
        '
        Me.OleDbDeleteCommand4.CommandText = "DELETE FROM CID_4 WHERE (codigo_cid = ?) AND (descricao_cid = ? OR ? IS NULL AND " & _
        "descricao_cid IS NULL)"
        Me.OleDbDeleteCommand4.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_codigo_cid", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "codigo_cid", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_descricao_cid", System.Data.OleDb.OleDbType.VarWChar, 54, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descricao_cid", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_descricao_cid1", System.Data.OleDb.OleDbType.VarWChar, 54, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descricao_cid", System.Data.DataRowVersion.Original, Nothing))
        '
        'ADAPTER_CID_4
        '
        Me.ADAPTER_CID_4.DeleteCommand = Me.OleDbDeleteCommand4
        Me.ADAPTER_CID_4.InsertCommand = Me.OleDbInsertCommand4
        Me.ADAPTER_CID_4.SelectCommand = Me.OleDbSelectCommand4
        Me.ADAPTER_CID_4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CID_4", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("codigo_cid", "codigo_cid"), New System.Data.Common.DataColumnMapping("descricao_cid", "descricao_cid")})})
        Me.ADAPTER_CID_4.UpdateCommand = Me.OleDbUpdateCommand4
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("pt-BR")
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'UpdateListaCID()
        'If Request.QueryString("StringConexao") <> "" Then
        'Dim StringConexao As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Inetpub\wwwroot\ListasPesquisa\Dados\Informacoes_Basicas.mdb"
        OleDbConnection1.ConnectionString = GetStringConexao()
        If descricao.Checked = True Then
            controlador.Value = 2
        Else
            controlador.Value = 1
        End If
        If Not IsPostBack Then
            Session("sort") = ""
            ADAPTER_CAPITULO.SelectCommand.CommandText = "select * from cid_capitulo order by capitulo_descricao"
            ADAPTER_CAPITULO.Fill(DataSet11, "CID_CAPITULO")
            LIST_CAPITULO.DataBind()
            Tableok.Visible = False
            table_OK.Visible = False
        End If
        'Else
        '    Response.Write("Erro ao tentar se conectar ao Banco de Dados." & "<br>" & "String de Conexão Vazia")
        'End If
    End Sub

    Sub UpdateListaCID()
        Dim CIDFUll As String = Registro.Misc.FileToString(AppDomain.CurrentDomain.BaseDirectory & "Dados/cid.csv")
        Dim i As Integer
        For i = 0 To CIDFUll.Split(Chr(13) & Chr(10)).Length - 1
            Dim Linha As String = CIDFUll.Split(Chr(13) & Chr(10))(i)
            Linha = Linha.Replace(Chr(13), "")
            Linha = Linha.Replace(Chr(10), "")
            Dim Connection As New OleDb.OleDbConnection(GetStringConexao)
            Dim Command As New OleDb.OleDbCommand("INSERT INTO CID_4(codigo_cid, descricao_cid) VALUES (?, ?)", Connection)
            Try
                Dim CodCid As String = Linha.Split(";")(0)
                Dim DescricaoCid As String = Linha.Split(";")(4)


                Command.Parameters.Add(New System.Data.OleDb.OleDbParameter("codigo_cid", System.Data.OleDb.OleDbType.VarWChar, 5, "codigo_cid"))
                Command.Parameters.Add(New System.Data.OleDb.OleDbParameter("descricao_cid", System.Data.OleDb.OleDbType.VarWChar, 54, "descricao_cid"))

                Command.Parameters("codigo_cid").Value = CodCid
                Command.Parameters("descricao_cid").Value = DescricaoCid

                Command.Connection.Open()
                Command.ExecuteNonQuery()
                Command.Connection.Close()
            Catch
                Try
                    Command.Connection.Close()
                Catch ex As Exception

                End Try
            End Try


        Next

    End Sub


#Region "Pesquisa por Capítulo"
#Region "comandos das lists"
    Private Sub selecionar_agrupamento()
        OleDbSelectCommand2.CommandText = "select * from CID_GRUPO where CG_CID_INICIAL>=? AND CG_CID_FINAL<=?"
        Me.OleDbSelectCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CG_CID_INICIAL", System.Data.OleDb.OleDbType.VarWChar, 10, "CG_CID_INICIAL"))
        Me.OleDbSelectCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CG_CID_FINAL", System.Data.OleDb.OleDbType.VarWChar, 10, "CG_CID_FINAL"))
        OleDbSelectCommand2.Parameters("CG_CID_INICIAL").Value = Session("primeiro_cid")
        OleDbSelectCommand2.Parameters("CG_CID_FINAL").Value = Session("segundo_cid")
        ADAPTER_GRUPO.Fill(DataSet11, "CID_GRUPO")
        LIST_AGRUPAMENTO.DataBind()
    End Sub


    Private Sub listar_cid_3()
        DataSet11.Clear()
        OleDbSelectCommand2.CommandText = "select * from CID_GRUPO where CG_DESCRICAO=?"
        Me.OleDbSelectCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CG_DESCRICAO", System.Data.OleDb.OleDbType.VarWChar, 150, "CG_DESCRICAO"))
        OleDbSelectCommand2.Parameters("CG_DESCRICAO").Value = LIST_AGRUPAMENTO.SelectedItem.Text
        ADAPTER_GRUPO.Fill(DataSet11, "CID_GRUPO")
        Session("primeiro_cid") = DataSet11.CID_GRUPO(0).CG_CID_INICIAL.ToString
        Session("segundo_cid") = DataSet11.CID_GRUPO(0).CG_CID_FINAL.ToString

        OleDbSelectCommand3.CommandText = "select * from CID_3 where cd_grupo_codigo between ? and ?"
        Me.OleDbSelectCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("cd_grupo_codigo1", System.Data.OleDb.OleDbType.VarWChar, 4, "cd_grupo_codigo"))
        Me.OleDbSelectCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("cd_grupo_codigo2", System.Data.OleDb.OleDbType.VarWChar, 4, "cd_grupo_codigo"))
        OleDbSelectCommand3.Parameters("cd_grupo_codigo1").Value = Session("primeiro_cid")
        OleDbSelectCommand3.Parameters("cd_grupo_codigo2").Value = Session("segundo_cid")
        ADAPTER_CID_3.Fill(DataSet11, "CID_3")
        list_cid_3.DataBind()
        agrupamento_cid.Text = LIST_AGRUPAMENTO.SelectedItem.Text
    End Sub

    Private Sub listar_cid_4()
        OleDbSelectCommand4.CommandText = "select * from CID_4 where codigo_cid like ?"
        Me.OleDbSelectCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("codigo_cid", System.Data.OleDb.OleDbType.VarWChar, 5, "codigo_cid"))
        OleDbSelectCommand4.Parameters("codigo_cid").Value = list_cid_3.SelectedItem.Value + "%"
        ADAPTER_CID_4.Fill(DataSet11, "CID_4")
        list_cid_4.DataBind()
        If list_cid_4.Items.Count = "1" Then
            numero_cid.Text = list_cid_4.Items(0).Value
            capitulo_cid.Text = LIST_CAPITULO.SelectedItem.Text
            subgrupo_cid.Text = list_cid_3.SelectedItem.Text
            agrupamento_cid.Text = LIST_AGRUPAMENTO.SelectedItem.Text
            descricao_cid.Text = list_cid_4.Items(0).Text
            Hidden1.Value = numero_cid.Text
            Hidden2.Value = descricao_cid.Text
            table_OK.Visible = True
        Else
            subgrupo_cid.Text = list_cid_3.SelectedItem.Text
        End If
    End Sub
#End Region

#Region "click list"
    Private Sub LIST_CAPITULO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIST_CAPITULO.SelectedIndexChanged
        list_cid_3.Items.Clear()
        list_cid_4.Items.Clear()
        numero_cid.Text = ""
        subgrupo_cid.Text = ""
        agrupamento_cid.Text = ""
        descricao_cid.Text = ""
        Hidden1.Value = ""
        Hidden2.Value = ""
        table_OK.Visible = False
        OleDbSelectCommand1.CommandText = "select * from CID_CAPITULO where capitulo_codigo= ?"
        Me.OleDbSelectCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CAPITULO_CODIGO", System.Data.OleDb.OleDbType.VarWChar, 50, "CAPITULO_CODIGO"))
        OleDbSelectCommand1.Parameters("CAPITULO_CODIGO").Value = LIST_CAPITULO.SelectedItem.Value
        ADAPTER_CAPITULO.Fill(DataSet11, "CID_CAPITULO")
        Session("primeiro_cid") = DataSet11.CID_CAPITULO(0).CAPITULO_CID_INICIAL.ToString
        Session("segundo_cid") = DataSet11.CID_CAPITULO(0).CAPITULO_CID_FINAL.ToString
        selecionar_agrupamento()
        capitulo_cid.Text = LIST_CAPITULO.SelectedItem.Text
    End Sub


    Private Sub LIST_AGRUPAMENTO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIST_AGRUPAMENTO.SelectedIndexChanged
        list_cid_4.Items.Clear()

        numero_cid.Text = ""
        subgrupo_cid.Text = ""
        descricao_cid.Text = ""
        Hidden1.Value = ""
        Hidden2.Value = ""
        table_OK.Visible = False
        listar_cid_3()
    End Sub

    Private Sub list_cid_3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_cid_3.SelectedIndexChanged
        numero_cid.Text = ""
        subgrupo_cid.Text = ""
        descricao_cid.Text = ""
        Hidden1.Value = ""
        Hidden2.Value = ""
        table_OK.Visible = False
        listar_cid_4()
    End Sub

    Private Sub selecionar_cid()
        numero_cid.Text = list_cid_4.SelectedItem.Value
        capitulo_cid.Text = LIST_CAPITULO.SelectedItem.Text
        subgrupo_cid.Text = list_cid_3.SelectedItem.Text
        agrupamento_cid.Text = LIST_AGRUPAMENTO.SelectedItem.Text
        descricao_cid.Text = list_cid_4.SelectedItem.Text
        Hidden1.Value = numero_cid.Text
        Hidden2.Value = descricao_cid.Text
        table_OK.Visible = True
    End Sub


    Private Sub list_cid_4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_cid_4.SelectedIndexChanged
        selecionar_cid()

        descricao_cid.Text = list_cid_4.SelectedItem.Text
        numero_cid.Text = list_cid_4.SelectedItem.Value

    End Sub
#End Region
#End Region

#Region "Botões de Comando"

    Private Sub btnlocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlocalizar.Click
        DataGrid1.Visible = True
        Label4.Visible = False
        Label3.Visible = False
        Session("codigo_cid") = Nothing
        Session("descricao_cid") = Nothing
        'DataGrid1.Columns(2).Visible = True
        DataGrid1.CurrentPageIndex = 0
        Me.OleDbSelectCommand4.CommandText = "" & _
       "select * from CID_4 where codigo_cid like ?"
        Me.OleDbSelectCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("codigo_cid", System.Data.OleDb.OleDbType.VarWChar, 4, "codigo_cid"))
        OleDbSelectCommand4.Parameters("codigo_cid").Value = txtcodigo_cid.Text + "%"
        Session("codigo_cid") = txtcodigo_cid.Text + "%"
        ADAPTER_CID_4.Fill(DataSet11, "CID_4")
        If DataSet11.Tables("CID_4").Rows.Count <> Nothing Then
            DataGrid1.DataBind()
            'DataGrid1.Columns(2).Visible = True
            If DataGrid1.Items.Count = 1 Then
                txtcodigo_cid.Text = DataGrid1.Items(0).Cells(0).Text
                txtdescricao_cid.Text = DataGrid1.Items(0).Cells(1).Text
                'DataGrid1.Columns(2).Visible = False
                Tableok.Visible = True
            End If
        Else
            Label3.Visible = True
        End If

    End Sub

    Private Sub btnlocalizar_descricao_cid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlocalizar_descricao_cid.Click
        DataGrid1.CurrentPageIndex = 0
        DataGrid1.Visible = True
        Label4.Visible = False
        Label3.Visible = False
        Session("codigo_cid") = Nothing
        Session("descricao_cid") = Nothing
        DataGrid1.CurrentPageIndex = 0
        'DataGrid1.Columns(2).Visible = True
        Me.OleDbSelectCommand4.CommandText = "" & _
        "select * from CID_4 where descricao_cid like ?"
        Me.OleDbSelectCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("descricao_cid", System.Data.OleDb.OleDbType.VarWChar, 55, "descricao_cid"))
        OleDbSelectCommand4.Parameters("descricao_cid").Value = "%" & txtdescricao_cid.Text & "%"
        Session("descricao_cid") = txtdescricao_cid.Text
        ADAPTER_CID_4.Fill(DataSet11, "CID_4")
        If DataSet11.Tables("CID_4").Rows.Count <> Nothing Then
            DataGrid1.DataBind()
            If DataGrid1.Items.Count = 1 Then
                txtcodigo_cid.Text = DataGrid1.Items(0).Cells(0).Text
                txtdescricao_cid.Text = DataGrid1.Items(0).Cells(1).Text
                'DataGrid1.Columns(2).Visible = False
                Tableok.Visible = True
            End If
        Else
            Label4.Visible = True
        End If


    End Sub

    Private Sub LinkButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Session("sort") = ""
        DataGrid1.CurrentPageIndex = 0
        Tableok.Visible = False
        DataGrid1.Visible = True
        Label4.Visible = False
        Label3.Visible = False
        Session("codigo_cid") = Nothing
        Session("descricao_cid") = Nothing
        'DataGrid1.Columns(2).Visible = True
        DataGrid1.CurrentPageIndex = 0
        Me.OleDbSelectCommand4.CommandText = "" & _
        "SELECT * FROM(CID_4)"
        ADAPTER_CID_4.Fill(DataSet11, "CID_4")
        DataGrid1.DataBind()
    End Sub

#End Region

#Region "Datagrid"

    Private Sub DataGrid1_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DataGrid1.DeleteCommand
        Me.OleDbSelectCommand1.CommandText = "" & _
        "select * from CID_4 where codigo_cid = ?"
        Me.OleDbSelectCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("codigo_cid", System.Data.OleDb.OleDbType.VarWChar, 5, "codigo_cid"))
        OleDbSelectCommand4.Parameters("codigo_cid").Value = e.Item.Cells(0).Text
        txtcodigo_cid.Text = e.Item.Cells(0).Text
        txtdescricao_cid.Text = e.Item.Cells(1).Text
        Session("codigo_cid") = e.Item.Cells(0).Text
        DataGrid1.CurrentPageIndex = 0
        'DataGrid1.Columns(2).Visible = False
        DataGrid1.Visible = False
        Tableok.Visible = True
    End Sub

    Sub mydatagrid_page(ByVal sender As Object, ByVal e As DataGridPageChangedEventArgs)
        Dim startpage As Integer = 0
        startpage = DataGrid1.CurrentPageIndex * DataGrid1.PageSize
        DataGrid1.CurrentPageIndex = e.NewPageIndex
        If Session("sort") <> Nothing Then
            Me.OleDbSelectCommand4.CommandText = Session("sort")
        Else
            Me.OleDbSelectCommand4.CommandText = "select * from CID_4"
        End If

        If Session("codigo_cid") <> Nothing Then
            If Session("sort") <> Nothing Then
                Me.OleDbSelectCommand4.CommandText = Session("sort")
            Else
                Me.OleDbSelectCommand4.CommandText = "select * from CID_4 where codigo_cid like ?"
            End If
            Me.OleDbSelectCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("descricao_cid", System.Data.OleDb.OleDbType.VarWChar, 55, "descricao_cid"))
            OleDbSelectCommand4.Parameters("descricao_cid").Value = Session("codigo_cid") + "%"

        End If
        If Session("descricao_cid") <> Nothing Then
            If Session("sort") <> Nothing Then
                Me.OleDbSelectCommand4.CommandText = Session("sort")
            Else
                Me.OleDbSelectCommand4.CommandText = "select * from CID_4 where descricao_cid like ?"
            End If
            Me.OleDbSelectCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("descricao_cid", System.Data.OleDb.OleDbType.VarWChar, 55, "descricao_cid"))
            OleDbSelectCommand4.Parameters("descricao_cid").Value = Session("descricao_cid") + "%"

        End If



        ADAPTER_CID_4.Fill(DataSet11, "CID_4")
        DataGrid1.DataBind()
    End Sub

    Private Sub DataGrid1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles DataGrid1.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim LinkNomeCid As HyperLink = e.Item.FindControl("HyperLink1")
            Dim LabelCodigoCid As Label = e.Item.FindControl("LabelCodigoCid")
         
            LinkNomeCid.Attributes.Add("onclick", "ReturnValue('" & LabelCodigoCid.Text & ";" & LinkNomeCid.Text & "')")
        End If
    End Sub

    Private Sub DataGrid1_SortCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles DataGrid1.SortCommand
        Me.OleDbSelectCommand4.CommandText = "select * from CID_4 ORDER BY " + e.SortExpression.ToString
        If Session("codigo_cid") <> Nothing Then
            Me.OleDbSelectCommand4.CommandText = "select * from CID_4 where codigo_cid like ? ORDER BY " + e.SortExpression.ToString
            Me.OleDbSelectCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("codigo_cid", System.Data.OleDb.OleDbType.VarWChar, 4, "codigo_cid"))
            OleDbSelectCommand4.Parameters("codigo_cid").Value = Session("codigo_cid") + "%"
        End If
        If Session("descricao_cid") <> Nothing Then
            Me.OleDbSelectCommand4.CommandText = "select * from CID_4 where descricao_cid like ? ORDER BY " + e.SortExpression.ToString
            Me.OleDbSelectCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("descricao_cid", System.Data.OleDb.OleDbType.VarWChar, 55, "descricao_cid"))
            OleDbSelectCommand4.Parameters("descricao_cid").Value = Session("descricao_cid") + "%"
        End If
        Session("sort") = OleDbSelectCommand4.CommandText
        ADAPTER_CID_4.Fill(DataSet11, "CID_4")
        DataGrid1.DataBind()
    End Sub

#End Region

#Region "String de Conexão"


    Function GetStringConexao() As String
        Try
            Return ConfigurationSettings.AppSettings("ConexaoLista")
        Catch
            Return ""
        End Try
    End Function

#End Region




End Class
