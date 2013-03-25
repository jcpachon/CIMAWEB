Public Class CIMA

    Public Function f_consulta(ByVal sql As String, ByVal cadena_conexion As String) As Data.DataSet

        Dim objConn As New SqlClient.SqlConnection

        Dim objDA As New SqlClient.SqlDataAdapter(sql, cadena_conexion)

        Dim objDS As New Data.DataSet

        objConn.ConnectionString = cadena_conexion

        objDA.SelectCommand.CommandTimeout = 0

        objConn.Open()

        objDA.SelectCommand.CommandType = CommandType.Text '.StoredProcedure
        objDA.SelectCommand.CommandText = "EXEC " & sql

        objDA.SelectCommand.Connection.Open()

        objDA.Fill(objDS)

        objConn.Close()

        objDA = Nothing
        objConn = Nothing

        f_consulta = objDS

    End Function

    Public Function f_consulta_CSaludR(ByVal sql As String, ByVal cadena_conexion As String) As Data.DataSet

        Dim objConn As New Odbc.OdbcConnection ' SqlClient.SqlConnection

        Dim objDA As New Odbc.OdbcDataAdapter(sql, cadena_conexion) ' SqlClient.SqlDataAdapter(sql, cadena_conexion)

        Dim objDS As New Data.DataSet

        objConn.ConnectionString = cadena_conexion

        objConn.ConnectionTimeout = 0

        objConn.Open()

        objDA.SelectCommand.CommandType = CommandType.Text '.StoredProcedure
        objDA.SelectCommand.CommandText = "EXEC " & sql

        objDA.SelectCommand.Connection.Open()

        objDA.Fill(objDS)

        objConn.Close()

        objDA = Nothing
        objConn = Nothing

        f_consulta_CSaludR = objDS

    End Function

    Public Function f_conectado(ByVal str_uid As String, ByVal str_sesion_id As String) As String

        Dim objCIMA As New CIMA_Clases.CIMA

        Dim objDS As New Data.DataSet

        Dim str_sql As String

        Dim retorno As String

        retorno = "N"

        str_sql = "dbo.SP_CIMACEX_SEGURIDAD_SESION '" & str_sesion_id & "','" & str_uid & "'"

        objDS = objCIMA.f_consulta(str_sql, "workstation id=ZEUS;packet size=4096;user id=sa;data source=""10.8.50.213"";persist security info=True;initial catalog=CIMACEX;password=kampeon10")

        retorno = objDS.Tables(0).Rows(0).Item(0)

        objDS = Nothing

        objCIMA = Nothing

        f_conectado = retorno

    End Function

    Public Function f_formato_fecha(ByVal str_fecha As String) As String

        Dim str_array_fecha() As String
        Dim str_array_blanco() As String

        Dim str_mes, str_dia As String

        str_array_blanco = Split(str_fecha, " ")
        str_array_fecha = Split(str_array_blanco(0), "/")

        If Len(str_array_fecha(0)) = 1 Then
            str_mes = "0" & str_array_fecha(0)
        Else
            str_mes = str_array_fecha(0)
        End If

        If Len(str_array_fecha(1)) = 1 Then
            str_dia = "0" & str_array_fecha(1)
        Else
            str_dia = str_array_fecha(1)
        End If

        f_formato_fecha = str_dia & "/" & str_mes & "/" & str_array_fecha(2)

        f_formato_fecha = str_fecha

    End Function


End Class