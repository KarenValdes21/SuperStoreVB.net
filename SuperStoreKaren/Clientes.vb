Imports System.Data.SqlClient

Public Class Clientes
    Private query As String
    Private adapter As String
    Private conexion As String

    Private Shared cnx As SqlConnection = New SqlConnection()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        If String.IsNullOrWhiteSpace(TxtFiltro.Text) Then
            MsgBox("Por favor, revise que todos los campos estén llenos")
            Return
        End If

        Dim ClienteID As String = TxtFiltro.Text
        Dim UsuarioCrea As Integer = "1"
        Dim IdSegmento As String = CbIdSegmento.SelectedValue.ToString()
        Dim IdRegion As String = CbIdRegion.SelectedValue.ToString()

        Connection.AgregarCliente(ClienteID, UsuarioCrea, IdRegion, IdSegmento)
    End Sub



    'query = "select * from cliente"
    '  DataGridView1.DataSource = Connection.SelectQuery(query)

    '  query = "select distinct Region from Region"
    '  CbIdRegion.DataSource = Connection.SelectQuery(query)
    '  CbIdRegion.DisplayMember = "Region"

    ' query = "select id, segmento from segmento"
    '  CbIdSegmento.DataSource = Connection.SelectQuery(query)
    '  CbIdSegmento.DisplayMember = "segmento"
    '   CbIdSegmento.ValueMember = "id"
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Call cnx.Open()

            Dim cmd = New SqlCommand("SELECT IdRegion, Region FROM Region")
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(reader)

            CbIdRegion.DisplayMember = "Region"
            CbIdRegion.ValueMember = "IdRegion"
            CbIdRegion.DataSource = dt

        Catch ex As Exception
            MsgBox("Error al cargar las regiones: " & ex.Message)
        End Try
        Try

            Dim cmd = New SqlCommand("SELECT IdSegmento, Segmento FROM Segmento")
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(reader)

            CbIdSegmento.DisplayMember = "Segmento"
            CbIdSegmento.ValueMember = "IdSegmento"
            CbIdSegmento.DataSource = dt

        Catch ex As Exception
            MsgBox("Error al cargar los segmentos: " & ex.Message)

        End Try
    End Sub
End Class