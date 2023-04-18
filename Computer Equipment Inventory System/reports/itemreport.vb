Imports CrystalDecisions.CrystalReports.Engine
Public Class frm_itemreport
    Private Sub frm_itemreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim crystal As New ReportDocument
        crystal.Load("C:\Users\63955\OneDrive - STI Valencia\Desktop\Clyde\Computer Equipment Inventory System\Computer Equipment Inventory System\reports\CrystalReport2.rpt")
        CrystalReportViewer1.ReportSource = crystal
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class