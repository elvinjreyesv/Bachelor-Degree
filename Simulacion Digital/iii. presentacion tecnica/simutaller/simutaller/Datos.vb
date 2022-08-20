Imports System.Data.SqlClient
Module Datos
    'Public oConexion As New SqlConnection("Data Source=JORGE-PC;AttachDbFilename=D:\My Documents\Visual Studio 2005\Projects\copy project\copy project\data\dataCopy.mdf;Initial Catalog=DataCopy;Integrated Security=True")
    Public oConexion As New SqlConnection("server=(local);database=simutaller;integrated security=yes")
    'Public oConexion As New SqlConnection("Data Source=OYJ-PCSOLUTIONS\SQLEXPRESS;AttachDbFilename=G:\Data_cable.mdf;Initial Catalog=data_cable;Integrated Security=True")
    'Data Source=OYJ-PC;Initial Catalog=PUNVENT;Integrated Security=True
    Public oDataAdapter As New SqlDataAdapter
    Public oDataSet As New DataSet
    Public oDataset1 As New DataSet
    Public eDataset As New DataSet
    Public tDataset As New DataSet
    Public pDataset As New DataSet
    Public oDataRow As DataRow
    Public oDataTable As New DataTable
    Public oComando As New SqlCommand
    'Public CargarReporte As New RptCobro
    Public iPosicFilaActual As Integer
    Public oFila As Integer
    Public celda As String
    Public Function AbrirConexion() As Boolean
        Dim band As Boolean = False
        Try

            oConexion.Open()
            band = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return band
    End Function
    Public Function CerrarConexion() As Boolean
        Dim band As Boolean = False
        Try
            oConexion.Close()
            band = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return band
    End Function
    Public Function EjecutarTransaccion(ByVal ListaSentencias As ArrayList) As Boolean
        Dim band As Boolean = False
        If AbrirConexion() Then
            Dim command As SqlCommand = oConexion.CreateCommand()
            Dim transaction As SqlTransaction
            Dim strSentencia As Object
            Dim sentencia As String = ""
            transaction = oConexion.BeginTransaction()
            command.Connection = oConexion
            command.Transaction = transaction
            Try
                For Each strSentencia In ListaSentencias
                    sentencia = strSentencia.ToString()
                    command.CommandText = sentencia.ToString()
                    command.ExecuteNonQuery()
                Next
                transaction.Commit()
                band = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Try
                    transaction.Rollback()
                Catch ex2 As Exception
                    MessageBox.Show(ex2.Message)
                End Try
            Finally
                CerrarConexion()
            End Try
        End If
        Return band
    End Function

End Module
