Public Class DatabaseClass
    ''Author pukulot github id = pukulotskie06
    Dim con As New OleDb.OleDbConnection
    Dim dataAdapter As OleDb.OleDbDataAdapter
    Dim dataSet As DataSet
    Dim dataProvider As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="
    Dim dataSource As String = System.Environment.CurrentDirectory & "\Inventory.accdb;Persist Security Info= True;user ID=admin"
    Dim dataTables As DataTable


    Public Sub DatabaseClass(ByVal sql As String)
        dataSet = New DataSet
        con.Close()
        con.ConnectionString = dataProvider & dataSource
        con.Open()
        dataAdapter = New OleDb.OleDbDataAdapter(sql, con)
        dataAdapter.Fill(dataSet, "Inventory")
        dataTables = New DataTable
        dataAdapter.Fill(dataTables)

    End Sub

    Public Function DataSets() As DataSet
        Return dataSet
    End Function

    Public Function DataTabless() As DataTable
        Return dataTables
    End Function

End Class


