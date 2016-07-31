Public Class Critical

    Private Sub Critical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim critical As Integer = 0
        Dim db As New DatabaseClass
        db.DatabaseClass("Select Count(Qty) As Critical From Items Where Qty < " & critical)

        If db.DataSets.Tables("Inventory").Rows.Count > 0 Then
            'MsgBox(db.DataSets().Tables("Inventory").Rows.Count)
            Label1.Text = "You have " & db.DataSets.Tables("Inventory").Rows(0).Item(0) & " critical Item/s in your Records!!"
        Else
            Label1.Text = "You have 0 critical Item in your records!!"
        End If

        db.DatabaseClass("Select * From Items Where [Qty] < " & critical)

        For x = 0 To db.DataTabless.Columns.Count - 1
            dGrid.Columns.Add(db.dataTables.Columns(x).ToString, db.dataTables.Columns(x).ToString)
        Next

        For x = 0 To db.DataSets().Tables("Inventory").Rows().Count - 1
            dGrid.Rows.Add()
            For y = 0 To db.DataSets.Tables("Inventory").Columns.Count - 1
                dGrid.Rows(x).Cells(y).Value = db.DataSets().Tables("Inventory").Rows(x).Item(y)
            Next

        Next


    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ''Main.Enabled = True
        Me.Close()

    End Sub
End Class
