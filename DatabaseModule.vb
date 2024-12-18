Imports MySql.Data.MySqlClient
Imports MySql.Data
Module DatabaseModule
    Private connectionString As String = "server=localhost;user=Yohan;password=Yohan;port=3307;database=offline_exam"
    Public conn As New MySqlConnection(connectionString)
    Dim rs As Boolean
    ' Method to open the database connection
    Public Function openconnection() As Boolean
        Dim rs As Boolean = False
        Try
            If conn Is Nothing Then
                conn = New MySqlConnection(connectionString)
            End If

            If conn.State = ConnectionState.Closed Then
                conn.Open()
                rs = True
            End If
        Catch ex As Exception
            MsgBox("DBOPEN: " & ex.Message)
            rs = False
        End Try
        Return rs
    End Function

    ' Method to close the database connection
    Public Function closeconnection() As Boolean
        Dim rs As Boolean = False
        Try
            If conn Is Nothing Then
                conn = New MySqlConnection(connectionString)
            End If

            If conn.State = ConnectionState.Open Then
                conn.Close()
                rs = True
            End If
        Catch ex As Exception
            MsgBox("DBCLOSE: " & ex.Message)
            rs = False
        End Try
        Return rs
    End Function
End Module