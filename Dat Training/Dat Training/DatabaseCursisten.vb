Partial Class DataSet1
End Class

Partial Class DatabaseCursisten
    Partial Class CursistenDataTable

        Private Sub CursistenDataTable_CursistenRowChanging(sender As Object, e As CursistenRowChangeEvent) Handles Me.CursistenRowChanging

        End Sub

        Private Sub CursistenDataTable_ColumnChanging(sender As Object, e As Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.AchternaamColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Sub Show()
        Throw New NotImplementedException
    End Sub

End Class
