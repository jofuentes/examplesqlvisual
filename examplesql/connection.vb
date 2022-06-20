Imports System.Data.SqlClient
Module connection
    'Variables para conexion SQL // SQL connection variables
    Public Ecepcion As SqlException
    Public oDataAdapter As SqlDataAdapter
    Public oDataSet As DataSet
    Public CC As SqlConnection
    Public SQL As String
    Public oDataReader As SqlDataReader
    Public CmdConsultas As New SqlCommand
    Public oComando As New SqlCommand()
    Public cadena As String
    'Proceso para ejecucion de todas las consultas // Process for executing all queries
    Public Sub query(Consulta As String)
        Try
            oComando.Connection = CC
            oComando.CommandText = Consulta
            oDataReader = oComando.ExecuteReader() 'Obtener DataReader // Get Datareader
            oComando.Dispose()
        Catch ex As SqlException
            MessageBox.Show("Error" / ex.ToString)
        End Try
    End Sub
    Public Sub login_server(user As String, password As String, server As String, database As String)
        cadena = " Password=" & password & ";Persist Security Info=True;User ID=" & user & ";Initial Catalog=" & database & ";Data Source=" & server & ""
        CC = New SqlConnection
        CC.ConnectionString = cadena
        Try
            CC.Open()
        Catch
            MsgBox(Err.Description)
            Exit Sub
        End Try
        If CC.State = ConnectionState.Open Then
            MsgBox("Conexion exitosa")
        Else
            MsgBox("Error en la conexion")
        End If
    End Sub
End Module
