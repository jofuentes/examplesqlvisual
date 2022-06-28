Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call login_server(TB_User.Text, TB_Password.Text, TB_Server.Text, TB_Database.Text)
    End Sub

    Private Sub QueryDGV_Click(sender As Object, e As EventArgs) Handles QueryDGV.Click
        Call CargarReporte("select * from correos")
    End Sub
    Public Sub CargarReporte(ByVal selectCommand As String)
        Try
            ' LA conexion es CC
            ' Create a new data adapter based on the specified query.
            Dim dataAdapter = New SqlDataAdapter(selectCommand, CC)
            ' Create a command builder to generate SQL update, insert, and
            ' delete commands based on selectCommand. These are used to
            ' update the database.
            Dim commandBuilder As New SqlCommandBuilder(dataAdapter)
            ' Populate a new data table and bind it to the BindingSource.
            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            dataAdapter.Fill(table)
            BS1.DataSource = table
            ' Resize the DataGridView columns to fit the newly loaded content.
            'Me.DataGridViewIngresos.AutoResizeColumns( _
            'DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
            Me.DGV1.DataSource = Me.BS1
            'oDataReader.Close()
            'oComando.Dispose()
        Catch ex As SqlException
            MessageBox.Show("Error Al Cargar Los Datos De La Tabla" + ex.ToString)
        End Try
        'oDataReader.Close()
        'oComando.Dispose()
    End Sub
End Class
