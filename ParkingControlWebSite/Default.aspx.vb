﻿Imports System.Data
Partial Class _Default
    Inherits System.Web.UI.Page
    Public datasetparkingspots As DataSet
    Public Shared latitud, longitud As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim ps As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")
            datasetparkingspots = ps.GetFrontValues()
            GridView1.DataSource = datasetparkingspots.Tables(0)
            GridView1.DataBind()
        Else
            UpdateCard
        End If
    End Sub
    Public Class parkspotscls
        Private connection As System.Data.OleDb.OleDbConnection

        Public Sub New(ByVal sentence As String)
            connection = New Data.OleDb.OleDbConnection(sentence)
            connection.Open()
        End Sub
    End Class

    Private Sub GridView1_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView1.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim ID = GridView1.Rows(index).Cells(0).Text
        UpdateStatus(ID)
    End Sub

    Private Sub UpdateCard()
        pnlCard.Visible = True
    End Sub


    Private Sub UpdateStatus(ByVal ID As Integer)
        Dim ps As New ParkingSpotsDBConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db_parkingspots.mdb")
        datasetparkingspots = ps.GetValues(ID)

        NameLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_name")
        CapacityLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_capacity")
        FromLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_open_from_day")
        ToLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_open_to_day")
        OpenLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_open_from_hour")
        CloseLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_open_to_hour")
        QuarterLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_quarter_hour_rate")
        HalfLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_half_hour_rate")
        HourLbl.Text = datasetparkingspots.Tables(0).Rows(0).Item("par_hour_rate")
        latitud = datasetparkingspots.Tables(0).Rows(0).Item("par_latitude")
        longitud = datasetparkingspots.Tables(0).Rows(0).Item("par_longitude")
        check2.Checked = True
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Default.aspx?par_id=" & ID + "&par_lat=" & latitud + "&par_long=" & longitud)
    End Sub
End Class